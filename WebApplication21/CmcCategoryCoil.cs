using System;
using System.Collections.Generic;

namespace WebApplication21
{
    public partial class CmcCategoryCoil
    {
        public long Id { get; set; }
        public string CategoryCoilCode { get; set; }
        public string CategoryCoilName { get; set; }
        public int CategoryCode { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
    }
}
