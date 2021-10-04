using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class StatusesStudentHomeWork
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public bool StatusOfPreparation { get; set; }
        //public string ProfessionDescription { get; set; }

        public StatusesStudentHomeWork(int studentId, string studentFirstName, string studentLastName, bool statusOfPreparation, string professionDescription)
        {
            StudentId = studentId;
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
            StatusOfPreparation = statusOfPreparation;
           // ProfessionDescription = professionDescription;
        }
        public StatusesStudentHomeWork()
        {

        }

        //public StatusesStudentHomeWork Convert()
        //{
        //    StatusesStudentHomeWork s = new StatusesStudentHomeWork();
        //    s.StudentId=
        //}
    }
}
