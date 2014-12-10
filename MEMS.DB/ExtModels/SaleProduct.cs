using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MEMS.DB.Models;

namespace MEMS.DB.ExtModels
{
    public class SaleProduct
    {
        public T_saledetail sd { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string productSpec { get; set; }
        public decimal? pUnitPrice { get; set; }
        public decimal? pModelPrice { get; set; }
    }
}
