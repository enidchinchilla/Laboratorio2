using Laboratorio2.BizLayer;
using Laboratorio2.DataAccess;
using System.Collections.Generic;

namespace Laboratorio2.WCFLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeDepartment> GetAll()
        {
            var employeeBL = new EmployeeBL();
            return employeeBL.GetEmployeeDepartments(1);
        }
    }
}
