using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_FileMgr
    {
        public int id { get; set; }
        public string filename { get; set; }
        public string filecode { get; set; }
        public string filepath { get; set; }
        public string filetype { get; set; }
    }
}
