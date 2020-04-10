using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipProductionSchedule
    {
        public long ProductionScheduleId { get; set; }
        public string PurchaserHqCode { get; set; }
        public string ScheduleCode { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public long PoItemId { get; set; }
        public long? SupplierSoItemId { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualFinishDate { get; set; }
        public string MaterialCode { get; set; }
        public string ScheduleAmount { get; set; }
        public string MaterialDesc { get; set; }
        public string PlanPeriod { get; set; }
        public string Schedule { get; set; }
        public DateTime? DueDate { get; set; }
        public string ActualPeriod { get; set; }
        public string CategoryCode { get; set; }
        public string SubclassCode { get; set; }
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
