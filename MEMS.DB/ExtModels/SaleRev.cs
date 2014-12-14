using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MEMS.DB.Models;

namespace MEMS.DB.ExtModels
{
    public class SaleRev
    {
        public T_SaleReceive sr { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
    }
}
