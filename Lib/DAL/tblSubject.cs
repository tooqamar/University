//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lib.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSubject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSubject()
        {
            this.tbl_Student_Subject_Grade = new HashSet<tbl_Student_Subject_Grade>();
        }
    
        public long ID { get; set; }
        public Nullable<long> TeacherID { get; set; }
        public Nullable<long> CourseID { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Student_Subject_Grade> tbl_Student_Subject_Grade { get; set; }
        public virtual tblCours tblCours { get; set; }
    }
}