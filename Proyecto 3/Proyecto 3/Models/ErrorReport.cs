//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorReport
    {
        public int ErrorID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> SaleID { get; set; }
        public string ProductName { get; set; }
        public Nullable<System.DateTime> ErrorDate { get; set; }
        public string ContactMail { get; set; }
        public string ErrorDescription { get; set; }
    
        public virtual Sale Sale { get; set; }
        public virtual User User { get; set; }
    }
}