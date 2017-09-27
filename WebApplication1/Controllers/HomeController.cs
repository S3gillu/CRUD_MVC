using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> shu;
        public HomeController()
        {
            shu = new List<Employee>()
            {
                new Employee()
            { EmployeeId = 1 , FirstName="Shubham",LastName="Saurabh", Email="shubhamsaurabh@gmail.com" },
            new Employee()
            { EmployeeId = 2 , FirstName="Mayank",LastName="Joshi", Email="mayankjoshi@gmail.com" },
            new Employee()
            { EmployeeId = 3 , FirstName="Aman",LastName="Mian", Email="amanmian@yahoo.com" },
            new Employee()
            { EmployeeId = 4 , FirstName="Praveen",LastName="Bhatt", Email="praveenbhatt@gmail.com" },
            new Employee()
            { EmployeeId = 5 , FirstName="Aniket",LastName="kadu", Email="aniketkadu@gmail.com"},

            };
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(shu);
        }
    }
}