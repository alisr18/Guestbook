using System.Linq;
using assignment_4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace assignment_4.Controllers
{
    public class BlogUserController : Controller
    {
        private readonly ILogger<BlogUserController> _logger;
        private readonly ApplicationDbContext _db;

        public BlogUserController(ILogger<BlogUserController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        
        
        // GET
        public IActionResult Index()
        {
            _logger.LogDebug("Get BlogUsers/Index");
            
            return View(_db.BlogUsers.ToList());
        }
        
        public IActionResult Add()
        {
            return View();
        }
        
        public IActionResult Edit()
        {
            return View();
        }
    }
}