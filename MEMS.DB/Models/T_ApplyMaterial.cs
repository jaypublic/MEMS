using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_ApplyMaterial
    {
        public string MatCode { get; set; }
        public string MatDesc { get; set; }
        public string MatTypeCode { get; set; }
        public string MatModeCode { get; set; }
        public string Unit { get; set; }
        public string Id { get; set; }
        public string ApplyUseNo { get; set; }
        public Nullable<decimal> ApplyQuantity { get; set; }
        public string Remark { get; set; }
        public Nullable<decimal> AvailableQuantity { get; set; }
    }
}
