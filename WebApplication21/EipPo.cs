using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipPo
    {
        public long PoId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string PoNo { get; set; }
        public long? ConId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string PurchaseId { get; set; }
        public string PurchaseCode { get; set; }
        public string PurchaseName { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public long? SupplierId { get; set; }
        public int? PurchaseType { get; set; }
        public int? PoStatus { get; set; }
        public string ErpAgreementCode { get; set; }
        public string DataSource { get; set; }
        public DateTime? DataSourceCreatetime { get; set; }
        public DateTime? SigningDate { get; set; }
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
