using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_saleorder
    {
        public int id { get; set; }
        public string saleno { get; set; }
        public System.DateTime saledate { get; set; }
        public int receiveperiodtype { get; set; }
        public Nullable<int> receiveperiod { get; set; }
        public int customerid { get; set; }
        public int quotationid { get; set; }
        public int receivetype { get; set; }
        public int receivestate { get; set; }
        public int orderstate { get; set; }
        public Nullable<decimal> saletotalamount { get; set; }
        public Nullable<decimal> receiveamount { get; set; }
        public string receiveratio { get; set; }
        public string remarks { get; set; }
    }
}
