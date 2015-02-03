using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_CodeType
    {
        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Code { get; set; }
        public string CodeDesc { get; set; }
    }
}
