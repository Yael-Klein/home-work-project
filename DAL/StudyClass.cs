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
    
    public partial class StudyClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudyClass()
        {
            this.HwToStydyClassOnDate = new HashSet<HwToStydyClassOnDate>();
        }
    
        public int studyClassId { get; set; }
        public Nullable<int> studyGroupId { get; set; }
        public Nullable<int> teacherId { get; set; }
        public Nullable<int> professionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HwToStydyClassOnDate> HwToStydyClassOnDate { get; set; }
        public virtual Profession Profession { get; set; }
        public virtual StudyGroup StudyGroup { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Teacher Teacher1 { get; set; }
    }
}
