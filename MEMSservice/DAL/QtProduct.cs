using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEMSservice.DAL
{
    public class QtProduct
    {
        public QtProduct()
        {
            qp = new T_quotationprice();
        }

        public T_quotationprice qp { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string productSpec { get; set; }
    }
}