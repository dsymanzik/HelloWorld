using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.API.Controllers
{
    //This is the controller for the main page which will display the 10x hello worlds

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}