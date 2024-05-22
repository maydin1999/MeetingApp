using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Tekirdağ - Çorlu",
                Date = new DateTime(2024,10,23, 19, 0, 0),
                NumberOfPeople = UserCount

            };
            int hour = DateTime.Now.Hour;
            ViewBag.HourCheck = hour < 12 ? "Good Night" : "Good Day";
            return View(meetingInfo);
        }
    }
}
