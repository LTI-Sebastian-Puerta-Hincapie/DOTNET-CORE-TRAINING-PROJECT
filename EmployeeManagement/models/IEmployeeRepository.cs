using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployeeList();
        Employee GetEmployee(int employeeId);
    }
}
