using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipEntity
    {
        public long EipEntityId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string EntityCode { get; set; }
        public long? PoItemId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
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
