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

        public IActionResult Widgets()
        {
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }


        public IActionResult Buttons(string id = "buttons")
        {
            string viewName = $"Buttons/{id}";
            return View(viewName);
        }

        public IActionResult Components(string id = "cards")
        {
            string viewName = $"Base/{id}";

            return View(viewName);
        }

        public IActionResult Icons(string id = "simple-line-icons")
        {
            string viewName = $"Icons/{id}";

            return View(viewName);
        }

        public IActionResult Notifications(string id = "alerts")
        {
            string viewName = $"Notifications/{id}";

            return View(viewName);
        }

        public IActionResult Pages(string id = "login")
        {
            string viewName = $"Pages/{id}";

            return View(viewName);
        }

        public IActionResult Theme(string id = "colors")
        {
            string viewName = $"Theme/{id}";
            return View(viewName);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}