using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using MEMS.Client.Common;
using DevExpress.XtraEditors;
using MEMS.Client.MRP.UserWindows;
using MEMS.Client.MRP.Entities;
using MEMS.Client.MRP.Enums;
using MEMS.Client.MRP.Proxy;
using MEMS.Client.MRP.Toolkit;

namespace MEMS.Client.MRP
{
    public partial class POPayInfoForm : BaseinfoForm
    {
        public T_PurchaseOrder PO;
        private List<T_Invoice> _POInvoices;
        public List<string> _AddList;
        public List<string> _DelList;

        ServiceProxy proxy = new ServiceProxy();

        public POPayInfoForm(T_PurchaseOrder po)
        {
            InitializeComponent();
            this.PO = po;
        }

        protected override void FormLoad()
        {
            this.gvOPerEdit.DataSource = proxy.GetEmployees();

            _POInvoices = proxy.GetPOInvoiceList(PO.pono);
            this.gcPayInvoices.DataSource = _POInvoices;
            _AddList = new List<string>();
            _DelList = new List<string>();
        }

        protected override void AddObject()
        {
            if (SaveDetail())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        public bool SaveDetail()
        {
            string invoiceno;
            // 先检查发票号是否已存在
            foreach (string id in _AddList)
            {
                invoiceno = _POInvoices.Find(o => o.id == id).invoiceno;
                if (proxy.CheckExistInvoice(invoiceno) || _POInvoices.Where(o=>o.invoiceno ==invoiceno).Count() > 1 )
                {
                    MessageBox.Show("该发票已登记存在，不能再次登记使用");
                    return false;
                }
            }

            foreach (string id in _AddList)
            {
                proxy.AddPOInvoice(_POInvoices.Find(o => o.id == id));
            }

            foreach (string id in _DelList)
            {
                proxy.DeletePOInvoice(id);
            }

            proxy.ResetPayStatus(this.PO.pono);

            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            T_Invoice invoice = new T_Invoice() { pono = this.PO.pono, id = Guid.NewGuid().ToString(), paydate = now, registdate = now, register = Global.UserNo, registerdesc = Global.UserName };
            _POInvoices.Add(invoice);
            _AddList.Add(invoice.id);
            this.gvPayInvoices.RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.gvPayInvoices.GetFocusedRow() == null)
                return;

            string id = (this.gvPayInvoices.GetFocusedRow() as T_Invoice).id;
            if (_AddList.Contains(id))
            {
                _AddList.Remove(id);
            }
            else
            {
                _DelList.Add(id);
            }

            _POInvoices.Remove(_POInvoices.Find(o => o.id == id));
            this.gvPayInvoices.RefreshData();
        }
    }
}
