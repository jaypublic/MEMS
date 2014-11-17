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
        public List<T_saleorder> getAllSaleOrderList()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rs = from s in db.T_saleorder
                         select s;
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
    }
}