using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System.Collections.Generic;

namespace La3bni.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ImageManager imageManager;
        private readonly IUnitOfWork unitOfwork;

        public HomeController(ImageManager _imageManager, IUnitOfWork unitOfwork)
        {
            imageManager = _imageManager;
            this.unitOfwork = unitOfwork;
        }


        public IActionResult GetInTouch(Email email)
        {
            EmailService.sendEmail(
                "La3bniKoora buiseness",
                 email.Message + "\n\nFrom : " + email.Name + "\n" + email.UserEmail,
                 new List<string>() { "mohmedshawky2019@gmail.com" });

            //EmailService.sendEmail(
            //    "La3bniKoora Business ",
            //    "Advertise with Playground We are planning for another great year as your go - to resource for information on play structures," +
            //    " amenities, industry trends, and lifestyle impacts.Each month we reach tens of thousands of readers around the world with valuable information about playground safety," +
            //    " fundraising for park projects, tips on children's development, and many other topics. We also provide the Professional Spotlight Directory as a means for people to connect" +
            //    " with your business for all their play and playground needs." +
            //    "The emails to our subscribers provide some of the best exposure in the industry.We highlight the weekly original content on our site as well as the in-depth articles in our quarterly magazine." +
            //    "Potential customers will see your ads in the emails, on the website, and in the digital magazine.We continue to bring you an incredible advertising value." +
            //    "Please investigate the advertising opportunities in this media guide and contact us to explore which one is right for you." +
            //    "Thank you for your interest in advertising with Playground Professionals, where we are always thinking today about tomorrow's play."+
            //    "\n\n\nThanks for your support :) \n\nTest Test :D ",
            //    unitOfwork.SubscriberRepo.GetAll().Result.Select(email=>email.Email).ToList());
            return View("Index");
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