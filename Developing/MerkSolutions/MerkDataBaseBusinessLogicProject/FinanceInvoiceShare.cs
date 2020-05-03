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
    
    public partial class FinanceInvoiceShare
    {
        public int FinanceInvoiceID { get; set; }
        public Nullable<double> TotalRequestedAmount { get; set; }
        public double TotalPayment { get; set; }
        public bool IsSurchargeApplied { get; set; }
        public Nullable<double> TotalSurchargeAccummulativePercentage { get; set; }
        public bool IsStampApplied { get; set; }
        public Nullable<double> TotalStampAmount { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        public virtual FinanceInvoice FinanceInvoice { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}
