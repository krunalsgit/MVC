//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            this.TreatmentDetails = new HashSet<TreatmentDetail>();
        }
    
        public int id { get; set; }
        public string MedicineName { get; set; }
        public Nullable<int> DignosisId { get; set; }
    
        public virtual Diagnosi Diagnosi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentDetail> TreatmentDetails { get; set; }
    }
}
