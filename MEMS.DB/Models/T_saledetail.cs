using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_saledetail
    {
        public int id { get; set; }
        public int soid { get; set; }
        public int productid { get; set; }
        public Nullable<int> productnumber { get; set; }
        public Nullable<System.DateTime> plandeliverydate { get; set; }
        public Nullable<decimal> producttotalprice { get; set; }
        public Nullable<System.DateTime> actualdeliverydate { get; set; }
        public Nullable<System.DateTime> planreceivedate { get; set; }
        public Nullable<System.DateTime> actrualreceivedate { get; set; }
        public Nullable<int> receivestate { get; set; }
        public Nullable<decimal> receiveamount { get; set; }
    }
}
