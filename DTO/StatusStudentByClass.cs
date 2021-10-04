using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class StatusStudentByClass
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public bool StatusOfPreparation { get; set; }
       // public string StudyGroupClass { get; set; }

        public StatusStudentByClass(int studentId, string studentFirstName, string studentLastName, bool statusOfPreparation, string studyGroupClass)
        {
            StudentId = studentId;
            StudentFirstName = studentFirstName;
            StudentLastName = studentLastName;
            StatusOfPreparation = statusOfPreparation;
          //  StudyGroupClass = studyGroupClass;
        }
        public StatusStudentByClass()
        {

        }
    }
}
