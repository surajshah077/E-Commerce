using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace E_Commerce.Controllers
{
 public class GalleryController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly IWebHostEnvironment _hostEnvironment;
    public GalleryController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
    {
        _context = context;
        _hostEnvironment = hostEnvironment;
    }

    public IActionResult Index()
    {
        return View(_context.gallery.ToList());
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Gallery @event, IFormFile file)
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
                        @event.GalleryPicture = @"chefs/" + fileName;
                        _context.gallery.Add(@event);
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
        Chefs chefs = _context.chefs.FirstOrDefault();
        return View(chefs);
    }
    [HttpPost]
    public IActionResult Edit(Gallery chefs, IFormFile file)
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
                        if (!string.IsNullOrEmpty(chefs.GalleryPicture))
                        {
                            var oldPath = Path.Combine(wwwRootPath, chefs.GalleryPicture);
                            if (System.IO.File.Exists(oldPath))
                            {
                                System.IO.File.Delete(oldPath);
                            }
                        }
                        using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            file.CopyToAsync(fileStream);
                        }
                        chefs.GalleryPicture = @"chefs/" + fileName;
                    }
                }
                _context.gallery.Update(chefs);
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
        Gallery @event = _context.gallery.FirstOrDefault(x => x.GalleryId == id);
        if (@event == null)
        {
            return NotFound(id);
        }
        return View(@event);
    }
    [HttpPost]
    public IActionResult Delete(Gallery @event)
    {

        string wwwRootPath = _hostEnvironment.WebRootPath;

        {
            if (!string.IsNullOrEmpty(@event.GalleryPicture))
            {
                var oldPath = Path.Combine(wwwRootPath, @event.GalleryPicture);
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }
            }
            _context.gallery.Remove(@event);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
}