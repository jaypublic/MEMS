using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_ProductType
    {
        public int id { get; set; }
        public string typecode { get; set; }
        public string typename { get; set; }
        public string typedesc { get; set; }
        public Nullable<int> fid { get; set; }
    }
}
