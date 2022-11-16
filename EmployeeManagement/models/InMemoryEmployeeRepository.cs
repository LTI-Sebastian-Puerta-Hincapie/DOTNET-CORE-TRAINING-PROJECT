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
            this.employees = new List<Employee>()
            {
                new Employee() { ID = 1, Name = "Marcus", Department = "IT", Email = "marcus@test.com" },
                new Employee() { ID = 2, Name = "Ellen", Department = "HR", Email = "marcus@test.com" },
                new Employee() { ID = 3, Name = "Rita", Department = "Legal", Email = "marcus@test.com" },
                new Employee() { ID = 4, Name = "Peter", Department = "Accounting", Email = "marcus@test.com" }
            };
        }

        public Employee GetEmployee(int employeeId)
        {
            return this.employees.Where(x => x.ID == employeeId).SingleOrDefault();
        }

        public List<Employee> GetEmployeeList()
        {
            return this.employees;
        }
    }
}
