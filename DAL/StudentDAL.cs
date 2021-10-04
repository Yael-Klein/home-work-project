using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        //מחזיר את כל התלמידים
        public List<Student> GetStudents()
        {
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                return db.Student.ToList();
            }
        }
        //מחזיר תלמיד לפי תז
        public Student GetStudent(string TZ)
        {
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                return db.Student.FirstOrDefault(student => student.studentTz == TZ);
            }
        }
        //הוספת תלמידה -צריך להוסיף לכיתת לימוד
        public int AddStudentDAL(Student s)
        {
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                try
                {
                    db.Student.Add(s);
                    db.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {

                    return 0;
                }
            }

        }

        //מחזיר שב לתלמיד להיום
        public List<HwForStudentForToday> GetHwForToday(int id)
        {
            List<HwForStudentForToday> list = new List<HwForStudentForToday>();
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                     
                var q3 = db.HwS(id).ToList();
                foreach (var item in q3)
                {
                    HwForStudentForToday hw = new HwForStudentForToday();
                    hw.HwDate = (DateTime)item.hwToStydyClassOnDate_Date;
                    hw.HwDescription = item.hwDescription;
                    hw.Deadline = (DateTime)item.deadline;
                    hw.DurationOfPreparation = (int)item.durationOfPreparation;
                    hw.VerificationQuestion = item.verificationQuestion;
                    hw.VerificationAnswer = (int)item.verificationAnswer;
                    hw.professionDescription = item.professionDescription;
                    list.Add(hw);
                }
            }
            return list;
        }
    }
}

