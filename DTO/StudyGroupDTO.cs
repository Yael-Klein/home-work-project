using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudyGroupDTO
    {
        public int studyGroupId { get; set; }
        public DateTime studyGroupYear { get; set; }
        public string studyGroupClass { get; set; }
        public StudyGroupDTO()
        {

        }
        public StudyGroupDTO(int studyGroupId, DateTime studyGroupYear, string studyGroupClass)
        {
            this.studyGroupId = studyGroupId;
            this.studyGroupYear = studyGroupYear;
            this.studyGroupClass = studyGroupClass;
        }
    }
}
