using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipPoItem
    {
        public long PoItemId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string PoItemNo { get; set; }
        public long? PoId { get; set; }
        public string PurchaseNo { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string MaterialCode { get; set; }
        public string MatName { get; set; }
        public int? MatQty { get; set; }
        public string CategoryCode { get; set; }
        public string SubclassCode { get; set; }
        public string MeasUnit { get; set; }
        public DateTime? DlvTime { get; set; }
        public string DlvAddr { get; set; }
        public int? OrdStatus { get; set; }
        public string PrjCode { get; set; }
        public string PrjName { get; set; }
        public int? AutoMatchFlag { get; set; }
        public string DemandOrg { get; set; }
        public string PurchaseId { get; set; }
        public string PurchaseName { get; set; }
        public string DataSource { get; set; }
        public DateTime? DataSourceCreatetime { get; set; }
        public string Remark { get; set; }
        public sbyte? IsDeleted { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string OwnerId { get; set; }
        public string OpenId { get; set; }
    }
}
