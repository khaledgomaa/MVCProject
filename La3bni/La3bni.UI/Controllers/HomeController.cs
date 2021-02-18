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
        private readonly ImageManager imageManager;

        public HomeController(ImageManager _imageManager)
        {
            imageManager = _imageManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Playground playground)
        {
            imageManager.UploadFile(playground.ImageFile, "Playgrounds");
            return View();
        }
    }
}