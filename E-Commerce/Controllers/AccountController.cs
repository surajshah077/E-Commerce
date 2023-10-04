using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.VMs;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_Commerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Policy = "Superadmin")]
        public IActionResult Index()
        {
            return View(_context.register.ToList());
        }

        public async Task<IActionResult> Register()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (!IsEmailUnique(register.Email))
            {
                ModelState.AddModelError("Email", "This email address is already in use.");
                return View(register);
            }
            if (ModelState.IsValid)
            {
                _context.register.Add(register);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
        private bool IsEmailUnique(string email)
        {
            // Check if email is unique in the database
            // Return true if unique, false otherwise
            return !_context.register.Any(u => u.Email == email);
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Superadmin"))
                    return RedirectToAction("Index");
                else
                {
                    return RedirectToAction("Index", "CodeTable");
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                Register user = _context.register.FirstOrDefault(x => x.Email == login.Email && x.Password == login.Password);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }
                List<Claim> claims = new List<Claim>()
                 {
                 new Claim(ClaimTypes.NameIdentifier, login.Email),
                new Claim (ClaimTypes.NameIdentifier, login.Password),
                new Claim("CurrentRole",user.role.ToString()),
                  };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme
                    );
                var principal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(
                 CookieAuthenticationDefaults.AuthenticationScheme, principal,
              new AuthenticationProperties()
              {
                  IsPersistent = true,
              });
                if ((user.role) == Models.Enum.Role.Superadmin)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index", "Static");
                }
            }

            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "Superadmin")]
        public IActionResult Delete(int id)
        {
            List<Register> register = _context.register.ToList();
            return View(register);
        }
        [HttpPost]
        public IActionResult Delete(Register register)
        {
            _context.register.Remove(register);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
