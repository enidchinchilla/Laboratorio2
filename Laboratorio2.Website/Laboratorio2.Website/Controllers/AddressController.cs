
using Laboratorio2.Website.Models;
using Laboratorio2.Website.PersonService;
using System.Linq;
using System.Web.Mvc;

namespace Laboratorio2.Website.Controllers
{
    public class AddressController : Controller
    {
        public ActionResult Index(string id)
        {
            var model = new PersonAddressModel();
            if (!string.IsNullOrEmpty(id))
            {
                var personID = int.Parse(id);
                if (personID > 0)
                {
                    var client = new PersonServiceClient();
                    var addresses = client.GetAddressesByPersonID(personID).ToList();
                    model.Items = addresses;
                }
            }

            return View(model);
        }
    }
}