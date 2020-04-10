using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipEngPro
    {
        public long EngPrjId { get; set; }
        public int? ParEngPrjId { get; set; }
        public string PrjCode { get; set; }
        public string PrjName { get; set; }
        public DateTime? PrjBeginTime { get; set; }
        public DateTime? PrjEndTime { get; set; }
        public string EngNote { get; set; }
        public int? EngPrjLev { get; set; }
        public string VolVal { get; set; }
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
