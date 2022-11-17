using EmployeeManagement.models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            var model = this.employeeRepository.GetEmployeeList();
            return View(model);
        }

        public List<Employee> EmployeeList()
        {
            return this.employeeRepository.GetEmployeeList();
        }

        public ViewResult Details(int id)
        {
            Employee model = this.employeeRepository.GetEmployee(id);
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = model,
                PageTitle = "Employee Details"
            
            };
            return View(homeDetailsViewModel);
        }
    }
}
