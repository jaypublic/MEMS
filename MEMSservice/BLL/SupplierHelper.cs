using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Web;
using MEMSservice.DAL;

namespace MEMSservice.BLL
{
    public class SupplierHelper
    {
        public List<T_Suppliers> getSupplierList()
        {
            using (var db = new MEMSEntities())
            {
                var rst = from s in db.T_Suppliers
                          select s;
                          //select new { s.id, s.supplierno, s.suppliername, s.suppliertype, s.simplename, s.country, s.province, s.city };
                return rst.ToList();
            }
        }
        public List<T_Suppliers> getSupplierList(string sno,string sname)
        {
            using (var db = new MEMSEntities())
            {
                var rst = from s in db.T_Suppliers
                          where s.supplierno.Contains(sno) && s.suppliername.Contains(sname)
                          select s;
                return rst.ToList();
            }
        }
        public T_Suppliers getSupplierbyId(int id)
        {
            using (var db = new MEMSEntities())
            {
                var rst = from s in db.T_Suppliers
                          where s.id == id
                          select s;
                return rst.FirstOrDefault();
            }
        }
        internal void addNewSupplier(T_Suppliers newsupplier)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.T_Suppliers.Add(newsupplier);
                db.SaveChanges();
            }
        }

        internal void updateSupplier(T_Suppliers supplier)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(supplier).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
        }
        internal void delSupplier(T_Suppliers supplier)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                //db.T_Customer.Remove(customer);
                var entityentry = db.Entry(supplier);
                entityentry.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        internal List<T_Base_suppliertype> getSuptypLst()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var lst = from c in db.T_Base_suppliertype
                          select c;
                return lst.ToList();
            }
        }
        internal List<T_Suppliers_contacts> getSupplierContacts(int supplierid)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var lst = from a in db.T_Suppliers_contacts
                          where a.supplierid == supplierid
                          select a;
                return lst.ToList();
            }
        }
        internal void DelSupplierContacts(T_Suppliers_contacts contact)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(contact).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        internal void AddSupplierContacts(T_Suppliers_contacts contact)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.T_Suppliers_contacts.Add(contact);

                db.SaveChanges();
            }
        }
        internal void UpdateSupplierContacts(T_Suppliers_contacts contact)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}