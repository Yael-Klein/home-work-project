using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SudentInStudyGroupDTO
    {
        public int studentInStudyGroupId { get; set; }
        public int studyGroupId { get; set; }
        public int studentId { get; set; }
        public bool studentStatus { get; set; }
        public StudentDTO Student { get; set; }
        public StudyGroupDTO StudyGroup { get; set; }
        public SudentInStudyGroupDTO()
        {

        }

        public SudentInStudyGroupDTO(int studentInStudyGroupId, int studyGroupId, int studentId, bool studentStatus, StudentDTO student, StudyGroupDTO studyGroup)
        {
            this.studentInStudyGroupId = studentInStudyGroupId;
            this.studyGroupId = studyGroupId;
            this.studentId = studentId;
            this.studentStatus = studentStatus;
            Student = student;
            StudyGroup = studyGroup;
        }
    }
}
