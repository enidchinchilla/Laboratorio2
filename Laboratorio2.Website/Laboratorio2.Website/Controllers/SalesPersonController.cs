using Laboratorio2.Website.Models;
using Laboratorio2.Website.SalesPersonService;
using System.Linq;
using System.Web.Mvc;

namespace Laboratorio2.Website.Controllers
{
    public class SalesPersonController : Controller
    {
        public ActionResult Index()
        {
            return View(new SalesPersonAddressModel());
        }

        [HttpPost]
        public ActionResult Index(SalesPersonAddressModel model)
        {
            var client = new SalesPersonServiceClient();
            var persons = client.GetSalesPersons(model.City, model.Province, model.Country, model.Name).ToList();
            model.Items = persons;
            return View(model);
        }

        public ActionResult Address(string id)
        {
            var model = new SalesPersonAddressModel();
            if (!string.IsNullOrEmpty(id))
            {
                var personID = int.Parse(id);
                if (personID > 0)
                {
                    var client = new SalesPersonServiceClient();
                    var addresses = client.GetAddressesBySalesPersonID(personID).ToList();
                    model.Items = addresses;
                }
            }

            return View(model);
        }
    }
}