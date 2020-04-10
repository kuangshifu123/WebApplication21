using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipProcessReport
    {
        public long ProcessReportId { get; set; }
        public string PurchaserHqCode { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public long? SupplierIpoId { get; set; }
        public string IpoNo { get; set; }
        public string DeviceNo { get; set; }
        public string CategoryCode { get; set; }
        public string SubclassCode { get; set; }
        public string ProductBatchNo { get; set; }
        public string ProcessName { get; set; }
        public string ProcessCode { get; set; }
        public string InsideNo { get; set; }
        public string ProcessNo { get; set; }
        public int? WorkshopId { get; set; }
        public string WorkshopCode { get; set; }
        public string WorkshopName { get; set; }
        public string WoNo { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualFinishDate { get; set; }
        public string EntityId { get; set; }
        public int? OrderStatus { get; set; }
        public string BuyerProvince { get; set; }
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
