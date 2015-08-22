using Laboratorio2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.BizLayer
{
    public class SalesOrderBL
    {
        public List<SalesOrder> GetSales(DateTime? startDate, DateTime? endDate, string productName)
        {
            using (var context = new Laboratorio2Entities())
            {
                IQueryable<SalesOrder> query = context.SalesOrders;
                if (startDate.HasValue)
                    query = query.Where(e => e.OrderDate >= startDate);
                if (endDate.HasValue)
                    query = query.Where(e => e.OrderDate <= endDate);
                if (!string.IsNullOrEmpty(productName))
                    query = query.Where(e => e.Name.Contains(productName));
                var result = query
                    .GroupBy(x => new
                    {
                        x.SalesOrderID,
                        x.SalesOrderNumber,
                        x.PurchaseOrderNumber,
                        x.OrderDate,
                        x.Status,
                        x.TotalDue,
                        x.Name
                    })
                    .Select(x => new
                    {
                        SalesOrderID = x.Key.SalesOrderID,
                        SalesOrderNumber = x.Key.SalesOrderNumber,
                        PurchaseOrderNumber = x.Key.PurchaseOrderNumber,
                        OrderDate = x.Key.OrderDate,
                        Status = x.Key.Status,
                        TotalDue = x.Key.TotalDue,
                        Name = x.Key.Name
                    })
                    .ToList()
                    .Select(x => new SalesOrder
                    {
                        SalesOrderID = x.SalesOrderID,
                        SalesOrderNumber = x.SalesOrderNumber,
                        PurchaseOrderNumber = x.PurchaseOrderNumber,
                        OrderDate = x.OrderDate,
                        Status = x.Status,
                        TotalDue = x.TotalDue,
                        Name = x.Name
                    });
                return result.ToList();
            }
        }

        public List<SalesOrder> GetSalesOrderDetailBySalesOrderID(int salesOrderID)
        {
            using (var context = new Laboratorio2Entities())
            {
                return context.SalesOrders.Where(e => e.SalesOrderID == salesOrderID).ToList();
            }
        }
    }
}
