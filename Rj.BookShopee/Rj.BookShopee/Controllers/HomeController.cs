using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rj.BookShopee.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
