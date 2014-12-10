using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_quotation
    {
        public int id { get; set; }
        public string qutationno { get; set; }
        public string theme { get; set; }
        public Nullable<decimal> quotationprice { get; set; }
        public Nullable<int> customerid { get; set; }
        public Nullable<System.DateTime> quotationdate { get; set; }
        public string productremark { get; set; }
        public string quremark { get; set; }
        public Nullable<int> quotationperson { get; set; }
        public string quotationtxt { get; set; }
    }
}
