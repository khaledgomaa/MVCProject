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

        [Route("Booking/{id}")]
        [Route("Booking/Index/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            Playground playGround = await unitOfWork.PlayGroundRepo.Find(p => p.PlaygroundId == id);
            List<PlaygroundTimes> times = (await unitOfWork.PlaygroundTimesRepo.GetAll())
                                        .Where(t => t.PlaygroundId == id)
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
                    int bookingId = await CheckBookingNotExist(playGroundId, bookingTimeId, userId, date);
                    if (bookingId == 0) //0 means no booking found to this user for this parameters
                    {
                        var bookings = (await unitOfWork.BookingRepo.Find(
                            b => b.PlaygroundId == playGroundId
                            && b.BookedDate.Date >= DateTime.Now.Date
                            && b.BookedDate.Date == Convert.ToDateTime(date).Date
                            && b.PlaygroundTimesId == int.Parse(timeId)));

                        if (!string.IsNullOrEmpty(bookings?.ApplicationUserId)
                            && await CheckJoinedTeam(bookings.BookingId) != 0)
                            return new BookingViewModel
                            {
                                BookingId = bookings.BookingId,
                                BookingOwner = false
                            };

                        return (new BookingViewModel
                        {
                            NumOfPlayers = (await unitOfWork.BookingTeamRepo.GetAll())
                                                  .Count(b => b.BookingId == bookings?.BookingId),
                            BookingExist = bookings != null,
                            BookingStatus = bookings?.BookingStatus ?? BookingStatus.Public,
                            MaxNumOfPlayers = bookings?.MaxNumOfPlayers ?? 0,
                            BookingId = bookings?.BookingId ?? 0
                        });
                    }

                    return new BookingViewModel
                    {
                        BookingId = bookingId,
                        BookingOwner = true
                    };
                }
                return new BookingViewModel
                {
                    PlaygroundStatus = Status.Busy
                };
            }

            return new BookingViewModel();
        }

        public async Task<int> CheckBookingNotExist(int playgroundId, int timeId, string userId, string date)
        {
            return (await unitOfWork.BookingRepo.Find(b => b.ApplicationUserId == userId
                                            && b.PlaygroundId == playgroundId
                                            && b.BookedDate.Date >= DateTime.Now.Date
                                            && b.BookedDate.Date == Convert.ToDateTime(date).Date
                                            && b.PlaygroundTimesId == timeId))?.BookingId ?? 0;
        }

        private async Task<int> CheckJoinedTeam(int bookingId)
        {
            return (await unitOfWork.BookingTeamRepo.Find(b => b.BookingId == bookingId))?.BookingId ?? 0;
        }

        public async Task<IActionResult> CreateBooking(string period, int PlaygroundId, string selectedDate, string numOfPlayers)
        {
            if (int.TryParse(period, out int timeId) && int.TryParse(numOfPlayers, out int playersNo))
            {
                unitOfWork.BookingRepo.Add(new Booking
                {
                    ApplicationUserId = (await userManager.FindByNameAsync("khaledgomaa"))?.Id,
                    BookingStatus = BookingStatus.Public,
                    BookedDate = Convert.ToDateTime(selectedDate),
                    PlaygroundTimesId = timeId,
                    PlaygroundId = PlaygroundId,
                    MaxNumOfPlayers = playersNo,
                    Price = (await unitOfWork.PlayGroundRepo.Find(p => p.PlaygroundId == PlaygroundId))?.AmPrice ?? 0
                });
                unitOfWork.Save();
            }
            return Json(new { redirectToUrl = Url.Action("", "Home") });
        }

        public async Task<IActionResult> JoinTeam(string bookingId)
        {
            if (int.TryParse(bookingId, out int bookId))
            {
                unitOfWork.BookingTeamRepo.Add(new BookingTeam
                {
                    BookingId = bookId,
                    ApplicationUserId = (await userManager.FindByNameAsync("khaledgomaa"))?.Id
                });
                unitOfWork.Save();
            }

            return Json(new { redirectToUrl = Url.Action("", "Home") });
        }

        public async Task<IActionResult> CancelBooking(string bookingId)
        {
            if (int.TryParse(bookingId, out int bookId))
            {
                var allTeam = (await unitOfWork.BookingTeamRepo.GetAll())
                                                                    .Where(b => b.BookingId == bookId).ToList();
                if (allTeam.Any())
                {
                    unitOfWork.BookingTeamRepo.Delete(allTeam);
                }
                unitOfWork.BookingRepo.Delete(await unitOfWork.BookingRepo.Find(b => b.BookingId == bookId));
                unitOfWork.Save();
            }
            return Json(new { redirectToUrl = Url.Action("", "Home") });
            //return View();
        }

        public async Task<IActionResult> LeaveTeam(string bookingId)
        {
            if (int.TryParse(bookingId, out int bookId))
            {
                string userId = (await userManager.FindByNameAsync("khaledgomaa"))?.Id;
                unitOfWork.BookingTeamRepo.Delete(await unitOfWork.BookingTeamRepo.Find(b => b.BookingId == bookId && b.ApplicationUserId == userId));
                unitOfWork.Save();
            }
            return Json(new { redirectToUrl = Url.Action("", "Home") });
            //return View();
        }

        private async Task<Status> CheckPlaygroundStatus(int playgroundId)
        {
            return (await unitOfWork.PlayGroundRepo.Find(b => b.PlaygroundId == playgroundId))?.PlaygroundStatus ?? Status.Available;
        }
    }
}