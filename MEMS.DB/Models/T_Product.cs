using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_Product
    {
        public int id { get; set; }
        public Nullable<int> customerid { get; set; }
        public Nullable<int> protype { get; set; }
        public string procode { get; set; }
        public string proname { get; set; }
        public string prounit { get; set; }
        public string prospecification { get; set; }
        public Nullable<double> pronetweight { get; set; }
        public Nullable<double> progrossweight { get; set; }
    }
}
