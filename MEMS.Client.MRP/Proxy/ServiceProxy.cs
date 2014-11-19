using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MEMS.Client.MRP.Entities;
using MEMS.Client.MRP.Enums;

namespace MEMS.Client.MRP.Proxy
{
    public class ServiceProxy
    {
        public ServiceProxy()
        {
            if (CodeTypeList == null)
            {
                InitCodeTypeList();
            }

            if (UnitList == null)
            {
                InitUnitList();
            }

            if (MatTypeList == null)
            {
                InitMatTypeList();
            }

            if (MatModeList == null)
            {
                InitMatModeList();
            }

            if (StdMatList == null)
            {
                InitStdMatList();
            }

            if (POList == null)
            {
                InitPO();
            }
        }

        #region 组织、人员
        public DataTable GetAllDepts()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code");
            dt.Columns.Add("Desc");

            DataRow rowA = dt.NewRow();
            rowA["Code"] = "D000";
            rowA["Desc"] = "A部门";

            DataRow rowB = dt.NewRow();
            rowB["Code"] = "D010";
            rowB["Desc"] = "B部门";

            DataRow rowC = dt.NewRow();
            rowC["Code"] = "D020";
            rowC["Desc"] = "C部门";

            dt.Rows.Add(rowA);
            dt.Rows.Add(rowB);
            dt.Rows.Add(rowC);

            return dt;
        }

        public DataTable GetEmployees()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code");
            dt.Columns.Add("Desc");

            DataRow rowA = dt.NewRow();
            rowA["Code"] = "0001";
            rowA["Desc"] = "张三";

            DataRow rowB = dt.NewRow();
            rowB["Code"] = "0002";
            rowB["Desc"] = "李四";

            DataRow rowC = dt.NewRow();
            rowC["Code"] = "D003";
            rowC["Desc"] = "王五";

            DataRow rowD = dt.NewRow();
            rowD["Code"] = "D004";
            rowD["Desc"] = "赵六";

            dt.Rows.Add(rowA);
            dt.Rows.Add(rowB);
            dt.Rows.Add(rowC);
            dt.Rows.Add(rowD);

            return dt;
        }
        #endregion

        #region CodeType
        static List<T_CodeType> CodeTypeList;
        private void InitCodeTypeList()
        {
            CodeTypeList = new List<T_CodeType>();

            T_CodeType typeA0 = new T_CodeType() { Code = "A0", Desc = "大类", ParentId = -1, Id = 0 };
            T_CodeType typeA1 = new T_CodeType() { Code = "A1", Desc = "大类", ParentId = -1, Id = 1 };
            T_CodeType typeB0 = new T_CodeType() { Code = "B0", Desc = "中类", ParentId = 0, Id = 2 };
            T_CodeType typeB1 = new T_CodeType() { Code = "B1", Desc = "中类", ParentId = 0, Id = 3 };
            T_CodeType typeC0 = new T_CodeType() { Code = "C1", Desc = "小类", ParentId = 2, Id = 4 };
            T_CodeType typeC1 = new T_CodeType() { Code = "C2", Desc = "小类", ParentId = 2, Id = 5 };

            CodeTypeList.Add(typeA0);
            CodeTypeList.Add(typeA1);
            CodeTypeList.Add(typeB0);
            CodeTypeList.Add(typeB1);
            CodeTypeList.Add(typeC0);
            CodeTypeList.Add(typeC1);
        }

        public List<T_CodeType> GetCodeTypeList()
        {
            return CodeTypeList;
        }

        public List<T_CodeType> GetChildCodeTypeList(int parentId)
        {
            return CodeTypeList.Where(o => o.ParentId == parentId).ToList();
        }

        public void AddCodeType(T_CodeType codeType)
        {
            CodeTypeList.Add(codeType);
        }

        public void UpdateCodeType(T_CodeType codeType)
        {
            CodeTypeList.Remove(CodeTypeList.Find(o => o.Id == codeType.Id));
            CodeTypeList.Add(codeType);
        }

        public void DeleteCodeType(int id)
        {
            IList<T_CodeType> removedList;

            if (CodeTypeList.Where(o => o.ParentId == id).Count() > 0)
            {
                removedList = CodeTypeList.Where(o => o.ParentId == id).ToList();
                foreach (T_CodeType codeType in removedList)
                {
                    DeleteCodeType(codeType.Id);
                }
            }
            else
            {
                CodeTypeList.Remove(CodeTypeList.Find(o => o.Id == id));
            }
        }
        #endregion

        #region Unit
        static List<T_Unit> UnitList;
        private void InitUnitList()
        {
            UnitList = new List<T_Unit>();

            T_Unit unitA = new T_Unit() { Code = "m", Desc = "米" };
            T_Unit unitB = new T_Unit() { Code = "t", Desc = "吨" };
            T_Unit unitC = new T_Unit() { Code = "g", Desc = "克" };
            T_Unit unitD = new T_Unit() { Code = "kg", Desc = "千克" };
            T_Unit unitE = new T_Unit() { Code = "￥", Desc = "元" };
            T_Unit unitF = new T_Unit() { Code = "$", Desc = "美元" };

            UnitList.Add(unitA);
            UnitList.Add(unitB);
            UnitList.Add(unitC);
            UnitList.Add(unitD);
            UnitList.Add(unitE);
            UnitList.Add(unitF);
        }

        public List<T_Unit> GetUnitList()
        {
            return UnitList;
        }

        public void AddUnit(T_Unit unit)
        {
            UnitList.Add(unit);
        }

        public void UpdateUnit(T_Unit unit)
        {
            UnitList.Remove(UnitList.Find(o => o.Code == unit.Code));
            UnitList.Add(unit);
        }

        public void DeleteUnit(string unitCode)
        {
            UnitList.Remove(UnitList.Find(o => o.Code == unitCode));
        }
        #endregion

        #region MatType
        static List<T_MaterailType> MatTypeList;
        private void InitMatTypeList()
        {
            MatTypeList = new List<T_MaterailType>();

            T_MaterailType codeA = new T_MaterailType() { Code = "TA", Desc = "类型A" };
            T_MaterailType codeB = new T_MaterailType() { Code = "TB", Desc = "类型B" };
            T_MaterailType codeC = new T_MaterailType() { Code = "TC", Desc = "类型C" };
            T_MaterailType codeD = new T_MaterailType() { Code = "TD", Desc = "类型D" };
            T_MaterailType codeE = new T_MaterailType() { Code = "TE", Desc = "类型E" };
            T_MaterailType codeF = new T_MaterailType() { Code = "TF", Desc = "类型F" };

            MatTypeList.Add(codeA);
            MatTypeList.Add(codeB);
            MatTypeList.Add(codeC);
            MatTypeList.Add(codeD);
            MatTypeList.Add(codeE);
            MatTypeList.Add(codeF);
        }

        public List<T_MaterailType> GetMatTypeList()
        {
            return MatTypeList;
        }

        public void AddMatType(T_MaterailType matType)
        {
            MatTypeList.Add(matType);
        }

        public void UpdateMatType(T_MaterailType matType)
        {
            MatTypeList.Remove(MatTypeList.Find(o => o.Code == matType.Code));
            MatTypeList.Add(matType);
        }

        public void DeleteMatType(string code)
        {
            MatTypeList.Remove(MatTypeList.Find(o => o.Code == code));
        }
        #endregion

        #region MatMode
        static List<T_MaterailMode> MatModeList;
        private void InitMatModeList()
        {
            MatModeList = new List<T_MaterailMode>();

            T_MaterailMode codeA = new T_MaterailMode() { Code = "MA", Desc = "型号规格A" };
            T_MaterailMode codeB = new T_MaterailMode() { Code = "MB", Desc = "型号规格B" };
            T_MaterailMode codeC = new T_MaterailMode() { Code = "MC", Desc = "型号规格C" };
            T_MaterailMode codeD = new T_MaterailMode() { Code = "MD", Desc = "型号规格D" };
            T_MaterailMode codeE = new T_MaterailMode() { Code = "ME", Desc = "型号规格E" };
            T_MaterailMode codeF = new T_MaterailMode() { Code = "MF", Desc = "型号规格F" };

            MatModeList.Add(codeA);
            MatModeList.Add(codeB);
            MatModeList.Add(codeC);
            MatModeList.Add(codeD);
            MatModeList.Add(codeE);
            MatModeList.Add(codeF);
        }

        public List<T_MaterailMode> GetMatModeList()
        {
            return MatModeList;
        }

        public void AddMatMode(T_MaterailMode matMode)
        {
            MatModeList.Add(matMode);
        }

        public void UpdateMatMode(T_MaterailMode matMode)
        {
            MatModeList.Remove(MatModeList.Find(o => o.Code == matMode.Code));
            MatModeList.Add(matMode);
        }

        public void DeleteMatMode(string code)
        {
            MatModeList.Remove(MatModeList.Find(o => o.Code == code));
        }
        #endregion

        #region StandardMaterialCode
        static List<T_StandardMaterial> StdMatList;
        private void InitStdMatList()
        {
            StdMatList = new List<T_StandardMaterial>();

            T_StandardMaterial stdMatA = new T_StandardMaterial() { MatCode = "A0B0C1001", Desc = "测试编码1", MatTypeCode = "TA", MatModeCode = "MA" };
            T_StandardMaterial stdMatB = new T_StandardMaterial() { MatCode = "A0B0C2002", Desc = "测试编码2", MatTypeCode = "TC", MatModeCode = "MC" };

            StdMatList.Add(stdMatA);
            StdMatList.Add(stdMatB);
        }

        public List<T_StandardMaterial> GetStdMatList()
        {
            return StdMatList;
        }

        public void AddStdMat(T_StandardMaterial stdMat)
        {
            StdMatList.Add(stdMat);
        }

        public void UpdateStdMat(T_StandardMaterial stdMat)
        {
            StdMatList.Remove(StdMatList.Find(o => o.MatCode == stdMat.MatCode));
            StdMatList.Add(stdMat);
        }

        public void DeleteStdMat(string matCode)
        {
            StdMatList.Remove(StdMatList.Find(o => o.MatCode == matCode));
        }

        public bool CheckMatCode(string matCode)
        {
            if (StdMatList.Where(o => o.MatCode == matCode).Count() > 0)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region PO
        static List<T_PurchaseOrder> POList;
        static List<T_PurchaseOrderDetail> PODetailList;
        static List<T_Invoice> POInvoiceList;

        private void InitPO()
        {
            POList = new List<T_PurchaseOrder>();
            PODetailList = new List<T_PurchaseOrderDetail>();
            POInvoiceList = new List<T_Invoice>();

            T_PurchaseOrder po = new T_PurchaseOrder()
            {
                pono = "201400000",
                potype = 1,
                amount = 100,
                applicant = "0002",
                applicantdesc = "李四",
                applydate = "2014-11-01",
                applydept = "D000",
                applydeptdesc = "A部门",
                buyer = "0001",
                buyerdesc = "张三",
                arrivalstatus = 0,
                demandarrivaldate = "2014-12-03",
                paymentstatus = 0,
                postatus = 0,
                registdate = DateTime.Now,
                register = "0002",
                registerdesc = "李四"
            };

            POList.Add(po);

            T_PurchaseOrderDetail poDetailsA = new T_PurchaseOrderDetail()
            {
                Id = "ec45994f-be4e-49b5-a472-4ab8b64b4d9e",
                PONo = po.pono,
                Material = StdMatList[0],
                Price = 10,
                Quantity = 4,
                Unit = UnitList[0].Code
            };

            T_PurchaseOrderDetail poDetailsB = new T_PurchaseOrderDetail()
            {
                Id = "c0704259-882f-496b-8ba5-e56b979bb71f",
                PONo = po.pono,
                Material = StdMatList[1],
                Price = 20,
                Quantity = 3,
                Unit = UnitList[1].Code
            };

            PODetailList.Add(poDetailsA);
            PODetailList.Add(poDetailsB);
        }

        public List<T_PurchaseOrder> GetAllPOList()
        {
            return POList;
        }

        public List<T_PurchaseOrder> GetPOList(string startDate, string endDate, short poType, string saleNo, string applydept)
        {
            List<T_PurchaseOrder> resultList = POList.Where(o => string.Compare(o.applydate, startDate) >= 0 && string.Compare(o.applydate, endDate) <= 0 && o.potype == poType).ToList();

            if (!string.IsNullOrEmpty(saleNo))
            {
                resultList = resultList.Where(o => o.saleno.Contains(saleNo)).ToList();
            }

            if (applydept != "all")
            {
                resultList = resultList.Where(o => o.applydept == applydept).ToList();
            }

            return resultList;
        }

        public List<T_PurchaseOrder> GetPOApprovalList(string startDate, string endDate, short poType, string saleNo, string applydept)
        {
            return GetPOList(startDate, endDate, poType, saleNo, applydept).Where(o => o.postatus == (int)POStatus.审批驳回 || o.postatus == (int)POStatus.提交未审批 || o.postatus == (int)POStatus.已审批通过).ToList();
        }

        public List<T_PurchaseOrder> GetPOPayList(string startDate, string endDate, short poType, string saleNo, string applydept)
        {
            return GetPOList(startDate, endDate, poType, saleNo, applydept).Where(o => o.postatus == (int)POStatus.已审批通过 && (o.arrivalstatus == (int)ArrivalStatus.已到货 || o.arrivalstatus == (int)ArrivalStatus.部分到货)).ToList();
        }

        public List<T_PurchaseOrderDetail> GetPODetailList(string pono)
        {
            return PODetailList.Where(o => o.PONo == pono).ToList();
        }

        public List<T_Invoice> GetPOInvoiceList(string pono)
        {
            return POInvoiceList.Where(o => o.pono == pono).ToList();
        }

        public bool CheckExistInvoice(string invoiceno)
        {
            if (POInvoiceList.Where(o => o.invoiceno == invoiceno).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ResetPayStatus(string pono)
        {
            T_PurchaseOrder po = POList.Find(o => o.pono == pono);

            if (po != null)
            {
                decimal invoiceAmount = POInvoiceList.Where(o => o.pono == pono).Sum(o => o.amount);
                if (po.amount == invoiceAmount)
                {
                    po.paymentstatus = (int)PaymentStatus.已付款;
                }
                else if (invoiceAmount > 0)
                {
                    po.paymentstatus = (int)PaymentStatus.部分付款;
                }
                else
                {
                    po.paymentstatus = (int)PaymentStatus.未付款;
                }
            }
        }

        public void AddPO(T_PurchaseOrder po)
        {
            po.registdate = DateTime.Now;
            POList.Add(po);
        }

        public void AddPODetail(T_PurchaseOrderDetail poDetail)
        {
            PODetailList.Add(poDetail);
        }

        public void AddPOInvoice(T_Invoice poInvoice)
        {
            POInvoiceList.Add(poInvoice);
        }

        public void UpdatePO(T_PurchaseOrder po)
        {
            POList.Remove(POList.Find(o => o.pono == po.pono));
            POList.Add(po);
        }

        public void UpdatePODetail(T_PurchaseOrderDetail poDetail)
        {
            PODetailList.Remove(PODetailList.Find(o => o.Id == poDetail.Id));
            PODetailList.Add(poDetail);
        }

        public void UpdatePOInvoice(T_Invoice poInvoice)
        {
            POInvoiceList.Remove(POInvoiceList.Find(o => o.id == poInvoice.id));
            POInvoiceList.Add(poInvoice);
        }

        public void DeletePO(string pono)
        {
            PODetailList.Remove(PODetailList.Find(o => o.PONo == pono));
            POList.Remove(POList.Find(o => o.pono == pono));
        }

        public void DeletePODetail(string id)
        {
            PODetailList.Remove(PODetailList.Find(o => o.Id == id));
        }

        public void DeletePOInvoice(string id)
        {
            POInvoiceList.Remove(POInvoiceList.Find(o => o.id == id));
        }

        public string GetLatestPOIndex()
        {
            string year = DateTime.Now.Year.ToString();

            if (POList.Where(o => o.pono.Substring(0, 4) == year).Count() > 0)
            {
                return year + (Convert.ToUInt32(POList.Where(o => o.pono.Substring(0, 4) == year).Max(o => o.pono).Substring(4)) + 1).ToString("00000");
            }
            else
            {
                return year + "0000";
            }
        }
        #endregion
    }
}
