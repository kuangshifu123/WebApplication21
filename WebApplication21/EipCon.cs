using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipCon
    {
        public long ConId { get; set; }
        public string ConCode { get; set; }
        public string ConLawCode { get; set; }
        public string SerialNumber { get; set; }
        public string ConName { get; set; }
        public decimal? TaxAmt { get; set; }
        public DateTime? BuyerSignTime { get; set; }
        public DateTime? SellerSignTime { get; set; }
        public DateTime? ConValidTime { get; set; }
        public int? Warr { get; set; }
        public DateTime? ConTransTime { get; set; }
        public int? FrzFlag { get; set; }
        public int? ESignStatus { get; set; }
        public int? ConDlvErp { get; set; }
        public int? DelayFlag { get; set; }
        public DateTime? DelayEndTime { get; set; }
        public string DemandOrgName { get; set; }
        public string BuyerId { get; set; }
        public string BuyerName { get; set; }
        public string PurchaseId { get; set; }
        public string PurchaseName { get; set; }
        public string ErpAgreementCode { get; set; }
        public string SellerConCode { get; set; }
        public string ValidCond { get; set; }
        public int? CancelFlag { get; set; }
        public int? ConStatus { get; set; }
        public int? ConType { get; set; }
        public string SuppOrgId { get; set; }
        public string PrjCode { get; set; }
        public string PrjName { get; set; }
        public string EngCode { get; set; }
        public string EngName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string DataSource { get; set; }
        public DateTime? DataSourceCreatetime { get; set; }
        public string Remark { get; set; }
        public bool? IsDeleted { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string OwnerId { get; set; }
        public string OpenId { get; set; }
    }
}
