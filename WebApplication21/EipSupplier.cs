using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipSupplier
    {
        public long SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupperAddr { get; set; }
        public string SupperContacts { get; set; }
        public string SupplierScc { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierOrgCode { get; set; }
        public string SupplierMail { get; set; }
        public string SupplierFax { get; set; }
        public string DataSource { get; set; }
        public DateTime? DataSourceCreatetime { get; set; }
        public string Remark { get; set; }
        public sbyte? IsDeleted { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string OwnerId { get; set; }
        public int? QueryTimes { get; set; }
        public string OpenId { get; set; }
    }
}
