using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class StaticController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StaticController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.statics.ToList());
        }
        public IActionResult Edit(int id)
        {
           var statics = _context.statics.FirstOrDefault();
            return View(statics);
        }
        [HttpPost]
        public IActionResult Edit(Static obj) 
        {
            if(ModelState.IsValid)
            {
                _context.statics.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
