using EmployeeManagement.models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.controllers
{
    [Route("Home")]
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [Route("")]
        [Route("/")]
        [Route("Index")]
        //[Route("[action]")]
        public ViewResult Index()
        {
            var model = this.employeeRepository.GetEmployeeList();
            return View(model);
        }

        [Route("Employees")]
        //[Route("[action]")]
        public List<Employee> EmployeeList()
        {
            return this.employeeRepository.GetEmployeeList();
        }

        [Route("Details/{id}")]
        //[Route("[action]/{id}")]
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
