using GuestList.Data;
using GuestList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GuestList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var guests = _context.Guests.ToList();
            return View(guests);
        }

        public IActionResult Guestlist()
        {
            var guests = _context.Guests.ToList();
            return View(guests);
        }

        public IActionResult GetAllGuests()
        {
            var guests = _context.Guests.ToList();
            return View(guests);
        }

        [HttpPost]
        public IActionResult AddGuest(string name, string message)
        {
            var guest = new Guest { Name = name, Message = message };
            _context.Guests.Add(guest);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}