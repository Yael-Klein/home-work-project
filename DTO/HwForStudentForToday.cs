using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HwForStudentForToday
    {
        public DateTime HwDate { get; set; }
        public string HwDescription { get; set; }
        public DateTime Deadline { get; set; }
        public int DurationOfPreparation { get; set; }
        public string VerificationQuestion { get; set; }
        public int VerificationAnswer { get; set; }
        public string professionDescription { get; set; }

        public HwForStudentForToday(DateTime hwDate, string hwDescription, DateTime deadline, int durationOfPreparation, string verificationQuestion, int verificationAnswer,string professionDescription)
        {
            HwDate = hwDate;
            HwDescription = hwDescription;
            Deadline = deadline;
            DurationOfPreparation = durationOfPreparation;
            VerificationQuestion = verificationQuestion;
            VerificationAnswer = verificationAnswer;
            professionDescription = professionDescription;
        }

        public HwForStudentForToday()
        {

        }
    }
}
