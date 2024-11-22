using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ST10298613_ContractMonthlyClaimSystem.Models;

namespace ST10298613_ContractMonthlyClaimSystem.Controllers
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

        // Action to display the About page
        public IActionResult About()
        {
            ViewData["Title"] = "About";
            ViewData["Message"] = "Welcome to the Contract Monthly Claim System!";
            return View();
        }

        // Action to display the Contact page
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            ViewData["Message"] = "Feel free to reach out to us for any inquiries.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
