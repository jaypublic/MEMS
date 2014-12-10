using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_ProductDraw
    {
        public int id { get; set; }
        public int pid { get; set; }
        public string drawingno { get; set; }
        public string filepath { get; set; }
        public string remark { get; set; }
        public Nullable<bool> isdelete { get; set; }
    }
}
