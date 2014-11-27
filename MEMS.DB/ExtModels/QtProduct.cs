using MEMS.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEMS.DB.ExtModels
{
    public class QtProduct
    {
        public T_quotationprice qp { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string productSpec { get; set; }
    }
}