using DotNetcoreFirst1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetcoreFirst1.Controllers
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
            ViewBag.Test = "Md Asfaque Ansari";
            ViewBag.Test1 = 1854;
            ViewBag.Test2 = 124.2f;
            ViewBag.Test3 = DateTime.Now;
            ViewBag.Test4 = new List<string>()
            {
                "India",
                    "Saudi",
                    "US"
            };


            ViewData["A"] = "Sourav Nainval";
            ViewData["B"] = 4527;
            ViewData["C"] = 452.4f;
            ViewData["D"] = DateTime.Now;
            ViewData["E"] = new List<int>()
            {
               1247,
                7621,
                4587
            };


            TempData["1"] = " Altaf";
            TempData["2"] = 4521;
            TempData["3"] = 14.24f;
            TempData["4"] = DateTime.Now;
            TempData["5"] = new List<char>()
            {
              'A',
            'B',
            'C'
            };

            HttpContext.Session.SetString("Sess", "Md Asfaque");
            ViewBag.session = HttpContext.Session.GetString("Sess");


            HttpContext.Session.SetString("Sess1", "Sourav");
            ViewBag.session = HttpContext.Session.GetString("Sess1");
            // var session = HttpContext.Session.GetString("Sess");

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
