using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_Suppliers_contacts
    {
        public int id { get; set; }
        public Nullable<int> supplierid { get; set; }
        public string contactname { get; set; }
        public string sex { get; set; }
        public string position { get; set; }
        public string cellphone { get; set; }
        public string telphone { get; set; }
        public string email { get; set; }
        public string qq { get; set; }
        public string fax { get; set; }
        public string remarks { get; set; }
        public Nullable<int> createuid { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
    }
}
