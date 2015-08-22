using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Laboratorio2.WCFLayer
{
    [ServiceContract]
    public interface ISalesOrderService
    {
        [OperationContract]
        List<DataAccess.SalesOrder> GetSales(DateTime? startDate, DateTime? endDate, string productName);

        [OperationContract]
        List<DataAccess.SalesOrder> GetSalesOrderDetailBySalesOrderID(int salesOrderID);
    }

}
