//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReportToStudentOnDate
    {
        public int reportToStudentOnDate_Id { get; set; }
        public Nullable<int> hwToStydyClassOnDate_id { get; set; }
        public Nullable<int> studentId { get; set; }
        public Nullable<bool> statusOfPreparation { get; set; }
        public Nullable<System.TimeSpan> reportingTime { get; set; }
    
        public virtual HwToStydyClassOnDate HwToStydyClassOnDate { get; set; }
        public virtual Student Student { get; set; }
    }
}
