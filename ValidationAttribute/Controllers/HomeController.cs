using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationAttribute.Models;

namespace ValidationAttribute.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student std)
        {

        
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }
            // Model state
            //if (ModelState.IsValid) { 
            //return "Name is" + std.Name;
            //}
            //else
            //{
            //    return "Validation FAILED";
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
