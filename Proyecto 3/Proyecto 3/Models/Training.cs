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
    
    public partial class Training
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Training()
        {
            this.UserXTrainings = new HashSet<UserXTraining>();
        }
    
        public int TrainingID { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public System.DateTime StartDate { get; set; }
        public string MaximumQuota { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserXTraining> UserXTrainings { get; set; }
    }
}
