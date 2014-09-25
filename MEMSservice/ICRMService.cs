using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MEMSservice.DAL;

namespace MEMSservice
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ICRMService”。
    [ServiceContract]
    public interface ICRMService
    {
        [OperationContract]
        List<T_Customer> getCustomerList();
        [OperationContract]
        List<T_Customer> getCustomerListbyP(string cno, string cname, string csname);
        [OperationContract]
        T_Customer getCustomerbyid(int customerid);
        [OperationContract]
        void AddNewCustomer(T_Customer newcustomer);
        [OperationContract]
        void EditCustomer(T_Customer customer);
        [OperationContract]
        void DeleteCustomer(T_Customer customer);
        [OperationContract]
        List<T_Base_companytype> getCpytypeList();
        [OperationContract]
        List<T_Base_customertype> getCtmtypeList();
        [OperationContract]
        List<T_Base_profession> getProfList();
        [OperationContract]
        List<T_Customer_contacts> getCustomerContactList(int customerid);
        [OperationContract]
        List<T_Customer_address> getCustomerAddressList(int customerid);
        [OperationContract]
        void DelCustomerAddress(T_Customer_address address);
        [OperationContract]
        void DelCustomerContact(T_Customer_contacts contacts);
        [OperationContract]
        void AddCustomerAddress(T_Customer_address address);
        [OperationContract]
        void AddCustomerContact(T_Customer_contacts contacts);
        [OperationContract]
        void UpdCustomerAddress(T_Customer_address address);
        [OperationContract]
        void UpdCustomerContact(T_Customer_contacts contacts);
        [OperationContract]
        List<T_Suppliers> getAllSupplier();
        [OperationContract]
        List<T_Suppliers> getSupplierList(string spno, string spname);
        [OperationContract]
        T_Suppliers getSupplierbyId(int sid);
        [OperationContract]
        void addNewSupplier(T_Suppliers newsupplier);
        [OperationContract]
        void EditSupplier(T_Suppliers supplier);
        [OperationContract]
        void DeleteSupplier(T_Suppliers supplier);
        [OperationContract]
        List<T_Base_suppliertype> getSuptypeLst();
        [OperationContract]
        List<T_Suppliers_contacts> getSupplierContacts(int supplierid);
        [OperationContract]
        void AddSupplierContacts(T_Suppliers_contacts contact);
        [OperationContract]
        void EditSupplierContacts(T_Suppliers_contacts contact);
        [OperationContract]
        void DelSupplierContacts(T_Suppliers_contacts contact);
        [OperationContract]
        List<ProductList> getProductList();
        [OperationContract]
        List<ProductList> getProductListbycdt(string pcode, string pname, string drawingno, int[] cid);
        [OperationContract]
        List<T_ProductType> getProductTypeList();
        [OperationContract]
        T_Product getProductbyId(int pid);
        [OperationContract]
        bool AddNewProduct(T_Product product);
        [OperationContract]
        bool UpdateProduct(T_Product product);
        [OperationContract]
        List<T_Crafts> getProductCraft(int pid);
        [OperationContract]
        bool AddNewCraft(T_Crafts craft);
        [OperationContract]
        bool UpdateCraft(T_Crafts craft);
        [OperationContract]
        bool DeleteCraft(T_Crafts craft);
    }
}
