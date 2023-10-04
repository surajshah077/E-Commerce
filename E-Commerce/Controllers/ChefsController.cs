using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class ChefsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ChefsController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.chefs.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Chefs @event, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRoothPath = _hostEnvironment.WebRootPath;
                {
                    if (file != null)
                    {
                        if (Path.GetExtension(file.FileName).ToLower() == ".jpg")
                        {
                            string fileName = Path.GetFileName(file.FileName);
                            string path = Path.Combine(wwwRoothPath, @"chefs/");
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                            }
                            @event.profileImage = @"chefs/" + fileName;
                            _context.chefs.Add(@event);
                            _context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                    }
                }
            }
            return View("Index","Home");
        }
        public IActionResult Edit(int id)
        {
            Chefs chefs = _context.chefs.FirstOrDefault();
            return View(chefs);
        }
        [HttpPost]
        public IActionResult Edit(Chefs chefs, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                {
                    if (file != null)
                    {
                        if (Path.GetExtension(file.FileName).ToLower() == ".jpg")
                        {
                            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                            string path = Path.Combine(wwwRootPath, @"chefs/");
                            if (!string.IsNullOrEmpty(chefs.profileImage))
                            {
                                var oldPath = Path.Combine(wwwRootPath, chefs.profileImage);
                                if (System.IO.File.Exists(oldPath))
                                {
                                    System.IO.File.Delete(oldPath);
                                }
                            }
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                file.CopyToAsync(fileStream);
                            }
                            chefs.profileImage = @"chefs/" + fileName;
                        }
                    }
                    _context.chefs.Update(chefs);
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
            Chefs @event = _context.chefs.FirstOrDefault(x => x.ChefsId == id);
            if (@event == null)
            {
                return NotFound(id);
            }
            return View(@event);
        }
        [HttpPost]
        public IActionResult Delete(Chefs @event)
        {

            string wwwRootPath = _hostEnvironment.WebRootPath;

            {
                if (!string.IsNullOrEmpty(@event.profileImage))
                {
                    var oldPath = Path.Combine(wwwRootPath, @event.profileImage);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }
                _context.chefs.Remove(@event);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
