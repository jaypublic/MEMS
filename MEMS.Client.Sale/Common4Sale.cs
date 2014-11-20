using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEMS.Client.Sale
{
    public class Common4Sale
    {
    }
    /// <summary>
    /// 枚举类型显示处理类
    /// </summary>
    public class DisPlayEnum
    {
        public int key { get; set; }
        public string value { get; set; }
        public override string ToString()
        {
            return value;
        }
        /// <summary>
        /// 获得枚举类型的数据源绑定
        /// </summary>
        /// <param name="enumtype"></param>
        /// <returns></returns>
        public static List<DisPlayEnum> getEnumDS(Type enumtype)
        {
            List<DisPlayEnum> ds = new List<DisPlayEnum>();
            var enumNames = Enum.GetNames(enumtype);
            for (int i = 0; i < enumNames.Length; i++)
            {
                DisPlayEnum t = new DisPlayEnum();
                t.key = i;
                t.value = enumNames[i];
                ds.Add(t);
            }
            return ds;
        }
        /// <summary>
        /// 获得枚举类型的数据源绑定,并绑定至dev的lookupEdit
        /// </summary>
        /// <param name="lkupedit"></param>
        /// <param name="enumtype"></param>
        public static void getEnumDS(RepositoryItemLookUpEdit lkupedit, Type enumtype)
        {
            List<DisPlayEnum> ds = new List<DisPlayEnum>();
            var enumNames = Enum.GetNames(enumtype);
            for (int i = 0; i < enumNames.Length; i++)
            {
                DisPlayEnum t = new DisPlayEnum();
                t.key = i;
                t.value = enumNames[i];
                ds.Add(t);
            }
            lkupedit.DataSource = ds;
            lkupedit.ValueMember = "key";
            lkupedit.DisplayMember = "value";
            lkupedit.ShowFooter = false;
            lkupedit.ShowHeader = false;
        }        
    }
    /// <summary>
    /// 收款类型
    /// </summary>
    public enum receiveType
    {
        /// <summary>
        /// 按订单收款
        /// </summary>
        Order,
        /// <summary>
        /// 按产品明细收款
        /// </summary>
        Product
    }
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum orderState
    {
        /// <summary>
        /// 订单开始
        /// </summary>
        Start,
        /// <summary>
        /// 订单收款中
        /// </summary>
        Receive,
        /// <summary>
        /// 订单关闭
        /// </summary>
        Close
    }
    /// <summary>
    /// 收款状态
    /// </summary>
    public enum receiveState
    {
        /// <summary>
        /// 收款未开始
        /// </summary>
        NotStart,
        /// <summary>
        /// 收款进行中
        /// </summary>
        Process,
        /// <summary>
        /// 收款完成
        /// </summary>
        Finish
    }
}
