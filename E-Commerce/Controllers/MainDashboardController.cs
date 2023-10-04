using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace E_Commerce.Controllers
{
    public class MainDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public MainDashboardController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.mains.ToList());
        }
        public IActionResult Edit(int id)
        {
            Main mains = _context.mains.FirstOrDefault();
            return View(mains);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Main obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                {
                    if (file != null)
                    {
                        if (Path.GetExtension(file.FileName).ToLower() == ".jpg" || Path.GetExtension(file.FileName).ToLower() == ".png")
                        {
                            string fileName = Guid.NewGuid().ToString() + Path.GetFileName(file.FileName);
                            string path = Path.Combine(wwwRootPath, @"event/");
                            if (!string.IsNullOrEmpty(obj.Image))
                            {
                                var oldPath = Path.Combine(wwwRootPath, obj.Image);
                                if (System.IO.File.Exists(oldPath))
                                {
                                    System.IO.File.Delete(oldPath);
                                }
                            }
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                            }
                            obj.Image = @"event/" + fileName;
                        }
                    }
                        _context.mains.Update(obj);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
