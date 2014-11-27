using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_Customer
    {
        public int id { get; set; }
        public string customerno { get; set; }
        public string customername { get; set; }
        public string simplename { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string companyaddress { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string postcode { get; set; }
        public string source { get; set; }
        public string customertype { get; set; }
        public string profession { get; set; }
        public string companytype { get; set; }
        public string productinfo { get; set; }
        public string customerdesc { get; set; }
        public string remarks { get; set; }
        public string bank { get; set; }
        public string accountname { get; set; }
        public string accountno { get; set; }
        public string taxcode { get; set; }
        public string invoiceaddress { get; set; }
        public Nullable<int> createuid { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
    }
}
