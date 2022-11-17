using EmployeeManagement.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public string Email { get; set; }
    }
}
