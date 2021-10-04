using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudyGroupDAL
    {
        public List<StudyGroup> GetStudyGroup()
        {
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                return db.StudyGroup.ToList();
            }
        }
        //שליפת כיתות למורה
        public List<string> GetStudyClassForTeacher(int teacherID)
        {
            List<string> list = new List<string>();
            using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
            {
                 var q = db.getListClassesForTeacher(teacherID).ToList();
                
                foreach (var item in q)
                {
                    list.Add(item);
                }
            }

            return list;
        }





        //public List<StatusesStudentHomeWork> StatusPupil(DateTime date, string proffesion)
        //{
        //    List<StatusesStudentHomeWork> list = new List<StatusesStudentHomeWork>();
        //    StatusesStudentHomeWork status = new StatusesStudentHomeWork();
        //    using (HomeWorkProjectEntities2 db = new HomeWorkProjectEntities2())
        //    {
        //        var q = db.StatusPupilByDay(date, proffesion).ToList();
        //        foreach (var item in q)
        //        {
        //            status.StudentId = (int)item.studentId;
        //            status.StudentFirstName = item.studentFirstName;
        //            status.StudentLastName = item.studentLastName;
        //            status.StatusOfPreparation = (bool)item.statusOfPreparation;
        //            status.ProfessionDescription = item.professionDescription;
        //            list.Add(status);
        //        }
        //    }
        //    return list;
        //}
    }
}
