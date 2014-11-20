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
    public partial class UnitForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public UnitForm()
        {
            InitializeComponent();

            SearchObject();
        }

        protected override void SearchObject()
        {
            this.gcUnits.DataSource = _Proxy.GetUnitList();
        }

        protected override void AddObject()
        {
            CodeEditWindow form = new CodeEditWindow(10, CharacterCasing.Lower, false);
            form.FormClosed += (o, e) =>
            {
                if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    T_Unit unit = new T_Unit() { Code = form.Code, Desc = form.Desc };
                    _Proxy.AddUnit(unit);
                    this.gvUnit.RefreshData();
                }
            };

            form.ShowDialog();
        }

        protected override void EditObject()
        {
            if (this.gvUnit.GetFocusedRow() == null)
                return;

            T_Unit unit = this.gvUnit.GetFocusedRow() as T_Unit;

            CodeEditWindow form = new CodeEditWindow(10, CharacterCasing.Lower, true);
            form.Code = unit.Code;
            form.Desc = unit.Desc;
            form.FormClosed += (o, e) =>
            {
                unit.Desc = form.Desc;

                _Proxy.UpdateUnit(unit);
                this.gvUnit.RefreshData();
            };

            form.ShowDialog();
        }

        protected override void DeleteObject()
        {
            if (this.gvUnit.GetFocusedRow() == null)
                return;

            //this.gvUnit.DeleteSelectedRows();
            _Proxy.DeleteUnit((this.gvUnit.GetFocusedRow() as T_Unit).Code);
            this.gvUnit.RefreshData();
        }
    }
}
