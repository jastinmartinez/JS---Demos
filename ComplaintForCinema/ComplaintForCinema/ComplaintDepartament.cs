//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComplaintForCinema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ComplaintDepartament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComplaintDepartament()
        {
            this.Complaint_ComplaintDepartament = new HashSet<Complaint_ComplaintDepartament>();
        }

        [Display(Name = "Id")]
        public System.Guid ComplaintDepartamentID { get; set; }
        [Display(Name = "Departamento")]
        public string ComplaintDepartamentDescription { get; set; }
        [Display(Name = "Estado")]
        public bool ComplaintDepartamentIsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Complaint_ComplaintDepartament> Complaint_ComplaintDepartament { get; set; }
    }
}