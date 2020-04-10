using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipMatInventory
    {
        public long MatInventoryId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string MatName { get; set; }
        public double? MatNum { get; set; }
        public DateTime? PurchasingPeriod { get; set; }
        public double? PurchasingAmount { get; set; }
        public double? QuantityRequired { get; set; }
        public long? PoItemId { get; set; }
        public string CategoryCode { get; set; }
        public string SubclassCode { get; set; }
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
        public string MatUnit { get; set; }
        public string MatCode { get; set; }
    }
}
