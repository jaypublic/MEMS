using MEMS.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEMS.DB.ExtModels
{
    public class SaleOrder
    {
        public T_saleorder so { get; set; }
        public string qtno { get; set; }
        public string customername { set; get; }
    }
}