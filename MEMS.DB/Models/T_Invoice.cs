using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_Invoice
    {
        public string Id { get; set; }
        public string InvoiceNo { get; set; }
        public string PONo { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public string Oper { get; set; }
        public string OperDesc { get; set; }
        public string Attachment { get; set; }
        public string Remark { get; set; }
        public string Register { get; set; }
        public string RegisterDesc { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
    }
}
