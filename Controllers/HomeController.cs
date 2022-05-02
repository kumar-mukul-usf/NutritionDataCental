using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NutritionDataCental.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionDataCental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult main()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SearchResult()
        {
           
            return View();
        }


            public IActionResult Stats()
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
