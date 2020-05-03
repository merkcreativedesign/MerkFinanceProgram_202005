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
    
    public partial class Supplier_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier_cu()
        {
            this.FinanceInvoices = new HashSet<FinanceInvoice>();
            this.InventoryItemPrice_cu = new HashSet<InventoryItemPrice_cu>();
        }
    
        public int Person_CU_ID { get; set; }
        public Nullable<int> SupplierType_P_ID { get; set; }
        public Nullable<int> InsertedBy { get; set; }
        public string InternalCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinanceInvoice> FinanceInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryItemPrice_cu> InventoryItemPrice_cu { get; set; }
        public virtual Person_cu Person_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
        public virtual SupplierType_p SupplierType_p { get; set; }
    }
}
