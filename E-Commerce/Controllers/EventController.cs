using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Text.RegularExpressions;

namespace E_Commerce.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public EventController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.events.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Event @event, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRoothPath = _webHostEnvironment.WebRootPath;
                {
                    if (file != null)
                    {
                        if (Path.GetExtension(file.FileName).ToLower() == ".jpg")
                        {
                            string fileName = Path.GetFileName(file.FileName);
                            string path = Path.Combine(wwwRoothPath, @"event/");
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                            }
                            @event.eventPicture = @"event/" + fileName;
                            _context.events.Add(@event);
                            _context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                    }
                }
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            Event events = _context.events.FirstOrDefault();
            return View(events);
        }
        [HttpPost]
        public IActionResult Edit(Event @event, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    if (Path.GetExtension(file.FileName).ToLower() == ".jpg") ;
                    string fileName = Guid.NewGuid().ToString() + Path.GetFileName(file.FileName);
                    string path = Path.Combine(wwwRootPath, @"event/");
                    if (!string.IsNullOrEmpty(@event.eventPicture))
                    {
                        var oldPath = Path.Combine(wwwRootPath, @event.eventPicture);
                        if (System.IO.File.Exists(oldPath))
                        {
                            System.IO.File.Delete(oldPath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    @event.eventPicture = @"event/" + fileName;
                    _context.events.Update(@event);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Event @event = _context.events.FirstOrDefault(x => x.EventId == id);
            if (@event == null)
            {
                return NotFound(id);
            }
            return View(@event);
        }
        [HttpPost]
        public IActionResult Delete(Event @event)
        {

            string wwwRootPath = _webHostEnvironment.WebRootPath;

            {
                if (!string.IsNullOrEmpty(@event.eventPicture))
                {
                    var oldPath = Path.Combine(wwwRootPath, @event.eventPicture);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }
                _context.events.Remove(@event);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
