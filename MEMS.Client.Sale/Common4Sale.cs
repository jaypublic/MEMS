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
