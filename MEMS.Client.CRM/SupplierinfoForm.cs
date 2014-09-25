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
    public partial class SupplierinfoForm : BaseinfoForm
    {
        private List<T_Suppliers_contacts> modifycontactlst = new List<T_Suppliers_contacts>();
        private int m_supplierid;
        private T_Suppliers m_supplier;
        public SupplierinfoForm(frmmodetype mode)
        {
            InitializeComponent();
            base.formmode = mode;
        }
        public SupplierinfoForm(frmmodetype mode, int sid)
        {
            InitializeComponent();
            base.formmode = mode;
            m_supplierid = sid;
        }

        protected override void FormLoad()
        {
            base.FormLoad();
            var client = new CRMServiceClient();
            var stypelst = client.getSuptypeLst();
            foreach (var suptype in stypelst)
            {
                cmb_stype.Properties.Items.Add(suptype.typename);
            }
            if (this.formmode == frmmodetype.edit)
            {
                m_supplier = client.getSupplierbyId(m_supplierid);
                SetData();
            }
            else if (formmode == frmmodetype.delete)
            {
                m_supplier = client.getSupplierbyId(m_supplierid);
                SetData();
                enabletxtbox(this.Controls);
            }
            var contactlst = new List<T_Suppliers_contacts>(client.getSupplierContacts(m_supplierid));
            this.gcContact.DataSource = contactlst;
        }

        private void SetData()
        {
            txt_accountname.Text = m_supplier.accountname;
            txt_accountno.Text = m_supplier.accountno;
            txt_address.Text = m_supplier.address;
            txt_bank.Text = m_supplier.bank;
            txt_city.Text = m_supplier.city;
            txt_country.Text = m_supplier.country;
            txt_email.Text = m_supplier.email;
            txt_fax.Text = m_supplier.fax;
            txt_legalman.Text = m_supplier.legalperson;
            txt_phone.Text = m_supplier.telphone;
            txt_postcode.Text = m_supplier.postcode;
            txt_province.Text = m_supplier.province;
            txt_remarks.Text = m_supplier.remarks;
            txt_scope.Text = m_supplier.businessscope;
            txt_simplename.Text = m_supplier.simplename;
            txt_splname.Text = m_supplier.suppliername;
            txt_splno.Text = m_supplier.supplierno;
            txt_taxno.Text = m_supplier.taxcode;
            txt_website.Text = m_supplier.website;
            cmb_stype.SelectedText = m_supplier.suppliertype;
        }

        protected override void AddObject()
        {
            T_Suppliers newsupplier = new T_Suppliers();
            newsupplier.accountname = txt_accountname.Text;
            newsupplier.accountno = txt_accountno.Text;
            newsupplier.address = txt_address.Text;
            newsupplier.bank = txt_bank.Text;
            newsupplier.city = txt_city.Text;
            newsupplier.country = txt_country.Text;
            newsupplier.email = txt_email.Text;
            newsupplier.fax = txt_fax.Text;
            newsupplier.legalperson = txt_legalman.Text;
            newsupplier.telphone = txt_phone.Text;
            newsupplier.postcode = txt_postcode.Text;
            newsupplier.province = txt_province.Text;
            newsupplier.remarks = txt_remarks.Text;
            newsupplier.businessscope = txt_scope.Text;
            newsupplier.simplename = txt_simplename.Text;
            newsupplier.suppliername = txt_splname.Text;
            newsupplier.supplierno = txt_splno.Text;
            newsupplier.taxcode = txt_taxno.Text;
            newsupplier.website = txt_website.Text;
            newsupplier.suppliertype = cmb_stype.SelectedText;
            var client = new CRMServiceClient();
            client.addNewSupplier(newsupplier);
            base.AddObject();
        }

        protected override void EditObject()
        {
            m_supplier.accountname = txt_accountname.Text;
            m_supplier.accountno = txt_accountno.Text;
            m_supplier.address = txt_address.Text;
            m_supplier.bank = txt_bank.Text;
            m_supplier.city = txt_city.Text;
            m_supplier.country = txt_country.Text;
            m_supplier.email = txt_email.Text;
            m_supplier.fax = txt_fax.Text;
            m_supplier.legalperson = txt_legalman.Text;
            m_supplier.telphone = txt_phone.Text;
            m_supplier.postcode = txt_postcode.Text;
            m_supplier.province = txt_province.Text;
            m_supplier.remarks = txt_remarks.Text;
            m_supplier.businessscope = txt_scope.Text;
            m_supplier.simplename = txt_simplename.Text;
            m_supplier.suppliername = txt_splname.Text;
            m_supplier.supplierno = txt_splno.Text;
            m_supplier.taxcode = txt_taxno.Text;
            m_supplier.website = txt_website.Text;
            m_supplier.suppliertype = cmb_stype.SelectedText;
            var client = new CRMServiceClient();
            client.EditSupplier(this.m_supplier);
            base.EditObject();
        }

        protected override void DeleteObject()
        {
            if (XtraMessageBox.Show("是否删除该供应商", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var client = new CRMServiceClient();
                client.DeleteSupplier(m_supplier);
            }
            base.DeleteObject();
        }

        private void btn_contactadd_Click(object sender, EventArgs e)
        {
            var ds = (List<T_Suppliers_contacts>)this.gvContact.DataSource;
            var newcontact = new T_Suppliers_contacts();
            newcontact.supplierid = m_supplierid;
            modifycontactlst.Add(newcontact);
            ds.Insert(0, newcontact);
            gvContact.RefreshData();
        }

        private void btn_contactdel_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvContact.DataRowCount > 0)
                {
                    var ds = (List<T_Suppliers_contacts>)this.gvContact.DataSource;
                    int idx = (int)gvContact.GetFocusedRowCellValue("id");
                    var contactid = gvContact.FocusedRowHandle;
                    if (idx <= 0)
                    {
                        ds.RemoveAt(contactid);
                        gvContact.RefreshData();
                    }
                    else
                    {
                        if (XtraMessageBox.Show("是否删除已保存的联系人", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            T_Suppliers_contacts contacts = ds.Find(c => c.id == idx);
                            var client = new CRMServiceClient();
                            client.DelSupplierContacts(contacts);
                            ds.RemoveAt(contactid);
                            gvContact.RefreshData();
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
                        client.AddSupplierContacts(contact);
                    }
                    else
                    {
                        client.EditSupplierContacts(contact);
                    }
                }
                gvContact.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gvContact_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                int idx = (int)gvContact.GetFocusedRowCellValue("id");
                if (!modifycontactlst.Exists(c => c.id == idx))
                {
                    var ds = (List<T_Suppliers_contacts>)this.gvContact.DataSource;
                    var contact = ds.Find(c => c.id == idx);
                    modifycontactlst.Add(contact);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
