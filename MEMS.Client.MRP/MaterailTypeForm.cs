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
    public partial class MaterailTypeForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public MaterailTypeForm()
        {
            InitializeComponent();

            SearchObject();
        }

        protected override void SearchObject()
        {
            this.gcCode.DataSource = _Proxy.GetMatTypeList();
        }

        protected override void AddObject()
        {
            CodeEditWindow form = new CodeEditWindow(2, CharacterCasing.Upper, false);
            form.FormClosed += (o, e) =>
            {
                if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    T_MaterailType matType = new T_MaterailType() { Code = form.Code, Desc = form.Desc };
                    _Proxy.AddMatType(matType);
                    this.gvCode.RefreshData();
                }
            };

            form.ShowDialog();
        }

        protected override void EditObject()
        {
            if (this.gvCode.GetFocusedRow() == null)
                return;

            T_MaterailType matType = this.gvCode.GetFocusedRow() as T_MaterailType;

            CodeEditWindow form = new CodeEditWindow(2, CharacterCasing.Upper, true);
            form.Code = matType.Code;
            form.Desc = matType.Desc;
            form.FormClosed += (o, e) =>
            {
                matType.Desc = form.Desc;

                _Proxy.UpdateMatType(matType);
                this.gvCode.RefreshData();
            };

            form.ShowDialog();
        }

        protected override void DeleteObject()
        {
            if (this.gvCode.GetFocusedRow() == null)
                return;

            //this.gvUnit.DeleteSelectedRows();
            _Proxy.DeleteMatType((this.gvCode.GetFocusedRow() as T_MaterailType).Code);
            this.gvCode.RefreshData();
        }
    }
}
