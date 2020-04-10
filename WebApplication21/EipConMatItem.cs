using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipConMatItem
    {
        public long ConMatItemId { get; set; }
        public string ConItemCode { get; set; }
        public long? ConId { get; set; }
        public string MatCat { get; set; }
        public string MatName { get; set; }
        public decimal? UntaxUnitPrice { get; set; }
        public int? Qty { get; set; }
        public string MeasUnitType { get; set; }
        public decimal? UntaxTotPrice { get; set; }
        public string TaxRate { get; set; }
        public DateTime? DlvTime { get; set; }
        public string DlvAddr { get; set; }
        public string MatDes { get; set; }
        public long? PoId { get; set; }
        public long? PoItemId { get; set; }
        public string PurchaseNo { get; set; }
        public string PoNo { get; set; }
        public string DemandOrgName { get; set; }
        public long? EngPrjId { get; set; }
        public string MatCode { get; set; }
        public long? MatCodeId { get; set; }
        public decimal? TaxUnitPrice { get; set; }
        public decimal? TaxTotPrice { get; set; }
        public string DemandOrgCode { get; set; }
        public string MatMaxCode { get; set; }
        public string MatMedCode { get; set; }
        public string MatMinCode { get; set; }
        public string MatMaxName { get; set; }
        public string MatMedName { get; set; }
        public string MatMinName { get; set; }
        public string EngName { get; set; }
        public DateTime? ConDlvTime { get; set; }
        public DateTime? CfmDlvTime { get; set; }
        public DateTime? RealDlvTime { get; set; }
        public int? DepositMat { get; set; }
        public string PrjCode { get; set; }
        public string PrjName { get; set; }
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
    }
}
