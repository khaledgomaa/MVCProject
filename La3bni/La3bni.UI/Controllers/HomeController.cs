using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace La3bni.UI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}