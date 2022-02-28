using Microsoft.AspNetCore.Mvc;
using ProjectActvity_CodeFirst.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectActvity_CodeFirst.Controllers
{
    public class GuestController : Controller
    {
        public static IList<Guests> listGuests = new List<Guests>()
        {
            new Guests()
            {
                guestId = 1,
                Name = "Exemplo convidado",
                EMail = "ExemploConvidado@gmail.com",
                Phone = "3853-1873",
                attendance = true,
            }
        };

        public IActionResult Index()
        {
            return View(listGuests);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Guests guests)
        {
            listGuests.Add(guests);
            guests.guestId = listGuests.Select(m => m.guestId).Max() + 1;
            return RedirectToAction("Index");
        }
    }
}
