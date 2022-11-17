﻿using EmployeeManagement.Models.Enums;
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
                new Employee() { ID = 1, Name = "Marcus", Department = Department.IT, Email = "marcus@test.com" },
                new Employee() { ID = 2, Name = "Ellen", Department = Department.HR, Email = "ellen@test.com" },
                new Employee() { ID = 3, Name = "Rita", Department = Department.Legal, Email = "rita@test.com" },
                new Employee() { ID = 4, Name = "Peter", Department = Department.Accounting, Email = "peter@test.com" },
                new Employee() { ID = 5, Name = "Jake", Department = Department.Payroll, Email = "jake@test.com" }
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
