using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MEMSservice.DAL;

namespace MEMSservice.BLL
{
    public class SaleHelper
    {
        /// <summary>
        /// 返回销售订单集合
        /// </summary>
        /// <returns></returns>
        public List<SaleOrder> getAllSaleOrderList()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rs = from s in db.T_saleorder
                         join q in db.T_quotation on s.quotationid equals (q.id)
                         select new SaleOrder{so = s, qtno = q.qutationno };
                return rs.ToList();
            }
        }
        /// <summary>
        /// 根据ID返回销售订单
        /// </summary>
        /// <param name="soid"></param>
        /// <returns></returns>
        public T_saleorder getSaleOrderbyId(int soid)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rs = from s in db.T_saleorder
                         where s.id == soid
                         select s;
                return rs.FirstOrDefault();
            }
        }
        /// <summary>
        /// 根据销售单号以及销售日期返回销售订单列表
        /// </summary>
        /// <param name="saleOrderNo">销售单号</param>
        /// <param name="dtstart">开始日期</param>
        /// <param name="dtend">结束日期</param>
        /// <returns></returns>
        public List<SaleOrder> getSaleOrderList(string saleOrderNo,DateTime dtstart,DateTime dtend)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rs = from s in db.T_saleorder
                         where s.saleno.Contains(saleOrderNo) && s.saledate >= dtstart && s.saledate <= dtend
                         join q in db.T_quotation on s.quotationid equals (q.id)
                         select new SaleOrder { so = s, qtno = q.qutationno };
                return rs.ToList();
            }
        }
    }
}