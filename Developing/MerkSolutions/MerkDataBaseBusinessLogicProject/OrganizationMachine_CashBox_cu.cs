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
    
    public partial class OrganizationMachine_CashBox_cu
    {
        public int ID { get; set; }
        public int OrganizationMachine_CU_ID { get; set; }
        public int CashBox_CU_ID { get; set; }
        public bool IsOnDuty { get; set; }
        public int InsertedBy { get; set; }
    
        public virtual CashBox_cu CashBox_cu { get; set; }
        public virtual OrganizationMachine_cu OrganizationMachine_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}