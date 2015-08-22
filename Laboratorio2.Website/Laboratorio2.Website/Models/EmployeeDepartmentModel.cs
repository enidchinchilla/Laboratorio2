using Laboratorio2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2.Website.Models
{
    public class DepartmentEmployeeModel
    {
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public List<EmployeeDepartment> Items { get; set; } 
    }
}