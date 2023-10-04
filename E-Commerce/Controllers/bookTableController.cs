using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class bookTableController : Controller
    {
        private readonly ApplicationDbContext _context;
        public bookTableController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (bookTable book)
        {
            if(ModelState.IsValid)
            {
                _context.booking.Add(book);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
