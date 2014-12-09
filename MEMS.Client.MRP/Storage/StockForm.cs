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
    public partial class StockForm : MEMS.Client.Common.BaseListForm
    {
        ServiceProxy _Proxy = new ServiceProxy();

        public StockForm()
        {
            InitializeComponent();

            SearchObject();
        }

        protected override void SearchObject()
        {
            this.StockCodeTreeList.DataSource = null;
            this.StockCodeTreeList.DataSource = _Proxy.GetStockCodeTreeList();
            this.StockCodeTreeList.RefreshDataSource();
        }

        protected override void AddObject()
        {
            CodeEditWindow form = new CodeEditWindow(3, CharacterCasing.Upper, false);
            form.FormClosed += (o, e) =>
            {
                if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    T_StockCode stockCode =new T_StockCode() { Code = form.Code, Desc = form.Desc };

                    if (this.StockCodeTreeList.DataSource != null)
                    {
                        List<T_StockCode> codeList = this.StockCodeTreeList.DataSource as List<T_StockCode>;
                        stockCode.Id = codeList.Select(t => t.Id).Max() + 1;
                    }
                    else
                    {
                        stockCode.Id = 0;
                    }

                    if (this.StockCodeTreeList.FocusedNode == null)
                    {
                        stockCode.ParentId = -1;
                    }
                    else
                    {
                        stockCode.ParentId = Convert.ToInt16(this.StockCodeTreeList.FocusedNode.GetValue("Id"));
                    }

                    //_Proxy.AddStockCode(stockCode);

                    this.StockCodeTreeList.BeginUnboundLoad();
                    DevExpress.XtraTreeList.Nodes.TreeListNode node = this.StockCodeTreeList.AppendNode(stockCode, this.StockCodeTreeList.FocusedNode);
                    node.SetValue("Id", stockCode.Id);
                    node.SetValue("Code", stockCode.Code);
                    node.SetValue("Desc", stockCode.Desc);
                    this.StockCodeTreeList.EndUnboundLoad();
                }
            };

            form.ShowDialog();
        }

        protected override void EditObject()
        {
            if (this.StockCodeTreeList.FocusedNode == null)
                return;

            CodeEditWindow form = new CodeEditWindow(2, CharacterCasing.Upper, false);
            form.Code = this.StockCodeTreeList.FocusedNode.GetValue("Code").ToString();
            form.Desc = this.StockCodeTreeList.FocusedNode.GetValue("Desc").ToString();
            form.FormClosed += (o, e) =>
            {
                T_CodeType codeType = new T_CodeType()
                {
                    Code = form.Code,
                    Desc = form.Desc,
                    Id = Convert.ToInt16(this.StockCodeTreeList.FocusedNode.GetValue("Id")),
                    ParentId = Convert.ToInt16(this.StockCodeTreeList.FocusedNode.GetValue("ParentId"))
                };

                _Proxy.UpdateCodeType(codeType);

                this.StockCodeTreeList.FocusedNode.SetValue("Code", codeType.Code);
                this.StockCodeTreeList.FocusedNode.SetValue("Desc", codeType.Desc);
            };

            form.ShowDialog();
        }

        protected override void DeleteObject()
        {
            if (this.StockCodeTreeList.FocusedNode == null)
                return;

            //_Proxy.DeleteStockCode(Convert.ToInt16(this.MatCodeTreeList.FocusedNode.GetValue("Id")));

            this.StockCodeTreeList.DeleteNode(this.StockCodeTreeList.FocusedNode);
        }
    }
}
