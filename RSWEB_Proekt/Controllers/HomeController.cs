using Microsoft.AspNetCore.Mvc;
using RSWEB_Proekt.Models;
using System.Diagnostics;

namespace RSWEB_Proekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Predmets()
        {
            return View();
        }

        public IActionResult EditPredmet()
        {
            return View();
        }

        public IActionResult CreatePredmet()
        {
            return View();
        }

        public IActionResult DetailsPredmet()
        {
            return View();
        }

        public IActionResult DeletePredmet()
        {
            return View();
        }
        public IActionResult Index()
        {
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
