using System.Linq;
using System.Threading.Tasks;
using assignment_3.Data;
using assignment_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace assignment_3.Controllers
{
    public class GuestbookController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<GuestbookController> _logger;

        public GuestbookController(ApplicationDbContext db, ILogger<GuestbookController> logger)
        {
            _logger = logger;
            _db = db;
        }

        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return View(_db.Guests.ToList());
        }
        
        [HttpGet]
                public IActionResult Add()
                {
                    Guest guest = new Guest();
                    return View(guest);
                }
        
        [HttpPost]
        public IActionResult Add(Guest guest)
        {
            if (ModelState.IsValid)
            {
                _db.Guests.Add(guest);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View(guest);

        }

        



    }
}