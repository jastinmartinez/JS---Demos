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

    public partial class ComplaintStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComplaintStatu()
        {
            this.Complaints = new HashSet<Complaint>();
        }

        [Display(Name = "Id")]
        public System.Guid ComplaintStatusID { get; set; }
        [Display(Name = "Estado Q&R")]
        public string ComplaintStatusDescription { get; set; }
        [Display(Name = "Estado")]
        public Nullable<bool> ComplaintStatusIsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Complaint> Complaints { get; set; }
    }
}
