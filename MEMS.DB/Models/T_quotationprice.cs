using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_quotationprice
    {
        public int id { get; set; }
        public int quotationid { get; set; }
        public int productid { get; set; }
        public int productcount { get; set; }
        public Nullable<decimal> modelprice { get; set; }
        public Nullable<decimal> totalprice { get; set; }
        public Nullable<decimal> unitprice { get; set; }
    }
}
