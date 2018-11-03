using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ooui.AspNetCore;
using Xamarin.Forms;
using XFChallenge.Web.Models;

namespace XFChallenge.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var page = new MainPage();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Xamarin Forms Challenge");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "The Xamarin Forms Challenge from GSCC 2018";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
