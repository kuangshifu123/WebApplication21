using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipSupplierSo
    {
        public long SupplierSoId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string SoNo { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string BuyerCode { get; set; }
        public string BuyerName { get; set; }
        public string BuyerProvince { get; set; }
        public string CategoryCode { get; set; }
        public int? SoStatus { get; set; }
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
