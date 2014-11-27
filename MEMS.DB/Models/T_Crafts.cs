using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_Crafts
    {
        public int id { get; set; }
        public Nullable<int> pid { get; set; }
        public Nullable<int> processindex { get; set; }
        public string processname { get; set; }
        public string remarks { get; set; }
    }
}
