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
    
    public partial class QueueManager
    {
        public int ID { get; set; }
        public int StationPoint_CU_ID { get; set; }
        public Nullable<int> StationPointStage_CU_ID { get; set; }
        public Nullable<int> Service_CU_ID { get; set; }
        public Nullable<int> Patient_CU_ID { get; set; }
        public int Doctor_CU_ID { get; set; }
        public Nullable<System.DateTime> AssignedName { get; set; }
        public int InvoiceDetailID { get; set; }
        public int QueueManagerStatus_P_ID { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual Doctor_cu Doctor_cu { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }
        public virtual Patient_cu Patient_cu { get; set; }
        public virtual QueueManagerStatus_p QueueManagerStatus_p { get; set; }
        public virtual Service_cu Service_cu { get; set; }
        public virtual StationPoint_cu StationPoint_cu { get; set; }
        public virtual StationPointStage_cu StationPointStage_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}