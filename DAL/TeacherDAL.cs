using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherDAL
    {
        //מחזיר את כל המורות
        public List<Teacher> GetTeachers()
        {
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                return db.Teacher.ToList();
            }
        }
        //מוסיף מורה חדשה
        public int AddTeacher(Teacher teacher)
        {
            try
            {
                using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
                {
                    db.Teacher.Add(teacher);
                    db.SaveChanges();
                    return 1;
                    //return teacher.id??
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                return 0;
            }
        }

        //מחזיר מורה לפי שם וסיסמא
        public Teacher GetTeacher(string Name, string password)
        {
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                Teacher t = new Teacher();
                t = db.Teacher.FirstOrDefault(teacher => teacher.teacherFirstName == Name && teacher.teacherPassword == password);
                return t;
            }
        }

        //מחזיר את התלמידים וסטטוס הכנה לפי מקצוע 
        public List<StatusesStudentHomeWork> StatusPupil(string proffesion)
        {
            List<StatusesStudentHomeWork> list = new List<StatusesStudentHomeWork>();
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                var q = db.StatusPupilByDay(proffesion).ToList();
                var q2 = db.p(proffesion).ToList();
                foreach (var item in q2)
                {
                    StatusesStudentHomeWork status = new StatusesStudentHomeWork();
                    status.StudentId = item.studentId;
                    status.StudentFirstName = item.studentFirstName;
                    status.StudentLastName = item.studentLastName;
                    status.StatusOfPreparation = (bool)item.statusOfPreparation;
                    //status.ProfessionDescription = item.professionDescription;
                    list.Add(status);
                }
            }
            return list;
        }

        public TeacherDAL()
        {
        }
        //מחזיר את התלמידים וסטטוס הכנה לפי כיתה
        public List<StatusStudentByClass> StatusByClass(string studyGroupClass)
        {
            List<StatusStudentByClass> list = new List<StatusStudentByClass>();
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                var q = db.StatusStudentByClass(studyGroupClass).ToList();
                var q2 = db.s(studyGroupClass).ToList();
                foreach (var item in q2)
                {
                    StatusStudentByClass status = new StatusStudentByClass();
                    status.StudentId = item.studentId;
                    status.StudentFirstName = item.studentFirstName;
                    status.StudentLastName = item.studentLastName;
                    status.StatusOfPreparation = (bool)item.statusOfPreparation;
                    //status.StudyGroupClass = item.studyGroupClass;
                    list.Add(status);
                }
            }
            return list;
        }

        public void AddHW(HwToStydyClassOnDate hw)
        {
            try
            {
                using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
                {
                    db.HwToStydyClassOnDate.Add(hw);
                    db.SaveChanges();
                    //return 1;
                    //return teacher.id??
                }
            }
            catch (Exception)
            {
                //return 0;
            }
        }
    }
}
