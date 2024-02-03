using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaludMental.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SaludMental.Controllers
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

        [HttpGet]
        public IActionResult PrimeraNecesidad()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetImage()
        {
            var imagePath = "../Images/Necesidad3.jpg";
            return File(imagePath, "image/jpeg");
        }

        [HttpGet]
        public IActionResult SegundaNecesidad()
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
