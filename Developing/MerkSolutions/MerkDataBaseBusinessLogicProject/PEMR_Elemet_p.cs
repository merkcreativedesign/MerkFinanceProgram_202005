//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerkDataBaseBusinessLogicProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEMR_Elemet_p
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PEMR_Elemet_p()
        {
            this.PEM_ElementPrintOrder_cu = new HashSet<PEM_ElementPrintOrder_cu>();
            this.PEMR_Elemet_p1 = new HashSet<PEMR_Elemet_p>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public bool IsHead { get; set; }
        public int DefaultOrderIndex { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEM_ElementPrintOrder_cu> PEM_ElementPrintOrder_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEMR_Elemet_p> PEMR_Elemet_p1 { get; set; }
        public virtual PEMR_Elemet_p PEMR_Elemet_p2 { get; set; }
    }
}
