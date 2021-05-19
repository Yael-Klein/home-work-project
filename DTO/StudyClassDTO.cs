using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudyClassDTO
    {
        public int studyClassId { get; set; }
        public int studyGroupId { get; set; }
        public int teacherId { get; set; }
        public int professionId { get; set; }
        public StudyClassDTO()
        {
           
        }

        public StudyClassDTO(int studyClassId, int studyGroupId, int teacherId, int professionId)
        {
            this.studyClassId = studyClassId;
            this.studyGroupId = studyGroupId;
            this.teacherId = teacherId;
            this.professionId = professionId;
        }
    }
}
