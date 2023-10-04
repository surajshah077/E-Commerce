using E_Commerce.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public AboutController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_context.About.ToList());
        }
        public IActionResult Edit(int id)
        {
            About about = _context.About.FirstOrDefault();
            string image = about.Image;
            string image2 = about.Image2;
            ViewBag.image = image;
            ViewBag.image2 = image2;
            return View(about);
        }
        [HttpPost]
        public IActionResult Edit(About about, IFormFile image1, IFormFile image2)
        {
            if (ModelState.IsValid)
            {
                 string wwwRootPath = _hostEnvironment.WebRootPath;
                {
                    if (image1 != null)
                    {
                        if (Path.GetExtension(image1.FileName).ToLower() == ".jpg")
                        {
                            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(image1.FileName);
                            string path = Path.Combine(wwwRootPath, @"aboutImages/");
                            if (!string.IsNullOrEmpty(about.Image))
                            {
                                var oldPath = Path.Combine(wwwRootPath, about.Image);
                                if (System.IO.File.Exists(oldPath))
                                {
                                    System.IO.File.Delete(oldPath);
                                }
                            }
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                image1.CopyToAsync(fileStream);
                            }
                            about.Image = @"aboutImages/" + fileName;
                        }
                    }
                    if (image2 != null)
                    {
                        if (Path.GetExtension(image2.FileName).ToLower() == ".jpg")
                        {
                            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(image2.FileName);
                            string path = Path.Combine(wwwRootPath, @"aboutImages/");
                            if (!string.IsNullOrEmpty(about.Image2))
                            {
                                var oldPath = Path.Combine(wwwRootPath, about.Image2);
                                if (System.IO.File.Exists(oldPath))
                                {
                                    System.IO.File.Delete(oldPath);
                                }
                            }
                            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                            {
                                image2.CopyToAsync(fileStream);
                            }
                            about.Image2 = @"aboutImages/" + fileName;
                        }
                    }
                    var aboutimage = new About
                    {   
                        AboutId = about.AboutId,
                        AboutTitle1 = about.AboutTitle1,
                        AboutTitle2 = about.AboutTitle2,
                        Image = about.Image,
                        Image2 = about.Image2,
                        Message = about.Message,
                        phoneNumber = about.phoneNumber,
                        description = about.description,
                        shortDescription = about.shortDescription,
                        Video = about.Video
                        
                        

                    };
                    _context.About.Update(aboutimage);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}


