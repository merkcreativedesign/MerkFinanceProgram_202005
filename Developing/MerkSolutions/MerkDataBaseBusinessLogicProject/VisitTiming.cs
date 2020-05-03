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
    
    public partial class VisitTiming
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VisitTiming()
        {
            this.VisitTiming_Attachment = new HashSet<VisitTiming_Attachment>();
            this.VisitTiming_EOMReading = new HashSet<VisitTiming_EOMReading>();
            this.VisitTiming_InvestigationReservation = new HashSet<VisitTiming_InvestigationReservation>();
            this.VisitTiming_LabReservation = new HashSet<VisitTiming_LabReservation>();
            this.VisitTiming_MainAdnexaSegmentSign = new HashSet<VisitTiming_MainAdnexaSegmentSign>();
            this.VisitTiming_MainAnteriorSegmentSign = new HashSet<VisitTiming_MainAnteriorSegmentSign>();
            this.VisitTiming_MainDiagnosis = new HashSet<VisitTiming_MainDiagnosis>();
            this.VisitTiming_MainEOMSign = new HashSet<VisitTiming_MainEOMSign>();
            this.VisitTiming_MainPosteriorSegmentSign = new HashSet<VisitTiming_MainPosteriorSegmentSign>();
            this.VisitTiming_MainSymptoms = new HashSet<VisitTiming_MainSymptoms>();
            this.VisitTiming_MedicalHistory = new HashSet<VisitTiming_MedicalHistory>();
            this.VisitTiming_Medication = new HashSet<VisitTiming_Medication>();
            this.VisitTiming_Pupillary = new HashSet<VisitTiming_Pupillary>();
            this.VisitTiming_SurgeryReservation = new HashSet<VisitTiming_SurgeryReservation>();
            this.VisitTiming_TreatmentPlan = new HashSet<VisitTiming_TreatmentPlan>();
            this.VisitTiming_VisionRefractionReading = new HashSet<VisitTiming_VisionRefractionReading>();
            this.VisitTiming_VitalSign = new HashSet<VisitTiming_VitalSign>();
            this.VisitTiming_SocialHistory = new HashSet<VisitTiming_SocialHistory>();
        }
    
        public int ID { get; set; }
        public int InvoiceDetailID { get; set; }
        public int StationPoint_CU_ID { get; set; }
        public Nullable<int> StationPointStage_CU_ID { get; set; }
        public int Doctor_CU_ID { get; set; }
        public System.DateTime SignInDateTime { get; set; }
        public Nullable<System.DateTime> SignOutDateTime { get; set; }
        public bool IsOnDuty { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual Doctor_cu Doctor_cu { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }
        public virtual StationPoint_cu StationPoint_cu { get; set; }
        public virtual StationPointStage_cu StationPointStage_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_Attachment> VisitTiming_Attachment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_EOMReading> VisitTiming_EOMReading { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_InvestigationReservation> VisitTiming_InvestigationReservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_LabReservation> VisitTiming_LabReservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_MainAdnexaSegmentSign> VisitTiming_MainAdnexaSegmentSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_MainAnteriorSegmentSign> VisitTiming_MainAnteriorSegmentSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_MainDiagnosis> VisitTiming_MainDiagnosis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_MainEOMSign> VisitTiming_MainEOMSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_MainPosteriorSegmentSign> VisitTiming_MainPosteriorSegmentSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_MainSymptoms> VisitTiming_MainSymptoms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_MedicalHistory> VisitTiming_MedicalHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_Medication> VisitTiming_Medication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_Pupillary> VisitTiming_Pupillary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_SurgeryReservation> VisitTiming_SurgeryReservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_TreatmentPlan> VisitTiming_TreatmentPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_VisionRefractionReading> VisitTiming_VisionRefractionReading { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_VitalSign> VisitTiming_VitalSign { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitTiming_SocialHistory> VisitTiming_SocialHistory { get; set; }
    }
}
