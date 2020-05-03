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
    
    public partial class StationPointStage_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StationPointStage_cu()
        {
            this.Doctor_StationPointStage_cu = new HashSet<Doctor_StationPointStage_cu>();
            this.QueueManagers = new HashSet<QueueManager>();
            this.Service_StationPointStage_cu = new HashSet<Service_StationPointStage_cu>();
            this.ServiceCategory_StationPointStage_cu = new HashSet<ServiceCategory_StationPointStage_cu>();
            this.ServiceType_StationPointStage_cu = new HashSet<ServiceType_StationPointStage_cu>();
            this.VisitTimings = new HashSet<VisitTiming>();
        }
    
        public int ID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public int StationPoint_CU_ID { get; set; }
        public Nullable<int> Floor_CU_ID { get; set; }
        public Nullable<int> ServingApplication_P_ID { get; set; }
        public Nullable<int> OrderIndex { get; set; }
        public bool IsOnDuty { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual Application_p Application_p { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor_StationPointStage_cu> Doctor_StationPointStage_cu { get; set; }
        public virtual Floor_cu Floor_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueueManager> QueueManagers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service_StationPointStage_cu> Service_StationPointStage_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceCategory_StationPointStage_cu> ServiceCategory_StationPointStage_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceType_StationPointStage_cu> ServiceType_StationPointStage_cu { get; set; }
        public virtual StationPoint_cu StationPoint_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming> VisitTimings { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}
