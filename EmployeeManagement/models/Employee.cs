using EmployeeManagement.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name exceeds 50 character limit")]
        public string Name { get; set; }
        [Required]
        public Department? Department { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9]+\.[a-zA-Z0-9-.]+$",  ErrorMessage="Invalid Email Format")]
        [Display(Name = "Work Email")]
        public string Email { get; set; }
    }
}
