using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MEMSservice.DAL;

namespace MEMSservice.BLL
{
    public class ProductHelper
    {
        public List<ProductList> getProductLst()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rst = from p in db.T_Product
                          join c in db.T_Customer
                          on p.customerid equals c.id
                          select new ProductList { id = p.id, customerid = p.customerid.Value, procode = p.procode, proname = p.proname, drawingno = p.drawingno, customername = c.customername };
                return rst.ToList();
            }
        }
        public List<ProductList> getProductLstbyCdt(string code,string name,string drawingno,int[] cidlst)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rst = from p in db.T_Product
                          join c in db.T_Customer
                          on p.customerid equals c.id
                          where p.procode.Contains(code) &&
                          p.proname.Contains(name) &&
                          p.drawingno.Contains(drawingno) &&
                          cidlst.Contains(p.customerid.Value)
                          select new ProductList
                          {
                              id = p.id,
                              customerid = p.customerid.Value,
                              procode = p.procode,
                              proname = p.proname,
                              drawingno = p.drawingno,
                              customername = c.customername
                          };
                return rst.ToList();
            }
        }
        public List<T_ProductType> getPtypelst()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rst = from t in db.T_ProductType
                          select t;
                return rst.ToList();
            }
        }
        public T_Product getProductbyId(int pid)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rst = from p in db.T_Product
                          where p.id == pid
                          select p;
                return rst.FirstOrDefault();
            }
        }
        public bool AddNewProduct(T_Product product)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.T_Product.Add(product);
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public bool UpdateProduct(T_Product product)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(product).State = EntityState.Modified;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public List<T_Crafts> getProCraft(int pid)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var rst = from c in db.T_Crafts
                          where c.pid == pid
                          select c;
                return rst.ToList();
            }
        }
        public bool AddNewCraft(T_Crafts craft)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(craft).State = EntityState.Added;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public bool UpdateCraft(T_Crafts craft)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(craft).State = EntityState.Modified;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
        public bool DeleteCraft(T_Crafts craft)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(craft).State = EntityState.Deleted;
                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}