using Laboratorio2.BizLayer;
using Laboratorio2.DataAccess;
using System;
using System.Collections.Generic;

namespace Laboratorio2.WCFLayer
{
    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeDepartment> GetEmployeeDepartments(DateTime? startDate, DateTime? endDate, string departmentName)
        {
            var employeeBL = new EmployeeBL();
            return employeeBL.GetEmployeeDepartments(startDate,endDate,departmentName);
        }
    }
}
