using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_ProductbasicPrice
    {
        public int id { get; set; }
        public Nullable<int> productid { get; set; }
        public string version { get; set; }
        public Nullable<decimal> returnmatprice { get; set; }
        public string returnpricedesc { get; set; }
        public Nullable<decimal> materialprice { get; set; }
        public string materialpricedesc { get; set; }
        public Nullable<decimal> manageprice { get; set; }
        public string mgrpricedesc { get; set; }
        public Nullable<decimal> otherprice { get; set; }
        public string otherpricedesc { get; set; }
        public Nullable<decimal> totalprice { get; set; }
        public string pricebasicremark { get; set; }
    }
}
