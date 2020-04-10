using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipSupplierSoLineitem
    {
        public long SupplierSoItemId { get; set; }
        public string PurchaserHqCode { get; set; }
        public long? SupplierSoId { get; set; }
        public string SoNo { get; set; }
        public string SoItemNo { get; set; }
        public string CategoryCode { get; set; }
        public string SubclassCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductUnit { get; set; }
        public string ProductAmount { get; set; }
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
