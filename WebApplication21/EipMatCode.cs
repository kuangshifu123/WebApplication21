using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipMatCode
    {
        public long MatCodeId { get; set; }
        public string MatCode { get; set; }
        public string MatDes { get; set; }
        public int? MatStatus { get; set; }
        public string MatCodeDetDes { get; set; }
        public long? MatMinCatId { get; set; }
        public long? CategoryCoilId { get; set; }
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
