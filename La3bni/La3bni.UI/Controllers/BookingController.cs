using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ViewModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La3bni.UI.Controllers
{
    public class BookingController : Controller
    {
        private IUnitOfWork unitOfWork;

        public BookingController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        [Route("Booking/{playGroundId}")]
        public async Task<IActionResult> Index(int playGroundId)
        {
            Playground playGround = await unitOfWork.PlayGroundRepo.Find(p => p.PlaygroundId == playGroundId);
            List<PlaygroundTimes> times = (await unitOfWork.PlaygroundTimesRepo.GetAll())
                                        .Where(t => t.PlaygroundId == playGroundId)
                                        .ToList();

            ViewBag.times = times.Select(a => new PlayGroundTimesViewModel
            {
                Time = $"{a.From:HH:mm} - {a.To:HH:mm} {a.State}",
                Id = a.PlaygroundTimesId
            }).ToList();

            return View(playGround);
        }

        public async Task<List<Booking>> GetBookings(int playGroundId, string date, string timeId)
        {
            return (await unitOfWork.BookingRepo.GetAll())
                    .Where(b => b.PlaygroundId == playGroundId
                    && b.BookedDate.Date == Convert.ToDateTime(date).Date
                    && b.PlaygroundTimesId == int.Parse(timeId)).ToList();
        }

        public IActionResult CreateBooking(string period, int PlaygroundId, DateTime selectedDate, string check)
        {
            return View();
        }
    }
}