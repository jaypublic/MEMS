using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data;

using System.Data.Entity;
using MEMS.DB.Models;
using MEMS.DB.ExtModels;

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
            using (MEMSContext db = new MEMSContext())
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
            using (MEMSContext db = new MEMSContext())
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
            using (MEMSContext db = new MEMSContext())
            {
                var rs = from s in db.T_saleorder
                         where s.saleno.Contains(saleOrderNo) && s.saledate >= dtstart && s.saledate <= dtend
                         join q in db.T_quotation on s.quotationid equals (q.id)
                         join c in db.T_Customer on s.customerid equals (c.id)
                         select new SaleOrder { so = s, qtno = q.qutationno, customername = c.customername };
                return rs.ToList();
            }
        }
        /// <summary>
        /// 添加新销售订单主表
        /// </summary>
        /// <param name="so">销售订单主表</param>
        /// <returns></returns>
        public bool AddNewSaleOrder(T_saleorder so)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(so).State = EntityState.Added;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 添加新销售订单主从表信息
        /// </summary>
        /// <param name="so">主表对象</param>
        /// <param name="sdlist">从表对象</param>
        /// <returns></returns>
        public bool AddNewSaleOrder(T_saleorder so, List<T_saledetail> sdlist)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(so).State = EntityState.Added;
                db.SaveChanges();
                foreach (var sd in sdlist)
                {
                    sd.soid = so.id;
                    db.Entry(sd).State = EntityState.Added;
                }
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 修改销售订单主表
        /// </summary>
        /// <param name="so">销售订单主表</param>
        /// <returns></returns>
        public bool UpdateSaleOrder(T_saleorder so)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(so).State = EntityState.Modified;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 删除销售订单主表
        /// </summary>
        /// <param name="so">销售订单主表</param>
        /// <returns></returns>
        public bool DeleteSaleOrder(T_saleorder so)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(so).State = EntityState.Deleted;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 根据销售单主表id获取从表数据
        /// </summary>
        /// <param name="soid"></param>
        /// <returns></returns>
        public List<T_saledetail> getSaleDetailbysoid(int soid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rs = from sd in db.T_saledetail
                         where sd.soid == soid
                         select sd;
                return rs.ToList();
            }
        }
        /// <summary>
        /// 获得
        /// </summary>
        /// <param name="soid"></param>
        /// <returns></returns>
        public List<SaleProduct> getSaleProductbysoid(int soid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rs = from sd in db.T_saledetail
                         join p in db.T_Product on sd.productid equals (p.id)
                         join q in db.T_quotationprice on p.id equals (q.productid)
                         where sd.soid == soid
                         select new SaleProduct
                         {
                             sd = sd,
                             productCode = p.procode,
                             productName = p.proname,
                             productSpec = p.prospecification,
                             pModelPrice = q.modelprice,
                             pUnitPrice = q.unitprice
                         };
                return rs.ToList();
            }
        }

        public List<T_SaleReceive> getSaleRecievebysoid(int soid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rs = from r in db.T_SaleReceive
                         where r.soid == soid
                         select r;
                return rs.ToList();
            }
        }
        //public List<SaleRev> getSaleRevList(int soid)
        //{
        //    using (MEMSContext db = new MEMSContext())
        //    {
        //        var rs=from r in db.T_SaleReceive
        //               join u in db.t_
        //    }
        //}
        public bool AddNewSaleRev(List<T_SaleReceive> revlst)
        {
            using (MEMSContext db = new MEMSContext())
            {
                foreach (var r in revlst)
                {
                    db.Entry<T_SaleReceive>(r).State = EntityState.Added;
                }
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public bool UpdateSaleDetail(List<T_saledetail> sdlst)
        {
            using (MEMSContext db = new MEMSContext())
            {
                foreach (var d in sdlst)
                {
                    db.Entry(d).State = EntityState.Modified;

                }
                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}