using Laboratorio2.Website.Models;
using Laboratorio2.Website.PersonService;
using System.Linq;
using System.Web.Mvc;

namespace Laboratorio2.Website.Controllers
{
    public class SalesPersonController : Controller
    {
        public ActionResult Index()
        {
            return View(new PersonAddressModel());
        }

        [HttpPost]
        public ActionResult Index(PersonAddressModel model)
        {
            var client = new PersonServiceClient();
            var persons = client.GetPersons(1, model.City, model.Province, model.Country, model.Name).ToList();
            model.Items = persons;
            return View(model);
        }

    }
}