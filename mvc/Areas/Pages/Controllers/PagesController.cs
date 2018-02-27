using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreUIStatic.Models;

namespace CoreUIStatic.Controllers
{
    [Area("Pages")]
    public class PagesController : Controller
    {

        public IActionResult Index()
        {
            return View("_404");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult _404()
        {
            return View();
        }

        public IActionResult _500()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
