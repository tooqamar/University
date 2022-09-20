//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lib.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAcctGeneralSI_HD
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string RefNo { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string CustomerAccountNo { get; set; }
        public string CustomerName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactPerson { get; set; }
        public string ValidFor { get; set; }
        public string Remarks { get; set; }
        public decimal GrossTotal { get; set; }
        public int Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }
        public string SalesMane { get; set; }
        public string StoreName { get; set; }
        public bool isVoided { get; set; }
        public bool isDeleted { get; set; }
        public string EntryUserId { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public bool isPosted { get; set; }
        public bool isApproved { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public string QuoteCode { get; set; }
        public string SalesType { get; set; }
        public Nullable<decimal> CashPaid { get; set; }
        public Nullable<decimal> BankPaid { get; set; }
        public string CardSwap { get; set; }
        public string BankAuthorizationNo { get; set; }
        public string PaymentMethod { get; set; }
        public string CustNTN { get; set; }
        public string CustCNIC { get; set; }
        public string FBRINVOICE { get; set; }
    }
}
