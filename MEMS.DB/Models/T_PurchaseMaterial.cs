using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_PurchaseMaterial
    {
        public string MatCode { get; set; }
        public string MatDesc { get; set; }
        public string MatTypeCode { get; set; }
        public string MatModeCode { get; set; }
        public string Unit { get; set; }
        public string Id { get; set; }
        public string PONo { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Quantity { get; set; }
    }
}
