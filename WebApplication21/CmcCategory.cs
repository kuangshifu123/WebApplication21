using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class CmcCategory
    {
        public long Id { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
    }
}
