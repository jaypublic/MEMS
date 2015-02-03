using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_StockCode
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Code { get; set; }
        public string Stockdesc { get; set; }
    }
}
