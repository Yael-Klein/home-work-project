using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ReportToStudentOnDateDTO
    {
        public int reportToStudentOnDate_Id { get; set; }
        public int hwToStydyClassOnDate_id { get; set; }
        public int studentId { get; set; }
        public bool statusOfPreparation { get; set; }
        public DateTime reportingTime { get; set; }//time
        public  HwToStydyClassOnDateDTO HwToStydyClassOnDate { get; set; }
        public  StudentDTO Student { get; set; }
        public ReportToStudentOnDateDTO()
        {

        }

        public ReportToStudentOnDateDTO(int reportToStudentOnDate_Id, int hwToStydyClassOnDate_id, int studentId, bool statusOfPreparation, DateTime reportingTime, HwToStydyClassOnDateDTO hwToStydyClassOnDate, StudentDTO student)
        {
            this.reportToStudentOnDate_Id = reportToStudentOnDate_Id;
            this.hwToStydyClassOnDate_id = hwToStydyClassOnDate_id;
            this.studentId = studentId;
            this.statusOfPreparation = statusOfPreparation;
            this.reportingTime = reportingTime;
            HwToStydyClassOnDate = hwToStydyClassOnDate;
            Student = student;
        }
    }
}
