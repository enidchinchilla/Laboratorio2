using Laboratorio2.Website.EmployeeService;
using Laboratorio2.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio2.Website.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            return View(new DepartmentEmployeeModel());
        }

        [HttpPost]
        public ActionResult Index(DepartmentEmployeeModel model)
        {
            var client = new EmployeeServiceClient();
            var departments = client.GetDepartments(model.StartDate, model.EndDate, model.Name).ToList();
            model.Items = departments;
            return View(model);
        }

        public ActionResult Employee(string id)
        {
            var model = new DepartmentEmployeeModel();
            if (!string.IsNullOrEmpty(id))
            {
                var departmentID = short.Parse(id);
                if (departmentID > 0)
                {
                    var client = new EmployeeServiceClient();
                    var departments = client.GetEmployeesByDepartmentID(departmentID).ToList();
                    model.Items = departments;
                }
            }

            return View(model);
        }
    }
}