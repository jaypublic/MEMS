using System;
using System.Collections.Generic;
//using System.Data;
using System.Linq;
using System.Web;

using System.Data.Entity;
using MEMS.DB.Models;
using MEMS.DB.ExtModels;

namespace MEMSservice.BLL
{
    public class ProductHelper
    {
        public List<ProductList> getProductLst()
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from p in db.T_Product
                          join c in db.T_Customer
                          on p.customerid equals c.id
                          select new ProductList { id = p.id, customerid = p.customerid.Value, procode = p.procode, proname = p.proname, customername = c.customername };
                return rst.ToList();
            }
        }
        public List<ProductList> getProductLstbyCdt(string code, string name, int[] cidlst)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from p in db.T_Product
                          join c in db.T_Customer
                          on p.customerid equals c.id
                          where p.procode.Contains(code) &&
                          p.proname.Contains(name) &&
                          cidlst.Contains(p.customerid.Value)
                          select new ProductList
                          {
                              id = p.id,
                              customerid = p.customerid.Value,
                              procode = p.procode,
                              proname = p.proname,
                              customername = c.customername
                          };
                return rst.ToList();
            }
        }
        public List<T_ProductType> getPtypelst()
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from t in db.T_ProductType
                          select t;
                return rst.ToList();
            }
        }
        public T_Product getProductbyId(int pid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from p in db.T_Product
                          where p.id == pid
                          select p;
                return rst.FirstOrDefault();
            }
        }
        public List<T_Product> getProductbyCid(int customerid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from p in db.T_Product
                          where p.customerid == customerid
                          select p;
                return rst.ToList();
            }
        }
        public bool AddNewProduct(T_Product product)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.T_Product.Add(product);
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public bool UpdateProduct(T_Product product)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(product).State = EntityState.Modified;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public List<T_Crafts> getProCraft(int pid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from c in db.T_Crafts
                          where c.pid == pid
                          orderby c.processindex
                          select c;
                return rst.ToList();
            }
        }
        public bool AddNewCraft(T_Crafts craft)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(craft).State = EntityState.Added;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public bool UpdateCraft(T_Crafts craft)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(craft).State = EntityState.Modified;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public bool DeleteCraft(T_Crafts craft)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(craft).State = EntityState.Deleted;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public List<T_ProductDraw> getProductDrawList(int pid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from d in db.T_ProductDraw
                          where d.pid == pid
                          select d;
                return rst.ToList();
            }
        }
        public List<T_ProductbasicPrice> getProductPriceList(int pid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from p in db.T_ProductbasicPrice
                          where p.productid == pid
                          orderby p.id descending
                          select p;
                return rst.ToList();
            }
        }
        /// <summary>
        /// 返回pricebasicid
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public int AddProductPrice(T_ProductbasicPrice price)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(price).State = EntityState.Added;
                var success = db.SaveChanges() > 0 ? true : false;
                if (success)
                {
                    return price.id;
                }
                else
                {
                    return 0;
                }
            }
        }
        public List<T_CraftsPrice> getCraftPricelst(int pid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from p in db.T_CraftsPrice
                          where p.pid == pid
                          select p;
                return rst.ToList();
            }
        }
        public bool AddNewCraftPricelst(List<T_CraftsPrice> ncplst, int pbid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                foreach (var newcp in ncplst)
                {
                    newcp.pricebasicid = pbid;
                    db.Entry(newcp).State = EntityState.Added;
                }
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public string getPriceVersion(int pid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from p in db.T_ProductbasicPrice
                          where p.productid == pid
                          orderby p.id descending
                          select p;
                var lastver = rst.FirstOrDefault();
                if (lastver == null)
                {
                    return "01";
                }
                else
                {
                    if (lastver.version.Substring(0, 8) == DateTime.Now.ToString("yyyyMMdd"))
                    {
                        var ver = lastver.version.Substring(8, 2);
                        int num = Convert.ToInt32(ver) + 1;
                        ver = num.ToString("D2");
                        return ver;
                    }
                    else
                    {
                        return "01";
                    }
                }
            }
        }
        public List<T_quotation> getQuotationList()
        {
            using (MEMSContext db = new MEMSContext())
            {
                string quno = "";
                var rst = from q in db.T_quotation
                          where q.qutationno.Contains(quno)
                          orderby q.quotationdate descending
                          select q;
                return rst.ToList();
            }
        }
        /// <summary>
        /// 根据条件返回报价单列表
        /// </summary>
        /// <param name="quno"></param>
        /// <param name="cid"></param>
        /// <param name="aftdate"></param>
        /// <param name="bfedate"></param>
        /// <returns></returns>
        public List<T_quotation> getQuotationListbyP(string quno, int cid, DateTime aftdate, DateTime bfedate)
        {
            using (MEMSContext db = new MEMSContext())
            {
                List<T_quotation> qlst;
                if (cid > 0)
                {
                    var rst = from q in db.T_quotation
                              where q.qutationno.Contains(quno) && q.customerid.Value == cid &&
                              q.quotationdate.Value >= aftdate && q.quotationdate.Value <= bfedate
                              orderby q.id descending
                              select q;
                    qlst = rst.ToList();
                }
                else
                {
                    var rst = from q in db.T_quotation
                              where q.qutationno.Contains(quno) &&
                              q.quotationdate.Value >= aftdate && q.quotationdate.Value <= bfedate
                              orderby q.id descending
                              select q;
                    qlst = rst.ToList();
                }
                return qlst;
            }
        }
        /// <summary>
        /// 根据Id获取报价单
        /// </summary>
        /// <param name="qid"></param>
        /// <returns></returns>
        public T_quotation getQuotationbyId(int qid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from q in db.T_quotation
                          where q.id == qid
                          select q;
                return rst.FirstOrDefault();
            }
        }
        /// <summary>
        /// 添加新的报价单
        /// </summary>
        /// <param name="newqt"></param>
        /// <returns></returns>
        public bool AddNewQuotation(T_quotation newqt)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(newqt).State = EntityState.Added;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 修改报价单
        /// </summary>
        /// <param name="qt"></param>
        /// <returns></returns>
        public bool UpdateQuotation(T_quotation qt)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(qt).State = EntityState.Modified;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 删除报价单
        /// </summary>
        /// <param name="qt"></param>
        /// <returns></returns>
        public bool DeleteQuotation(T_quotation qt)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry(qt).State = EntityState.Deleted;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 获得报价单产品
        /// </summary>
        /// <param name="Qtid"></param>
        /// <returns></returns>
        public List<QtProduct> getQtProduct(int Qtid)
        {
            using (MEMSContext db = new MEMSContext())
            {
                var rst = from q in db.T_quotationprice
                          where q.quotationid == Qtid
                          join p in db.T_Product on q.productid equals (p.id)
                          select new QtProduct
                          {
                              productName = p.proname,
                              productCode = p.procode,
                              productSpec = p.prospecification,
                              qp = q
                          };
                return rst.ToList();
            }
        }
        /// <summary>
        /// 添加新的报价单产品明细
        /// </summary>
        /// <param name="qtprice"></param>
        public bool AddNewQtPrice(QtProduct qtprice)
        {
            using (MEMSContext db = new MEMSContext())
            {
                db.Entry<T_quotationprice>(qtprice.qp).State = EntityState.Added;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        /// <summary>
        /// 添加新的报价单产品明细列表
        /// </summary>
        /// <param name="qtpricelst"></param>
        public bool AddNewQtPriceList(List<QtProduct> qtpricelst)
        {
            try
            {
                using (MEMSContext db = new MEMSContext())
                {
                    foreach (var qp in qtpricelst)
                    {
                        db.Entry<T_quotationprice>(qp.qp).State = EntityState.Added;
                    }
                    return db.SaveChanges() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}