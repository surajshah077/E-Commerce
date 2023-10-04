using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.VMs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Main main = _context.mains.FirstOrDefault();
            About abouts = _context.About.FirstOrDefault();
            Static fix = _context.statics.FirstOrDefault();
            List<Menu> menu = _context.menu.ToList();
            List<Event> events = _context.events.ToList();
            List<Chefs> chefs = _context.chefs.ToList();
            List<Gallery> galleries = _context.gallery.ToList();

            ViewModels viewModels = new ViewModels()
            {
                main = main,
                about = abouts,
                Static = fix,
                menu = menu,
                events=events,
                chefs = chefs,
                gallery = galleries,
                booking = new bookTable(),
                contact = new Contact()
            };
            return View(viewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}