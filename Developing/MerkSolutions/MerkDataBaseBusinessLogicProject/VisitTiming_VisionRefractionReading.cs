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
    
    public partial class VisitTiming_VisionRefractionReading
    {
        public int ID { get; set; }
        public int VisitTimingID { get; set; }
        public int VisionRefractionReadingType_P_ID { get; set; }
        public System.DateTime TakenDateTime { get; set; }
        public Nullable<int> UVA_OU { get; set; }
        public Nullable<int> NVA_OU { get; set; }
        public Nullable<double> NVAAmount_OU { get; set; }
        public Nullable<double> Distance_OD { get; set; }
        public Nullable<int> NVA_OD { get; set; }
        public Nullable<double> NVAAmount_OD { get; set; }
        public Nullable<double> Sph_OD { get; set; }
        public Nullable<double> Cyl_OD { get; set; }
        public Nullable<double> Axis_OD { get; set; }
        public Nullable<int> UVA_OD { get; set; }
        public Nullable<double> Add_OD { get; set; }
        public string Remarks_OD { get; set; }
        public Nullable<bool> IsError_OD { get; set; }
        public Nullable<bool> IsIgnored_OD { get; set; }
        public Nullable<int> Rating_OD { get; set; }
        public Nullable<double> Distance_OS { get; set; }
        public Nullable<int> NVA_OS { get; set; }
        public Nullable<double> NVAAmount_OS { get; set; }
        public Nullable<double> Sph_OS { get; set; }
        public Nullable<double> Cyl_OS { get; set; }
        public Nullable<double> Axis_OS { get; set; }
        public Nullable<int> UVA_OS { get; set; }
        public Nullable<double> Add_OS { get; set; }
        public string Remarks_OS { get; set; }
        public Nullable<bool> IsError_OS { get; set; }
        public Nullable<bool> IsIgnored_OS { get; set; }
        public Nullable<int> Rating_OS { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual NearVisiong_p NearVisiong_p { get; set; }
        public virtual NearVisiong_p NearVisiong_p1 { get; set; }
        public virtual NearVisiong_p NearVisiong_p2 { get; set; }
        public virtual UncorrectedDistanceVisualAcuity_cu UncorrectedDistanceVisualAcuity_cu { get; set; }
        public virtual UncorrectedDistanceVisualAcuity_cu UncorrectedDistanceVisualAcuity_cu1 { get; set; }
        public virtual UncorrectedDistanceVisualAcuity_cu UncorrectedDistanceVisualAcuity_cu2 { get; set; }
        public virtual User_cu User_cu { get; set; }
        public virtual VisionRefractionReadingType_p VisionRefractionReadingType_p { get; set; }
        public virtual VisitTiming VisitTiming { get; set; }
    }
}
