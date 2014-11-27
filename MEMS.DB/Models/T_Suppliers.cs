using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_Suppliers
    {
        public int id { get; set; }
        public string supplierno { get; set; }
        public string suppliername { get; set; }
        public string simplename { get; set; }
        public string suppliertype { get; set; }
        public string telphone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string bank { get; set; }
        public string accountname { get; set; }
        public string accountno { get; set; }
        public string taxcode { get; set; }
        public string legalperson { get; set; }
        public string businessscope { get; set; }
        public string remarks { get; set; }
        public Nullable<int> createuid { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
    }
}
