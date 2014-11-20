using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using MEMS.Client.Common;
using MEMS.Client.MRP.Entities;
using MEMS.Client.MRP.Proxy;
using MEMS.Client.MRP.UserWindows;

namespace MEMS.Client.MRP
{
    public partial class StandardMaterialListForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public StandardMaterialListForm()
        {
            InitializeComponent();

            SearchObject();
        }

        protected override void SearchObject()
        {
            this.gcMaterialCode.DataSource = _Proxy.GetStdMatList();
            this.gvMaterailCode.RefreshData();
        }

        protected override void AddObject()
        {
            var frm = new StandardMaterailInfoForm(Common.frmmodetype.add);
            refreshFormData(frm);
        }

        protected override void EditObject()
        {
            if (this.gvMaterailCode.GetFocusedRow() == null)
                return;

            T_StandardMaterial stdMat = this.gvMaterailCode.GetFocusedRow() as T_StandardMaterial;
            var frm = new StandardMaterailInfoForm(Common.frmmodetype.edit);
            frm.StandardMaterail = stdMat;
            refreshFormData(frm);
        }

        protected override void DeleteObject()
        {
            if (this.gvMaterailCode.GetFocusedRow() == null)
                return;

            _Proxy.DeleteStdMat((this.gvMaterailCode.GetFocusedRow() as T_StandardMaterial).MatCode);
            this.gvMaterailCode.RefreshData();
        }

        private void StandardMaterialListForm_Load(object sender, EventArgs e)
        {
            this.gvMatTypeEdit.DataSource = _Proxy.GetMatTypeList();
            this.gvMatModeEdit.DataSource = _Proxy.GetMatModeList();
        }
    }
}
