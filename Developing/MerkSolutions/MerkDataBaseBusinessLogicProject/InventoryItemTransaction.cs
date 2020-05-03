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
    
    public partial class InventoryItemTransaction
    {
        public int ID { get; set; }
        public int InventoryItem_CU_ID { get; set; }
        public int InventoryHousing_CU_ID { get; set; }
        public double Quantity { get; set; }
        public int TransactionFactor { get; set; }
        public int UnitMeasurment_CU_ID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> InventoryItemTransactionType_P_ID { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual InventoryHousing_cu InventoryHousing_cu { get; set; }
        public virtual InventoryItem_cu InventoryItem_cu { get; set; }
        public virtual UnitMeasurment_cu UnitMeasurment_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
        public virtual InventoryItemTransactionType_p InventoryItemTransactionType_p { get; set; }
    }
}
