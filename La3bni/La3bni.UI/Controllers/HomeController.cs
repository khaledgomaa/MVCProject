using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La3bni.UI.Controllers
{
    public class HomeController : Controller
    {
        public IRepository<Booking> BookingRepo;

        public HomeController(IRepository<Booking> _BookingRepo)
        {
            BookingRepo = _BookingRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}