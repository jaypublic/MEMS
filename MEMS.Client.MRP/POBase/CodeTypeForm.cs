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
    public partial class CodeTypeForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public CodeTypeForm()
        {
            InitializeComponent();

            SearchObject();
        }

        protected override void SearchObject()
        {
            this.MatCodeTreeList.DataSource = null;
            this.MatCodeTreeList.DataSource = _Proxy.GetCodeTypeList();
            this.MatCodeTreeList.RefreshDataSource();
        }

        protected override void AddObject()
        {
            CodeEditWindow form = new CodeEditWindow(2, CharacterCasing.Upper, false);
            form.FormClosed += (o, e) =>
            {
                if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    T_CodeType codeType = new T_CodeType() { Code = form.Code, Desc = form.Desc };

                    if (this.MatCodeTreeList.DataSource != null)
                    {
                        List<T_CodeType> codeList = this.MatCodeTreeList.DataSource as List<T_CodeType>;
                        codeType.Id = codeList.Select(t => t.Id).Max() + 1;
                    }
                    else
                    {
                        codeType.Id = 0;
                    }

                    if (this.MatCodeTreeList.FocusedNode == null)
                    {
                        codeType.ParentId = -1;
                    }
                    else
                    {
                        codeType.ParentId = Convert.ToInt16(this.MatCodeTreeList.FocusedNode.GetValue("Id"));
                    }

                    //_Proxy.AddCodeType(codeType);

                    this.MatCodeTreeList.BeginUnboundLoad();
                    DevExpress.XtraTreeList.Nodes.TreeListNode node = this.MatCodeTreeList.AppendNode(codeType, this.MatCodeTreeList.FocusedNode);
                    node.SetValue("Id", codeType.Id);
                    node.SetValue("Code", codeType.Code);
                    node.SetValue("Desc", codeType.Desc);
                    this.MatCodeTreeList.EndUnboundLoad();
                }
            };

            form.ShowDialog();
        }

        protected override void EditObject()
        {
            if (this.MatCodeTreeList.FocusedNode == null)
                return;

            CodeEditWindow form = new CodeEditWindow(2, CharacterCasing.Upper, false);
            form.Code = this.MatCodeTreeList.FocusedNode.GetValue("Code").ToString();
            form.Desc = this.MatCodeTreeList.FocusedNode.GetValue("Desc").ToString();
            form.FormClosed += (o, e) =>
            {
                T_CodeType codeType = new T_CodeType()
                {
                    Code = form.Code,
                    Desc = form.Desc,
                    Id = Convert.ToInt16(this.MatCodeTreeList.FocusedNode.GetValue("Id")),
                    ParentId = Convert.ToInt16(this.MatCodeTreeList.FocusedNode.GetValue("ParentId"))
                };

                _Proxy.UpdateCodeType(codeType);

                this.MatCodeTreeList.FocusedNode.SetValue("Code", codeType.Code);
                this.MatCodeTreeList.FocusedNode.SetValue("Desc", codeType.Desc);
            };

            form.ShowDialog();
        }

        protected override void DeleteObject()
        {
            if (this.MatCodeTreeList.FocusedNode == null)
                return;

            //_Proxy.DeleteCodeType(Convert.ToInt16(this.MatCodeTreeList.FocusedNode.GetValue("Id")));

            this.MatCodeTreeList.DeleteNode(this.MatCodeTreeList.FocusedNode);
        }
    }
}
