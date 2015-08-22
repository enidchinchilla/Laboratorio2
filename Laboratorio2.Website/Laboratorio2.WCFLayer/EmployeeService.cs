using Laboratorio2.BizLayer;
using Laboratorio2.DataAccess;
using System;
using System.Collections.Generic;

namespace Laboratorio2.WCFLayer
{
    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeDepartment> GetDepartments(DateTime? startDate, DateTime? endDate, string departmentName)
        {
            return new EmployeeBL().GetDepartments(startDate,endDate,departmentName);
        }

        public List<EmployeeDepartment> GetEmployeesByDepartmentID(short departmentID)
        {
            return new EmployeeBL().GetEmployeesByDepartmentID(departmentID);
        }
    }
}
