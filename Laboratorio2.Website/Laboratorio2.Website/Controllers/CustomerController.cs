using Laboratorio2.Website.CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio2.Website.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Address()
        {
            var client = new CustomerServiceClient();
            var result = client.GetData(1);
            return View();
        }
    }
}