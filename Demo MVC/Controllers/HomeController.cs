using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Demo_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Coutries=new List<string>()
            {
                "India",
                "USA",
                "UK"
            };

            ViewData["Student"] = new List<string>()
            {
                "aniket",
                "mandar",
                "suyash"

            };

            return View();
        }      
        
        public string Getinfo()
        {
            return "Hello from Getinfo";
        }
    }
}