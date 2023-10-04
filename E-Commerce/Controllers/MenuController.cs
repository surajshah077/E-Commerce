using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace E_Commerce.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webhostEnvironment;
        public MenuController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _webhostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.menu.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Menu menu, IFormFile item, IFormFile profileImage)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webhostEnvironment.WebRootPath;
                {
                    if (item != null)
                    {
                        if (Path.GetExtension(item.FileName).ToLower() == ".jpg")
                        {
                            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(item.FileName);
                            string path = Path.Combine(wwwRootPath, @"menu/");
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                item.CopyToAsync(fileStream);
                            }
                            menu.itemPhoto = @"menu/" + fileName;
                        }
                        if (profileImage != null)
                        {
                            if (Path.GetExtension(profileImage.FileName).ToLower() == ".jpg")
                            {
                                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(profileImage.FileName);
                                string path = Path.Combine(wwwRootPath, @"menu/");
                                using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                                {
                                    profileImage.CopyToAsync(fileStream);
                                }
                                menu.profileImage = @"images/" + fileName;
                            }
                        }
                    }
                    _context.menu.Add(menu);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Menu menu = _context.menu.FirstOrDefault(x => x.MenuId == id);
            if (menu == null)
            {
                return NotFound(id);
            }
            return View(menu);
        }
        [HttpPost]
        public IActionResult Edit(Menu menu, IFormFile item, IFormFile profileImage)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webhostEnvironment.WebRootPath;
                if (item != null)
                {
                   if (Path.GetExtension(item.FileName).ToLower() == ".jpg")
                    {
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(item.FileName);
                        string path = Path.Combine(wwwRootPath, @"menu/");
                        if (!string.IsNullOrEmpty(menu.itemPhoto))
                        {
                            var oldPath = Path.Combine(wwwRootPath, menu.itemPhoto);
                            if (System.IO.File.Exists(oldPath))
                            {
                                System.IO.File.Delete(oldPath);
                            }
                        }
                        using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            item.CopyToAsync(fileStream);
                        }
                        menu.itemPhoto = @"menu/" + fileName;
                    }
                    if (profileImage != null)
                    {
                        if (Path.GetExtension(profileImage.FileName).ToLower() == ".jpg")
                        {
                            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(profileImage.FileName);
                            string path = Path.Combine(wwwRootPath, @"menu/");
                            if (!string.IsNullOrEmpty(menu.profileImage))
                            {
                                var oldPath = Path.Combine(wwwRootPath, menu.profileImage);
                                if (System.IO.File.Exists(oldPath))
                                {
                                    System.IO.File.Delete(oldPath);
                                }
                            }
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                profileImage.CopyToAsync(fileStream);
                            }
                            menu.profileImage = @"menu/" + fileName;
                        }
                    }
                    _context.menu.Update(menu);
                    _context.SaveChanges();
                    return RedirectToAction("Index");

                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            Menu menu = _context.menu.FirstOrDefault(x => x.MenuId == id);
            if (menu == null)
            {
                return NotFound(id);
            }
            return View(menu);
        }
        [HttpPost]
        public IActionResult Delete(Menu menu)
        {

            string wwwRootPath = _webhostEnvironment.WebRootPath;

            {
                if (!string.IsNullOrEmpty(menu.itemPhoto))
                {
                    var oldPath = Path.Combine(wwwRootPath, menu.itemPhoto);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }
                if (!string.IsNullOrEmpty(menu.profileImage))
                {
                    var oldPath = Path.Combine(wwwRootPath, menu.profileImage);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }
                _context.menu.Remove(menu);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}

