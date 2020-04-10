using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipSupplierWo
    {
        public long SupplierWoId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string WoNo { get; set; }
        public string IpoNo { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string CategoryCode { get; set; }
        public string SubclassCode { get; set; }
        public string MaterialsCode { get; set; }
        public string MaterialsDesc { get; set; }
        public string MaterialsBatch { get; set; }
        public string Amount { get; set; }
        public string Unit { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualFinishDate { get; set; }
        public int? WoStatus { get; set; }
        public string ProcessRouteNo { get; set; }
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
