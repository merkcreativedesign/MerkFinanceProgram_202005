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
    
    public partial class InPatientRoomClassification_InPatientAdmissionPricingType_cu
    {
        public int ID { get; set; }
        public int InPatientRoomClassification_CU_ID { get; set; }
        public int InPatientAddmissionPricingType_P_ID { get; set; }
        public double PricePerDay { get; set; }
        public Nullable<double> MinimumAddmissionAmount { get; set; }
        public Nullable<int> InsuranceCarrier_InsuranceLevel_CU_ID { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual InPatientAdmissionPricingType_p InPatientAdmissionPricingType_p { get; set; }
        public virtual InPatientRoomClassification_cu InPatientRoomClassification_cu { get; set; }
        public virtual InsuranceCarrier_InsuranceLevel_cu InsuranceCarrier_InsuranceLevel_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}
