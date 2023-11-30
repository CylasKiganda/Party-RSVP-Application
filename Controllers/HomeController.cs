using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";   
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //Do something with the new guestResponse
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(Response => Response.WillAttend ==true));
        }
    }
}