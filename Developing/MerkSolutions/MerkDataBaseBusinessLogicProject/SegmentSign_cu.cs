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
    
    public partial class SegmentSign_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SegmentSign_cu()
        {
            this.VisitTiming_AdnexaSegmentSign = new HashSet<VisitTiming_AdnexaSegmentSign>();
            this.VisitTiming_AnteriorSegmentSign = new HashSet<VisitTiming_AnteriorSegmentSign>();
            this.VisitTiming_EOMSign = new HashSet<VisitTiming_EOMSign>();
            this.VisitTiming_PosteriorSegmentSign = new HashSet<VisitTiming_PosteriorSegmentSign>();
        }
    
        public int ID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public int SegmentCategory_CU_ID { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual SegmentSignCategory_cu SegmentSignCategory_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_AdnexaSegmentSign> VisitTiming_AdnexaSegmentSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_AnteriorSegmentSign> VisitTiming_AnteriorSegmentSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_EOMSign> VisitTiming_EOMSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_PosteriorSegmentSign> VisitTiming_PosteriorSegmentSign { get; set; }
    }
}