using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_CraftsPrice
    {
        public int id { get; set; }
        public Nullable<int> pricebasicid { get; set; }
        public Nullable<int> pid { get; set; }
        public Nullable<int> processid { get; set; }
        public string processname { get; set; }
        public Nullable<int> processidx { get; set; }
        public Nullable<decimal> processprice { get; set; }
    }
}
