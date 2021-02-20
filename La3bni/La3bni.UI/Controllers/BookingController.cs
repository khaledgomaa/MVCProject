using Microsoft.AspNetCore.Identity;
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
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public BookingController(IUnitOfWork _unitOfWork,
                                UserManager<ApplicationUser> _userManager,
                                SignInManager<ApplicationUser> _signInManager)
        {
            unitOfWork = _unitOfWork;
            userManager = _userManager;
            signInManager = _signInManager;
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

        public async Task<BookingViewModel> GetBookings(int playGroundId, string date, string timeId)
        {
            //check if user is signed in or not
            string userId = (await userManager.FindByNameAsync("khaledgomaa"))?.Id;

            if (!string.IsNullOrEmpty(userId))
            {
                if (await CheckPlaygroundStatus(playGroundId) == Status.Available)
                {
                    int.TryParse(timeId, out int bookingTimeId);
                    int bookingId = await CheckBookingNotExist(bookingTimeId, userId, date);
                    if (bookingId == 0) //0 means no booking found to this user for this parameters
                    {
                        var bookings = (await unitOfWork.BookingRepo.Find(
                            b => b.PlaygroundId == playGroundId
                            && b.BookedDate.Date == Convert.ToDateTime(date).Date
                            && b.PlaygroundTimesId == int.Parse(timeId)));

                        return (new BookingViewModel
                        {
                            NumOfPlayers = (await unitOfWork.BookingTeamRepo.GetAll())
                                                  .Count(b => b.BookingId == bookings.BookingId),
                            BookingExist = bookings != null,
                            BookingStatus = bookings?.BookingStatus ?? BookingStatus.Public,
                            MaxNumOfPlayers = bookings?.MaxNumOfPlayers ?? 0,
                            BookingId = bookings?.BookingId ?? 0
                        });
                    }

                    return new BookingViewModel
                    {
                        BookingId = bookingId
                    };
                }
                return new BookingViewModel
                {
                    PlaygroundStatus = Status.Busy
                };
            }

            return new BookingViewModel();
        }

        public async Task<int> CheckBookingNotExist(int timeId, string userId, string date)
        {
            return (await unitOfWork.BookingRepo.Find(b => b.ApplicationUserId == userId
                                            && b.BookedDate.Date > DateTime.Now.Date
                                            && b.BookedDate.Date == Convert.ToDateTime(date).Date
                                            && b.PlaygroundTimesId == timeId))?.BookingId ?? 0;
        }

        public IActionResult CreateBooking(string period, int PlaygroundId, string selectedDate, string bookingId)
        {
            //unitOfWork.BookingRepo.Add()
            return RedirectToAction("Index", "Home");
        }

        public IActionResult CancelBooking(string bookingId)
        {
            return View();
        }

        private async Task<Status> CheckPlaygroundStatus(int playgroundId)
        {
            return (await unitOfWork.PlayGroundRepo.Find(b => b.PlaygroundId == playgroundId)).PlaygroundStatus;
        }
    }
}