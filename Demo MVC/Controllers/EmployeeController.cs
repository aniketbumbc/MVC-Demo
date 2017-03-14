using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_MVC.Models;

namespace Demo_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext empcontext = new EmployeeContext();
           List <Employee> employees = empcontext.Employess.ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext empcontext = new EmployeeContext();
            Employee employee = empcontext.Employess.Single(emp => emp.id == id); 
                return View(employee);
        }
        
    }
}