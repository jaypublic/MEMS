using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MEMSservice.DAL;
using MEMSservice.BLL;

namespace MEMSservice
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“CRMService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 CRMService.svc 或 CRMService.svc.cs，然后开始调试。
    public class CRMService : ICRMService
    {
        CustomerHelper ch;
        SupplierHelper sh;
        ProductHelper ph;
        public List<T_Customer> getCustomerList()
        {
            try
            {
                ch = new CustomerHelper();
                List<T_Customer> clist = ch.getCustomerAllList();
                return clist;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<T_Customer> getCustomerListbyP(string cno, string cname, string csname)
        {
            try
            {
                ch = new CustomerHelper();
                List<T_Customer> clist = ch.getCustomerList(cno, cname, csname);
                return clist;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public T_Customer getCustomerbyid(int customerid)
        {
            try
            {
                ch = new CustomerHelper();
                var customer = ch.getCustomerByid(customerid);
                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddNewCustomer(T_Customer newcustomer)
        {
            try
            {
                ch = new CustomerHelper();
                ch.addNewCustomer(newcustomer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditCustomer(T_Customer customer)
        {
            try
            {
                ch = new CustomerHelper();
                ch.editCustomer(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteCustomer(T_Customer customer)
        {
            try
            {
                ch = new CustomerHelper();
                ch.delCustomer(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T_Base_companytype> getCpytypeList()
        {
            try
            {
                ch = new CustomerHelper();
                var lst = ch.getComtypLst();
                return lst;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<T_Base_customertype> getCtmtypeList()
        {
            try
            {
                ch = new CustomerHelper();
                var lst = ch.getCusmtypLst();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<T_Base_profession> getProfList()
        {
            try
            {
                ch = new CustomerHelper();
                var lst = ch.getProfLst();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T_Customer_address> getCustomerAddressList(int customerid)
        {
            try
            {
                ch = new CustomerHelper();
                var lst = ch.getCustomerAddress(customerid);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T_Customer_contacts> getCustomerContactList(int customerid)
        {
            try
            {
                ch = new CustomerHelper();
                var lst = ch.getCustomerContacts(customerid);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DelCustomerAddress(T_Customer_address address)
        {
            try
            {
                ch = new CustomerHelper();
                ch.DelCustomerAddress(address);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DelCustomerContact(T_Customer_contacts contacts)
        {
            try
            {
                ch = new CustomerHelper();
                ch.DelCustomerContacts(contacts);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddCustomerAddress(T_Customer_address address)
        {
            try
            {
                ch = new CustomerHelper();
                ch.AddCustomerAddress(address);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddCustomerContact(T_Customer_contacts contacts)
        {
            try
            {
                ch = new CustomerHelper();
                ch.AddCustomerContacts(contacts);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdCustomerAddress(T_Customer_address address)
        {
            try
            {
                ch = new CustomerHelper();
                ch.UpdateCustomerAddress(address);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdCustomerContact(T_Customer_contacts contacts)
        {
            try
            {
                ch = new CustomerHelper();
                ch.UpdateCustomerContacts(contacts);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T_Suppliers> getAllSupplier()
        {
            try
            {
                sh = new SupplierHelper();
                return sh.getSupplierList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T_Suppliers> getSupplierList(string spno, string spname)
        {
            sh = new SupplierHelper();
            return sh.getSupplierList(spno, spname);
        }
        public T_Suppliers getSupplierbyId(int sid)
        {
            try
            {
                sh = new SupplierHelper();
                return sh.getSupplierbyId(sid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void addNewSupplier(T_Suppliers newsupplier)
        {
            try
            {
                sh = new SupplierHelper();
                sh.addNewSupplier(newsupplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditSupplier(T_Suppliers supplier)
        {
            try
            {
                sh = new SupplierHelper();
                sh.updateSupplier(supplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteSupplier(T_Suppliers supplier)
        {
            try
            {
                sh = new SupplierHelper();
                sh.delSupplier(supplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T_Base_suppliertype> getSuptypeLst()
        {
            try
            {
                sh = new SupplierHelper();
                return sh.getSuptypLst();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<T_Suppliers_contacts> getSupplierContacts(int supplierid)
        {
            try
            {
                sh = new SupplierHelper();
                return sh.getSupplierContacts(supplierid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddSupplierContacts(T_Suppliers_contacts contact)
        {
            try
            {
                sh = new SupplierHelper();
                sh.AddSupplierContacts(contact);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditSupplierContacts(T_Suppliers_contacts contact)
        {
            try
            {
                sh = new SupplierHelper();
                sh.UpdateSupplierContacts(contact);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DelSupplierContacts(T_Suppliers_contacts contact)
        {
            try
            {
                sh = new SupplierHelper();
                sh.DelSupplierContacts(contact);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ProductList> getProductList()
        {
            try
            {
                ph = new ProductHelper();
                var lst = ph.getProductLst();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ProductList> getProductListbycdt(string pcode,string pname,string drawingno,int[] cid)
        {
            ph = new ProductHelper();
            var lst = ph.getProductLstbyCdt(pcode, pname, drawingno, cid);
            return lst;
        }
        public List<T_ProductType> getProductTypeList()
        {
            try
            {
                ph = new ProductHelper();
                return ph.getPtypelst();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public T_Product getProductbyId(int pid)
        {
            try
            {
                ph = new ProductHelper();
                return ph.getProductbyId(pid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddNewProduct(T_Product product)
        {
            try
            {
                ph = new ProductHelper();
                return ph.AddNewProduct(product);
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        public bool UpdateProduct(T_Product product)
        {
            try
            {
                ph = new ProductHelper();
                return ph.UpdateProduct(product);
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        public List<T_Crafts> getProductCraft(int pid)
        {
            ph = new ProductHelper();
            return ph.getProCraft(pid);
        }
        public bool AddNewCraft(T_Crafts craft)
        {
            try
            {
                ph = new ProductHelper();
                return ph.AddNewCraft(craft);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool UpdateCraft(T_Crafts craft)
        {
            try
            {
                ph = new ProductHelper();
                return ph.UpdateCraft(craft);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool DeleteCraft(T_Crafts craft)
        {
            try
            {
                ph = new ProductHelper();
                return ph.DeleteCraft(craft);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
