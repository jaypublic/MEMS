using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MEMS.Client.Common;
using MEMS.Client.CRM.CRMService;

namespace MEMS.Client.CRM
{
    public partial class CustomerinfoForm : BaseinfoForm
    {
        private List<T_Customer_contacts> modifycontactlst = new List<T_Customer_contacts>();
        private List<T_Customer_address> modifyaddresslst = new List<T_Customer_address>();

        private int m_cid;
        private T_Customer m_customer;

        public CustomerinfoForm(frmmodetype mode)
        {
            InitializeComponent();
            this.formmode = mode;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idx">客户id</param>
        /// <param name="mode">窗体模式</param>
        public CustomerinfoForm(int idx, frmmodetype mode)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.m_cid = idx;
            this.formmode = mode;
        }

        protected override void FormLoad()
        {
            base.FormLoad();
            var client = new CRMServiceClient();
            if (this.formmode == frmmodetype.edit)
            {
                m_customer = client.getCustomerbyid(m_cid);
                SetData(m_customer);
            }
            else if (formmode == frmmodetype.delete)
            {
                m_customer = client.getCustomerbyid(m_cid);
                SetData(m_customer);
                enabletxtbox(this.Controls);
            }
            var comtypelst = client.getCpytypeList();
            foreach (var comtype in comtypelst)
            {
                this.cmb_companytype.Properties.Items.Add(comtype.typename);
            }
            var custypelst = client.getCtmtypeList();
            foreach (var custype in custypelst)
            {
                this.cmb_customertype.Properties.Items.Add(custype.typename);
            }
            var proflst = client.getProfList();
            foreach (var prof in proflst)
            {
                this.cmb_profession.Properties.Items.Add(prof.professionname);
            }
            List<T_Customer_address> addresslst = new List<T_Customer_address>(client.getCustomerAddressList(m_cid));
            this.gcaddress.DataSource = addresslst;
            List<T_Customer_contacts> contactlst = new List<T_Customer_contacts>(client.getCustomerContactList(m_cid));
            this.gccontacts.DataSource = contactlst;

            //this.btn_addressdel.Visible = false;
            //this.btn_contactdel.Visible = false;
        }

        protected override void DeleteObject()
        {
            if (XtraMessageBox.Show("是否删除该客户", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var client = new CRMServiceClient();
                client.DeleteCustomer(m_customer);
            }
            base.DeleteObject();
        }
        protected override void EditObject()
        {
            m_customer.customerno = txt_cpno.Text;
            m_customer.customername = txt_copname.Text;
            m_customer.simplename = txt_copsname.Text;
            m_customer.country = txt_country.Text;
            m_customer.website = txt_website.Text;
            m_customer.companyaddress = txt_address.Text;
            m_customer.city = txt_city.Text;
            m_customer.customerdesc = txt_customerdesc.Text;
            m_customer.email = txt_email.Text;
            m_customer.accountname = txt_cw_accountname.Text;
            m_customer.accountno = txt_cw_accountno.Text;
            m_customer.invoiceaddress = txt_cw_address.Text;
            m_customer.bank = txt_cw_bank.Text;
            m_customer.taxcode = txt_cw_taxcode.Text;
            m_customer.fax = txt_fax.Text;
            m_customer.postcode = txt_postcode.Text;
            m_customer.productinfo = txt_productinfo.Text;
            m_customer.phone = txt_phone.Text;
            m_customer.province = txt_province.Text;
            m_customer.remarks = txt_remark.Text;
            m_customer.customertype = cmb_customertype.SelectedText;
            m_customer.companytype = cmb_companytype.SelectedText;
            m_customer.profession = cmb_profession.SelectedText;
            var client = new CRMServiceClient();
            client.EditCustomer(this.m_customer);
            base.EditObject();
        }


        protected override void AddObject()
        {
            T_Customer newcustomer = new T_Customer();
            newcustomer.customerno = txt_cpno.Text;
            newcustomer.customername = txt_copname.Text;
            newcustomer.simplename = txt_copsname.Text;
            newcustomer.country = txt_country.Text;
            newcustomer.website = txt_website.Text;
            newcustomer.companyaddress = txt_address.Text;
            newcustomer.city = txt_city.Text;
            newcustomer.customerdesc = txt_customerdesc.Text;
            newcustomer.email = txt_email.Text;
            newcustomer.accountname = txt_cw_accountname.Text;
            newcustomer.accountno = txt_cw_accountno.Text;
            newcustomer.invoiceaddress = txt_cw_address.Text;
            newcustomer.bank = txt_cw_bank.Text;
            newcustomer.taxcode = txt_cw_taxcode.Text;
            newcustomer.fax = txt_fax.Text;
            newcustomer.postcode = txt_postcode.Text;
            newcustomer.productinfo = txt_productinfo.Text;
            newcustomer.phone = txt_phone.Text;
            newcustomer.province = txt_province.Text;
            newcustomer.remarks = txt_remark.Text;
            newcustomer.customertype = cmb_customertype.SelectedText;
            newcustomer.companytype = cmb_companytype.SelectedText;
            newcustomer.profession = cmb_profession.SelectedText;
            var client = new CRMServiceClient();
            client.AddNewCustomer(newcustomer);
            base.AddObject();
        }

        private void SetData(T_Customer customer)
        {
            txt_cpno.Text = customer.customerno;
            txt_copname.Text = customer.customername;
            txt_copsname.Text = customer.simplename;
            txt_country.Text = customer.country;
            txt_website.Text = customer.website;
            txt_address.Text = customer.companyaddress;
            txt_city.Text = customer.city;
            txt_customerdesc.Text = customer.customerdesc;
            txt_email.Text = customer.email;
            txt_cw_accountname.Text = customer.accountname;
            txt_cw_accountno.Text = customer.accountno;
            txt_cw_address.Text = customer.invoiceaddress;
            txt_cw_bank.Text = customer.bank;
            txt_cw_taxcode.Text = customer.taxcode;
            txt_fax.Text = customer.fax;
            txt_postcode.Text = customer.postcode;
            txt_productinfo.Text = customer.productinfo;
            txt_phone.Text = customer.phone;
            txt_province.Text = customer.province;
            txt_remark.Text = customer.remarks;
            cmb_companytype.SelectedText = customer.companytype;
            cmb_customertype.SelectedText = customer.customertype;
            cmb_profession.SelectedText = customer.profession;
        }

        private void btn_contactadd_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = (List<T_Customer_contacts>)this.gvcontacts.DataSource;
                var newcontact = new T_Customer_contacts();
                newcontact.customerid = m_cid;
                modifycontactlst.Add(newcontact);
                ds.Insert(0, newcontact);
                gvcontacts.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btn_contactdel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvcontacts.DataRowCount > 0)
                {
                    var ds = (List<T_Customer_contacts>)this.gvcontacts.DataSource;
                    int idx = (int)gvcontacts.GetFocusedRowCellValue("id");
                    var contactid = gvcontacts.FocusedRowHandle;
                    if (idx <= 0)
                    {
                        ds.RemoveAt(contactid);
                        gvcontacts.RefreshData();
                    }
                    else
                    {                        
                        if (XtraMessageBox.Show("是否删除已保存的联系人", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            T_Customer_contacts contacts = ds.Find(c => c.id == idx);
                            var client = new CRMServiceClient();
                            client.DelCustomerContact(contacts);
                            ds.RemoveAt(contactid);
                            gvcontacts.RefreshData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btn_contactsave_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new CRMServiceClient();
                foreach (var contact in modifycontactlst)
                {
                    if (contact.id == 0)
                    {
                        client.AddCustomerContact(contact);
                    }
                    else
                    {
                        client.UpdCustomerContact(contact);
                    }
                }
                gvcontacts.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gvcontacts_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                int idx = (int)gvcontacts.GetFocusedRowCellValue("id");
                if (!modifycontactlst.Exists(c => c.id == idx))
                {
                    var ds = (List<T_Customer_contacts>)this.gvcontacts.DataSource;
                    var contact = ds.Find(c => c.id == idx);
                    modifycontactlst.Add(contact);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void btn_addressadd_Click(object sender, EventArgs e)
        {
            var ds = (List<T_Customer_address>)this.gvaddress.DataSource;
            var newaddress = new T_Customer_address();
            newaddress.customerid = m_cid;
            modifyaddresslst.Add(newaddress);
            ds.Insert(0, newaddress);
            gvaddress.RefreshData();
        }

        private void btn_addressdel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvaddress.DataRowCount > 0)
                {
                    int idx = (int)gvaddress.GetFocusedRowCellValue("id");
                    var ds = (List<T_Customer_address>)gvaddress.DataSource;
                    var addressid = gvaddress.FocusedRowHandle;
                    if (idx <= 0)
                    {
                        ds.RemoveAt(addressid);
                        gvaddress.RefreshData();
                    }
                    else
                    {
                        if (XtraMessageBox.Show("是否删除选中的收货地址", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var address = ds.Find(a => a.id == idx);
                            var client = new CRMServiceClient();
                            client.DelCustomerAddress(address);
                            ds.RemoveAt(addressid);
                            gvaddress.RefreshData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btn_addresssave_Click(object sender, EventArgs e)
        {
            try
            {
                var webclient = new CRMServiceClient();
                foreach (var address in modifyaddresslst)
                {
                    if (address.id == 0)
                    {
                        webclient.AddCustomerAddress(address);
                    }
                    else
                    {
                        webclient.UpdCustomerAddress(address);
                    }
                }
                gvaddress.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gvaddress_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                int idx = (int)gvaddress.GetFocusedRowCellValue("id");
                if (!modifyaddresslst.Exists(a => a.id == idx))
                {
                    var ds = (List<T_Customer_address>)this.gvaddress.DataSource;
                    var address = ds.Find(a => a.id == idx);
                    modifyaddresslst.Add(address);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}