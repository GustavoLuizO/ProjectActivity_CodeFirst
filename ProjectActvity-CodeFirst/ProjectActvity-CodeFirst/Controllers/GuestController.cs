using Microsoft.AspNetCore.Mvc;

namespace ProjectActvity_CodeFirst.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
