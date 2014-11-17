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
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SaleService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 SaleService.svc 或 SaleService.svc.cs，然后开始调试。
    public class SaleService : ISaleService
    {
        SaleHelper m_sh;
        public List<T_saleorder> getAllSaleOrderList()
        {
            try
            {
                m_sh = new SaleHelper();
                return m_sh.getAllSaleOrderList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public T_saleorder getSaleOrderbyId(int saleorderid)
        {
            m_sh = new SaleHelper();
            return m_sh.getSaleOrderbyId(saleorderid);
        }
    }
}
