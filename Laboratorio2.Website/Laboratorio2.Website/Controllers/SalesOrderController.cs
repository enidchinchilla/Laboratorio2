using Laboratorio2.Website.Models;
using Laboratorio2.Website.SalesOrderService;
using System.Web.Mvc;
using System.Linq;

namespace Laboratorio2.Website.Controllers
{
    public class SalesOrderController : Controller
    {
        public ActionResult Index()
        {
            return View(new SalesOrderModel());
        }

        [HttpPost]
        public ActionResult Index(SalesOrderModel model)
        {
            var client = new SalesOrderServiceClient();
            var sales = client.GetSales(model.StartDate, model.EndDate, model.Name).ToList();
            model.Items = sales;
            return View(model);
        }

        public ActionResult Detail(string id)
        {
            var model = new SalesOrderModel();
            if (!string.IsNullOrEmpty(id))
            {
                var salesOrderID = int.Parse(id);
                if (salesOrderID > 0)
                {
                    var client = new SalesOrderServiceClient();
                    var orderDetails = client.GetSalesOrderDetailBySalesOrderID(salesOrderID).ToList();
                    model.Items = orderDetails;
                }
            }

            return View(model);
        }
    }
}