//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrdoWeb.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_trn_Payment
    {
        public long InvoicePaymentId { get; set; }
        public string Unique_Id { get; set; }
        public string Paymode { get; set; }
        public string Paymode1 { get; set; }
        public string BRN { get; set; }
        public string RID { get; set; }
        public string CRN { get; set; }
        public string InvoiceNo { get; set; }
        public string PGStatus { get; set; }
        public string PGStatus1 { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string ClientIPAdd { get; set; }
        public Nullable<decimal> AmountCredited { get; set; }
        public string CurrencyDue { get; set; }
        public Nullable<decimal> ConvChrges { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> EquivINR { get; set; }
        public Nullable<decimal> USDRate { get; set; }
        public string EnteredBY { get; set; }
        public string VerifiedByAc { get; set; }
        public Nullable<System.DateTime> RecTimeStamp { get; set; }
        public string BankType { get; set; }
        public string IsPaymentApplied { get; set; }
    }
}
