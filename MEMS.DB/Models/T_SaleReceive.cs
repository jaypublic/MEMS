using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_SaleReceive
    {
        public int id { get; set; }
        public int soid { get; set; }
        public Nullable<decimal> revamount { get; set; }
        public Nullable<System.DateTime> revdate { get; set; }
        public int revmanid { get; set; }
        public string invoicecode { get; set; }
        public string remarks { get; set; }
    }
}
