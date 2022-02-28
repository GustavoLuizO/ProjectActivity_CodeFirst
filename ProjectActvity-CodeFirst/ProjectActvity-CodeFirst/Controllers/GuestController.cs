using Microsoft.AspNetCore.Mvc;
using ProjectActvity_CodeFirst.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectActvity_CodeFirst.Controllers
{
    public class GuestController : Controller
    {
        public static IList<Guests> listGuests = new List<Guests>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Guests Guest)
        {
            listGuests.Add(Guest);
            Guest.guestId = listGuests.Select(m => m.guestId).Max() + 1;
            return RedirectToAction("Index");
        }
    }
}
