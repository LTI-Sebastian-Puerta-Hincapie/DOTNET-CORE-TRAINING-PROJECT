using EmployeeManagement.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext db;
        public SQLEmployeeRepository(AppDbContext db)
        {
            this.db = db;
        }

        public Employee AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int employeeId)
        {
            var employee = db.Employees.Find(employeeId);
            if(employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
            return employee; 
        }

        public Employee GetEmployee(int employeeId)
        {
            return db.Employees.Find(employeeId);
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            return db.Employees;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var existingEmployee = db.Employees.Attach(employee);
            existingEmployee.State = EntityState.Modified;
            db.SaveChanges();
            return employee;
        }
    }
}
