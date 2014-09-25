using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEMSservice.DAL
{
    public static class MyDBExtensions
    {
        public static void UpdateData(this T_Customer oldcustomer,T_Customer newcustomer)
        {
            try
            {
                //oldcustomer.customerno = oldcustomer.customerno == newcustomer.customerno ? oldcustomer.customerno : newcustomer.customerno;
                if (!oldcustomer.customerno.Equals(newcustomer.customerno))
                    oldcustomer.customerno = newcustomer.customerno;
                if (!oldcustomer.customername.Equals(newcustomer.customername))
                    oldcustomer.customername = newcustomer.customername;
                if (!oldcustomer.simplename.Equals(newcustomer.simplename))
                    oldcustomer.simplename = newcustomer.simplename;
                if (!oldcustomer.accountname.Equals(newcustomer.accountname))
                    oldcustomer.accountname = newcustomer.accountname;
                if (!oldcustomer.accountno.Equals(newcustomer.accountno))
                    oldcustomer.accountno = newcustomer.accountno;
                if (!oldcustomer.bank.Equals(newcustomer.bank))
                    oldcustomer.bank = newcustomer.bank;
                if (!oldcustomer.city.Equals(newcustomer.city))
                    oldcustomer.city = newcustomer.city;
                if (!oldcustomer.companyaddress.Equals(newcustomer.companyaddress))
                    oldcustomer.companyaddress = newcustomer.companyaddress;
                if (oldcustomer.companytype != newcustomer.companytype)
                    oldcustomer.companytype = newcustomer.companytype;
                if (!oldcustomer.country.Equals(newcustomer.country))
                    oldcustomer.country = newcustomer.country;
                if (!oldcustomer.customerdesc.Equals(newcustomer.customerdesc))
                    oldcustomer.customerdesc = newcustomer.customerdesc;
                if (!oldcustomer.email.Equals(newcustomer.email))
                    oldcustomer.email = newcustomer.email;
                if (oldcustomer.customertype != newcustomer.customertype)
                    oldcustomer.customertype = newcustomer.customertype;
                if (!oldcustomer.fax.Equals(newcustomer.fax))
                    oldcustomer.fax = newcustomer.fax;
                if (!oldcustomer.invoiceaddress.Equals(newcustomer.invoiceaddress))
                    oldcustomer.invoiceaddress = newcustomer.invoiceaddress;
                if (!oldcustomer.phone.Equals(newcustomer.phone))
                    oldcustomer.phone = newcustomer.phone;
                if (!oldcustomer.postcode.Equals(newcustomer.postcode))
                    oldcustomer.postcode = newcustomer.postcode;
                if (!oldcustomer.productinfo.Equals(newcustomer.productinfo))
                    oldcustomer.productinfo = newcustomer.productinfo;
                if (oldcustomer.profession != newcustomer.profession)
                    oldcustomer.profession = newcustomer.profession;
                if (!oldcustomer.province.Equals(newcustomer.province))
                    oldcustomer.province = newcustomer.province;
                if (!oldcustomer.remarks.Equals(newcustomer.remarks))
                    oldcustomer.remarks = newcustomer.remarks;
                if (!oldcustomer.source.Equals(newcustomer.source))
                    oldcustomer.source = newcustomer.source;
                if (!oldcustomer.taxcode.Equals(newcustomer.taxcode))
                    oldcustomer.taxcode = newcustomer.taxcode;
                if (!oldcustomer.website.Equals(newcustomer.website))
                    oldcustomer.website = newcustomer.website;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateData(this T_Customer_address newaddress)
        {

        }
    }
}