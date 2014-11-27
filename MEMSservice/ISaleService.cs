using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using MEMS.DB.Models;
using MEMS.DB.ExtModels;

namespace MEMSservice
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISaleService”。
    [ServiceContract]
    public interface ISaleService
    {
        [OperationContract]
        List<SaleOrder> getAllSaleOrderList();
        [OperationContract]
        T_saleorder getSaleOrderbyId(int saleorderid);
        [OperationContract]
        List<SaleOrder> getSaleOrderList(string soNo, DateTime dtstart, DateTime dtend);
        [OperationContract]
        bool AddNewSaleOrder(T_saleorder so);
        [OperationContract]
        bool UpdateSaleOrder(T_saleorder so);
        [OperationContract]
        bool DeleteSaleOrder(T_saleorder so);
        [OperationContract]
        List<T_saledetail> getSaleDetailbysoid(int soid);
    }
}
