using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class MainController : Controller
    {
        // simple view to display the hello message
        public ActionResult Index()
        {
            return View();
        }
    }
}