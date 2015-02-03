using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_ApplyOrder
    {
        public string ApplyUseNo { get; set; }
        public string Dept { get; set; }
        public string DeptDesc { get; set; }
        public string ApplyUseDate { get; set; }
        public Nullable<short> ApplyUseType { get; set; }
        public string ApplyUser { get; set; }
        public string ApplyUserDesc { get; set; }
        public string SaleNo { get; set; }
        public string ProductOrderNo { get; set; }
        public Nullable<short> ApplyUseStatus { get; set; }
        public string Applicant { get; set; }
        public string ApplicantDesc { get; set; }
        public string Register { get; set; }
        public string RegisterDesc { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
    }
}
