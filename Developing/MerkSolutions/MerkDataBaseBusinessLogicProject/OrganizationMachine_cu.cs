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
    
    public partial class OrganizationMachine_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationMachine_cu()
        {
            this.OrganizationMachine_CashBox_cu = new HashSet<OrganizationMachine_CashBox_cu>();
            this.OrganizationMachine_StationPoint_cu = new HashSet<OrganizationMachine_StationPoint_cu>();
        }
    
        public int ID { get; set; }
        public string Name_P { get; set; }
        public int OrganizationID { get; set; }
        public string SkinName { get; set; }
        public string Color { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual Organization_p Organization_p { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationMachine_CashBox_cu> OrganizationMachine_CashBox_cu { get; set; }
        public virtual User_UserGroup_cu User_UserGroup_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationMachine_StationPoint_cu> OrganizationMachine_StationPoint_cu { get; set; }
    }
}
