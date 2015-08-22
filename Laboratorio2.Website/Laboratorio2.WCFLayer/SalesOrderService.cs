
using Laboratorio2.BizLayer;
using System;
using System.Collections.Generic;
namespace Laboratorio2.WCFLayer
{
    public class SalesOrderService : ISalesOrderService
    {
        public List<DataAccess.SalesOrder> GetSales(DateTime? startDate, DateTime? endDate, string productName)
        {
            return new SalesOrderBL().GetSales(startDate, endDate, productName);
        }

        public List<DataAccess.SalesOrder> GetSalesOrderDetailBySalesOrderID(int salesOrderID)
        {
            return new SalesOrderBL().GetSalesOrderDetailBySalesOrderID(salesOrderID);
        }
    }
}
