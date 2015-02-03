using System;
using System.Collections.Generic;

namespace MEMS.DB.Models
{
    public partial class T_PurchaseOrder
    {
        public string PONo { get; set; }
        public string ApplyDate { get; set; }
        public short POType { get; set; }
        public decimal Amount { get; set; }
        public short ArrivalStatus { get; set; }
        public string Buyer { get; set; }
        public string BuyerDesc { get; set; }
        public string SaleNo { get; set; }
        public string DemandArrivalDate { get; set; }
        public string ActualArrivalDate { get; set; }
        public string ArrivalRemark { get; set; }
        public short POStatus { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDeptDesc { get; set; }
        public string Applicant { get; set; }
        public string ApplicantDesc { get; set; }
        public string Register { get; set; }
        public string RegisterDesc { get; set; }
        public Nullable<System.DateTime> RegistDate { get; set; }
        public short PaymentStatus { get; set; }
        public string ApprovalDate { get; set; }
        public string Approval { get; set; }
        public string ApprovalDesc { get; set; }
        public string SendApprovalDate { get; set; }
        public string ApprovalRemark { get; set; }
        public short StorageStatus { get; set; }
    }
}
