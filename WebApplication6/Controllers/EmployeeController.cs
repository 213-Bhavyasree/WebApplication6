using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 414, FirstName = "Bhavya", LastName = "Sree"});
            employees.Add(new Employee() { ID = 415, FirstName = "Jaya", LastName = "Sree"});
            employees.Add(new Employee() { ID = 416, FirstName = "Vali", LastName = "s"});

            ViewData["employees"] = employees;

            return View();
        }
    }
}
