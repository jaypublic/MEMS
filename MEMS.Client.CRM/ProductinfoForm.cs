using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MEMS.Client.Common;
using MEMS.Client.CRM.CRMService;
using DevExpress.XtraEditors;

namespace MEMS.Client.CRM
{
    public partial class ProductinfoForm : BaseinfoForm
    {
        int m_pid;
        T_Product m_product;
        string m_drawingpath;
        List<T_Crafts> modifycraftlst = new List<T_Crafts>();
        public ProductinfoForm(frmmodetype type)
        {
            InitializeComponent();
            base.formmode = type;
        }
        public ProductinfoForm(frmmodetype type, int pid)
        {
            InitializeComponent();
            base.formmode = type;
            m_pid = pid;
        }

        protected override void FormLoad()
        {
            CRMServiceClient client = new CRMServiceClient();
            var customerlst = client.getCustomerList();
            foreach (var customer in customerlst)
            {
                cmb_cst.Properties.Items.Add(customer.customername);
            }
            cmb_cst.Properties.Tag = customerlst;

            if (formmode == frmmodetype.edit)
            {
                m_product = client.getProductbyId(m_pid);
                setData();
                List<T_Crafts> craftlst = new List<T_Crafts>(client.getProductCraft(m_pid));
                gccraft.DataSource = craftlst;
            }
            else if (formmode == frmmodetype.delete)
            {
                m_product = client.getProductbyId(m_pid);
                setData();
                List<T_Crafts> craftlst = new List<T_Crafts>(client.getProductCraft(m_pid));
                gccraft.DataSource = craftlst;
            }
            
        }

        private void setData()
        {
            txt_gw.Text = m_product.progrossweight.HasValue ? m_product.progrossweight.Value.ToString() : "";
            txt_name.Text = m_product.proname;
            txt_nw.Text = m_product.pronetweight.HasValue ? m_product.pronetweight.Value.ToString() : "";
            txt_pcode.Text = m_product.procode;
            txt_spec.Text = m_product.prospecification;
            txt_unit.Text = m_product.prounit;
            var cstlst = (T_Customer[])cmb_cst.Properties.Tag;
            foreach (var cst in cstlst)
            {
                if (cst.id == m_product.customerid)
                {
                    cmb_cst.SelectedText = cst.customername;
                }
            }
        }

        protected override void AddObject()
        {
            CRMServiceClient client = new CRMServiceClient();
            m_product = new T_Product();
            getData();
            client.AddNewProduct(m_product);
            base.AddObject();
        }
        protected override void EditObject()
        {
            CRMServiceClient client = new CRMServiceClient();
            getData();
            client.UpdateProduct(m_product);
            base.EditObject();
        }

        private void getData()
        {
            m_product.procode = txt_pcode.Text;
            m_product.proname = txt_name.Text;
            m_product.prospecification = txt_spec.Text;
            m_product.drawingno = "";
            m_product.prounit = txt_unit.Text;
            if (txt_nw.Text == string.Empty)
            {
                m_product.pronetweight = null;
            }
            else
            {
                try
                {
                    m_product.pronetweight = Convert.ToDouble(txt_nw.Text);
                }
                catch (FormatException)
                {
                    throw new Exception("净重请输入数字");
                }
            }
            if (txt_gw.Text == string.Empty)
            {
                m_product.progrossweight = null;
            }
            else
            {
                try
                {
                    m_product.progrossweight = Convert.ToDouble(txt_gw.Text);
                }
                catch (FormatException)
                {
                    throw new Exception("毛重请输入数字");
                }
            }
            var cstlst = (T_Customer[])cmb_cst.Properties.Tag;
            m_product.customerid = cstlst[cmb_cst.SelectedIndex].id;
        }
        protected override void DeleteObject()
        {
            base.DeleteObject();
        }

        private void btn_drawno_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetDrawPath();
        }

        private void GetDrawPath()
        {
            drawingdiag.FileName = "";
            drawingdiag.Multiselect = false;
            drawingdiag.Filter = "所有文件|*.*|PDF文件|*.pdf|图片文件|*.jpg,*.bmp,*.png,*.gif|Office文件|*.doc,*.docx,*.xls,*.xlsx";
            if (drawingdiag.ShowDialog() == DialogResult.OK)
            {
                //btn_drawno.Text = m_product.drawingno = drawingdiag.SafeFileName;
                m_drawingpath = drawingdiag.FileName;

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (gvcraft.DataRowCount > 0)
            {
                var ds = (List<T_Crafts>)this.gvcraft.DataSource;
                var newcraft = new T_Crafts();
                newcraft.pid = m_pid;
                newcraft.processindex = ds.Count + 1;
                modifycraftlst.Add(newcraft);
                ds.Add(newcraft);
                gvcraft.RefreshData();
                gvcraft.FocusedRowHandle = ds.Count - 1;
            }
            else
            {
                List<T_Crafts> craftlst = new List<T_Crafts>();
                var newcraft = new T_Crafts();
                newcraft.pid = m_pid;
                newcraft.processindex = 1;
                craftlst.Add(newcraft);
                gccraft.DataSource = craftlst;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvcraft.DataRowCount > 0)
                {
                    var ds = (List<T_Crafts>)this.gvcraft.DataSource;
                    int idx = (int)gvcraft.GetFocusedRowCellValue("id");
                    var craftid = gvcraft.FocusedRowHandle;
                    if (idx <= 0)
                    {
                        ds.RemoveAt(craftid);
                        gvcraft.RefreshData();
                    }
                    else
                    {
                        if (XtraMessageBox.Show("是否删除已保存的工序", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            T_Crafts crafts = ds.Find(c => c.id == idx);
                            var client = new CRMServiceClient();
                            client.DeleteCraft(crafts);
                            ds.RemoveAt(craftid);
                            gvcraft.RefreshData();
                        }
                    }
                    gvcraft.FocusedRowHandle = ds.Count - 1;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            Updowncraft(movedirection.up);
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            Updowncraft(movedirection.down);
        }

        private void Updowncraft(movedirection direction)
        {
            int idx = (int)gvcraft.GetFocusedRowCellValue("processindex");
            var ds = (List<T_Crafts>)gvcraft.DataSource;
            var craft = ds.Find(c => c.processindex == idx);
            int pos = craft.processindex.Value;
            if (direction == movedirection.up)
            {
                var craftnext = ds.Find(c => c.processindex == pos - 1);
                if (craftnext == null)
                {
                    craft.processindex = pos;
                }
                else
                {
                    craft.processindex = pos - 1;
                    craftnext.processindex = pos;
                }
            }
            else
            {
                var craftnext = ds.Find(c => c.processindex == pos + 1);
                if (craftnext == null)
                {
                    craft.processindex = pos;
                }
                else
                {
                    craft.processindex = pos + 1;
                    craftnext.processindex = pos;
                }
            }
            ds.Sort(comparecraft);
            gvcraft.RefreshData();
            gvcraft.FocusedRowHandle = craft.processindex.Value - 1;
        }
        enum movedirection
        {
            up,
            down
        }
        private static int comparecraft(T_Crafts up, T_Crafts down)
        {
            if (up == null)
            {
                if (down == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (down == null)
                {
                    return 1;
                }
                else
                {
                    if (up.processindex.Value > down.processindex.Value)
                    {
                        return 1;
                    }
                    else if (up.processindex.Value == down.processindex.Value)
                    {
                        return 0;
                    }
                    else// if (up.colpos.Value < down.colpos.Value)
                    {
                        return -1;
                    }
                }
            }
        }
        private void btnfileupload_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

    }
}
