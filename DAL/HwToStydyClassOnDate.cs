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
    
    public partial class HwToStydyClassOnDate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HwToStydyClassOnDate()
        {
            this.ReportToStudentOnDate = new HashSet<ReportToStudentOnDate>();
        }
    
        public int hwToStydyClassOnDate_Id { get; set; }
        public Nullable<int> studyClassId { get; set; }
        public Nullable<System.DateTime> hwToStydyClassOnDate_Date { get; set; }
        public string hwDescription { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public Nullable<int> durationOfPreparation { get; set; }
        public string verificationQuestion { get; set; }
        public Nullable<int> verificationAnswer { get; set; }
    
        public virtual StudyClass StudyClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportToStudentOnDate> ReportToStudentOnDate { get; set; }
    }
}
