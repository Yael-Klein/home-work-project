using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HwToStydyClassOnDateDTO
    {
        public int hwToStydyClassOnDate_Id { get; set; }
        public int studyClassId { get; set; }
        public DateTime hwToStydyClassOnDate_Date { get; set; }
        public string hwDescription { get; set; }
        public DateTime deadline { get; set; }
        public int durationOfPreparation { get; set; }
        public string verificationQuestion { get; set; }
        public int verificationAnswer { get; set; }
        public virtual StudyClassDTO StudyClass { get; set; }
        public HwToStydyClassOnDateDTO()
        {

        }
        public HwToStydyClassOnDateDTO(int hwToStydyClassOnDate_Id, int studyClassId, DateTime hwToStydyClassOnDate_Date, string hwDescription, DateTime deadline, int durationOfPreparation, string verificationQuestion, int verificationAnswer, StudyClassDTO studyClass)
        {
            this.hwToStydyClassOnDate_Id = hwToStydyClassOnDate_Id;
            this.studyClassId = studyClassId;
            this.hwToStydyClassOnDate_Date = hwToStydyClassOnDate_Date;
            this.hwDescription = hwDescription;
            this.deadline = deadline;
            this.durationOfPreparation = durationOfPreparation;
            this.verificationQuestion = verificationQuestion;
            this.verificationAnswer = verificationAnswer;
            StudyClass = studyClass;
        }
    }
}
