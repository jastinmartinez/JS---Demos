//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CXCConsultant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Credit
    {
        public int CreditID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime CreditCutOffDay { get; set; }
        public decimal CreditBalanceAverage { get; set; }
        public decimal CreditAmount { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
