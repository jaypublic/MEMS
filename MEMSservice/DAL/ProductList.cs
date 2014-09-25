using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEMSservice.DAL
{
    public class ProductList
    {
        public int id { get; set; }
        public int customerid { get; set; }
        public string procode { get; set; }
        public string proname { get; set; }
        public string drawingno { get; set; }
        public string customername { get; set; }
    }
}