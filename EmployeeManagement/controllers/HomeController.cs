using EmployeeManagement.models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.controllers
{
    //[Route("Home")]
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        //[Route("")]
        //[Route("/")]
        //[Route("Index")]
        //[Route("[action]")]
        public ViewResult Index()
        {
            var model = employeeRepository.GetEmployeeList();
            return View(model);
        }

        //[Route("Employees")]
        //[Route("[action]")]
        public IEnumerable<Employee> EmployeeList()
        {
            return employeeRepository.GetEmployeeList();
        }

        //[Route("Details/{id}")]
        //[Route("[action]/{id}")]
        public ViewResult Details(int? id)
        {
            Employee model = employeeRepository.GetEmployee(id ?? 1);
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = model,
                PageTitle = "Employee Details"
            
            };
            return View(homeDetailsViewModel);
        }

        //[Route("Create")]
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                var newEmployee = employeeRepository.AddEmployee(employee);
                //return RedirectToAction("details", new { id = newEmployee.ID });
            }
            return View();
        }
    }
}
