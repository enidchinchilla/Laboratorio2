using Laboratorio2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio2.BizLayer
{
    public class EmployeeBL
    {
        public List<EmployeeDepartment> GetDepartments(DateTime? startDate, DateTime? endDate, string departmentName)
        {
            using (var context = new Laboratorio2Entities())
            {
                IQueryable<EmployeeDepartment> query = context.EmployeeDepartments;
                if (startDate.HasValue)
                    query = query.Where(e => e.HireDate >= startDate);
                if (endDate.HasValue)
                    query = query.Where(e => e.HireDate <= endDate);
                if (!string.IsNullOrEmpty(departmentName))
                    query = query.Where(e => e.Name.Contains(departmentName));
                var result = query
                    .GroupBy(x => new { x.DepartmentID, x.Name, x.GroupName })
                    .Select(x => new
                    {
                        DepartmentID = x.Key.DepartmentID,
                        Name = x.Key.Name,
                        GroupName = x.Key.GroupName
                    })
                    .ToList()
                    .Select(x => new EmployeeDepartment
                    {
                        DepartmentID = x.DepartmentID,
                        Name = x.Name,
                        GroupName = x.GroupName
                    });
                return result.ToList();
            }
        }

        public List<EmployeeDepartment> GetEmployeesByDepartmentID(short departmentID)
        {
            using (var context = new Laboratorio2Entities())
            {
                return context.EmployeeDepartments.Where(e => e.DepartmentID == departmentID).ToList();
            }
        }
    }
}