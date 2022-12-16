using EmployeeManagement.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.models
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;

        public InMemoryEmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee() { ID = 1, Name = "Marcus", Department = Department.IT, Email = "marcus@test.com" },
                new Employee() { ID = 2, Name = "Ellen", Department = Department.HR, Email = "ellen@test.com" },
                new Employee() { ID = 3, Name = "Rita", Department = Department.Legal, Email = "rita@test.com" },
                new Employee() { ID = 4, Name = "Peter", Department = Department.Accounting, Email = "peter@test.com" },
                new Employee() { ID = 5, Name = "Jake", Department = Department.Payroll, Email = "jake@test.com" }
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.ID = employees.Max(x => x.ID) + 1;
            employees.Add(employee);
            return employees.LastOrDefault();
        }

        public Employee GetEmployee(int employeeId)
        {
            return employees.Where(x => x.ID == employeeId).SingleOrDefault();
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            return employees;
        }

        public Employee DeleteEmployee(int employeeId)
        {
            var employee = employees.SingleOrDefault(x => x.ID == employeeId);
            if(employee != null)
            {
                employees.Remove(employee);
            }
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var existingEmployee = employees.SingleOrDefault(x => x.ID == employee.ID);
            if (existingEmployee != null)
            {
                var index = employees.IndexOf(existingEmployee);
                employees[index] = employee;
            }
            return employees.Where(x => x.ID == existingEmployee.ID).SingleOrDefault();
        }
    }
}
