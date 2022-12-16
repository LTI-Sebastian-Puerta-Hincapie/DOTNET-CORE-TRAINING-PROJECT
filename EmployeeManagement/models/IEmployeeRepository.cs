using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployeeList();
        Employee GetEmployee(int employeeId);
        Employee AddEmployee(Employee Employee);
        Employee UpdateEmployee(Employee Employee);
        Employee DeleteEmployee(int employeeId);
    }
}
