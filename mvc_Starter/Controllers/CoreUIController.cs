using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CoreUIStatic.Models;


namespace CoreUIStatic.Controllers
{

    public class CoreUIController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}