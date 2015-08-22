using Laboratorio2.DataAccess;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Laboratorio2.WCFLayer
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        List<EmployeeDepartment> GetDepartments(DateTime? startDate, DateTime? endDate, string departmentName);

        [OperationContract]
        List<EmployeeDepartment> GetEmployeesByDepartmentID(short departmentID);
    }
}