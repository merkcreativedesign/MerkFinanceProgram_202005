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
    
    public partial class CashBox_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashBox_cu()
        {
            this.CashBoxInOutTransactions = new HashSet<CashBoxInOutTransaction>();
            this.OrganizationMachine_CashBox_cu = new HashSet<OrganizationMachine_CashBox_cu>();
        }
    
        public int ID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public string InternalCode { get; set; }
        public bool IsMain { get; set; }
        public Nullable<int> Floor_CU_ID { get; set; }
        public Nullable<int> ChartOfAccount_CU_ID { get; set; }
        public string Description { get; set; }
        public bool IsOnDuty { get; set; }
        public int InsertedBy { get; set; }
    
        public virtual ChartOfAccount_cu ChartOfAccount_cu { get; set; }
        public virtual Floor_cu Floor_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashBoxInOutTransaction> CashBoxInOutTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationMachine_CashBox_cu> OrganizationMachine_CashBox_cu { get; set; }
    }
}
