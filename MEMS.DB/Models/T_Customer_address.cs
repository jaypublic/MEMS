using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_Customer_address
    {
        public int id { get; set; }
        public Nullable<int> customerid { get; set; }
        public string addressname { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public Nullable<int> createuid { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
    }
}
