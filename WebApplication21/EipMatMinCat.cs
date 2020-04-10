using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class EipMatMinCat
    {
        public long MatMinCatId { get; set; }
        public string MinCatCode { get; set; }
        public string MinCatName { get; set; }
        public int? MatMinCatStatus { get; set; }
        public long? MatMedCatId { get; set; }
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
