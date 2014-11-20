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
    public partial class MaterailModeForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public MaterailModeForm()
        {
            InitializeComponent();

            SearchObject();
        }

        protected override void SearchObject()
        {
            this.gcCode.DataSource = _Proxy.GetMatModeList();
        }

        protected override void AddObject()
        {
            CodeEditWindow form = new CodeEditWindow(2, CharacterCasing.Upper, false);
            form.FormClosed += (o, e) =>
            {
                if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    T_MaterailMode matMode = new T_MaterailMode() { Code = form.Code, Desc = form.Desc };
                    _Proxy.AddMatMode(matMode);
                    this.gvCode.RefreshData();
                }
            };

            form.ShowDialog();
        }

        protected override void EditObject()
        {
            if (this.gvCode.GetFocusedRow() == null)
                return;

            T_MaterailMode matMode = this.gvCode.GetFocusedRow() as T_MaterailMode;

            CodeEditWindow form = new CodeEditWindow(2, CharacterCasing.Upper, true);
            form.Code = matMode.Code;
            form.Desc = matMode.Desc;
            form.FormClosed += (o, e) =>
            {
                matMode.Desc = form.Desc;

                _Proxy.UpdateMatMode(matMode);
                this.gvCode.RefreshData();
            };

            form.ShowDialog();
        }

        protected override void DeleteObject()
        {
            if (this.gvCode.GetFocusedRow() == null)
                return;

            //this.gvUnit.DeleteSelectedRows();
            _Proxy.DeleteMatMode((this.gvCode.GetFocusedRow() as T_MaterailMode).Code);
            this.gvCode.RefreshData();
        }
    }
}
