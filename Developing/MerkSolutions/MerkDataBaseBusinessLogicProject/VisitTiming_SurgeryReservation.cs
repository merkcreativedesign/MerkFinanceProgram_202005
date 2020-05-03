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
    
    public partial class VisitTiming_SurgeryReservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisitTiming_SurgeryReservation()
        {
            this.VisitTiming_SurgeryResult = new HashSet<VisitTiming_SurgeryResult>();
        }
    
        public int ID { get; set; }
        public int VisitTimingID { get; set; }
        public int Service_CU_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
        public string Description { get; set; }
    
        public virtual Service_cu Service_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
        public virtual VisitTiming VisitTiming { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_SurgeryResult> VisitTiming_SurgeryResult { get; set; }
    }
}
