using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Web;
using MEMSservice.DAL;

namespace MEMSservice.BLL
{
    public class CustomerHelper
    {
        public List<T_Customer> getCustomerAllList()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var clist = from c in db.T_Customer
                            select c;
                return clist.ToList();
            }

        }
        public T_Customer getCustomerByid(int id)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var customer = from c in db.T_Customer
                               where c.id == id
                               select c;
                return customer.First();
            }
        }

        internal void addNewCustomer(T_Customer newcustomer)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.T_Customer.Add(newcustomer);
                db.SaveChanges();
            }
        }

        internal void editCustomer(T_Customer customer)
        {
            using (MEMSEntities db = new MEMSEntities())
            {                
                db.Entry(customer).State = System.Data.EntityState.Modified;  
                db.SaveChanges();
            }
        }
        internal void delCustomer(T_Customer customer)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                //db.T_Customer.Remove(customer);
                var entityentry = db.Entry(customer);
                entityentry.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        internal List<T_Customer> getCustomerList(string cno, string cname, string csname)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var clist = from c in db.T_Customer
                            where c.customerno.Contains(cno) && c.customername.Contains(cname) && c.simplename.Contains(csname)
                            select c;
                return clist.ToList();
            }
        }

        internal List<T_Base_companytype> getComtypLst()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var lst = from c in db.T_Base_companytype
                          select c;
                return lst.ToList();
            }
        }
        internal List<T_Base_customertype> getCusmtypLst()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var lst = from c in db.T_Base_customertype
                          select c;
                return lst.ToList();
            }
        }
        internal List<T_Base_profession> getProfLst()
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var lst = from c in db.T_Base_profession
                          select c;
                return lst.ToList();
            }
        }
        internal List<T_Customer_address> getCustomerAddress(int customerid)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var lst = from a in db.T_Customer_address
                          where a.customerid == customerid
                          select a;
                return lst.ToList();
            }
        }
        internal void DelCustomerAddress(T_Customer_address address)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(address).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        internal void AddCustomerAddress(T_Customer_address address)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.T_Customer_address.Add(address);
                db.SaveChanges();
            }
        }
        internal void UpdateCustomerAddress(T_Customer_address address)
        {
            using (var db = new MEMSEntities())
            {
                db.Entry(address).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        internal List<T_Customer_contacts> getCustomerContacts(int customerid)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                var lst = from a in db.T_Customer_contacts
                          where a.customerid == customerid
                          select a;
                return lst.ToList();
            }
        }
        internal void DelCustomerContacts(T_Customer_contacts contact)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(contact).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        internal void AddCustomerContacts(T_Customer_contacts contact)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.T_Customer_contacts.Add(contact);
                
                db.SaveChanges();
            }
        }
        internal void UpdateCustomerContacts(T_Customer_contacts contact)
        {
            using (MEMSEntities db = new MEMSEntities())
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}