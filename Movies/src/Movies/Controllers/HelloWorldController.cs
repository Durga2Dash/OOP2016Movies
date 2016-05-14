using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Movies.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index() // IActionResult string
        {
            return View();
            // return "Hello World!";
        }

        public IActionResult  Welcome(string name, int numTimes = 0) // string
        {
            // return String.Format("Welcome {0}! numTimes = {1}", name, numTimes);
            ViewBag.name = name;
            ViewBag.numTimes = numTimes;
            return View();
        }
    }
}

