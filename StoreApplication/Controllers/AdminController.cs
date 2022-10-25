using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StoreApplication.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext db;
        IHttpContextAccessor context;
        public AdminController(AppDbContext dbContext, IHttpContextAccessor httpContext)
        {
            db = dbContext;
            context = httpContext;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminModel model)
        {
            if (ModelState.IsValid)
            {
                if (FindEnteredAdminInDb(model))
                {
                    await Authenticate(model);
                    return RedirectToAction("Home", "Admin");
                }
            }
            ModelState.AddModelError("", "Користувача з таким логіном та паролем не існує");

            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AdminModel model)
        {
            if (ModelState.IsValid)
            {
                AdminModel user = await db.AdminModels.FirstOrDefaultAsync(a => a.Login == model.Login);
                if (user == null)
                {
                    db.AdminModels.Add(new AdminModel { Login = model.Login, Password = model.Password, AdminLevel = model.AdminLevel });
                    await db.SaveChangesAsync();

                    await Authenticate(model);

                    return RedirectToAction("Home", "Admin");
                }
                else
                    ModelState.AddModelError("", "Некорректні дані і(або) пароль");
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
        protected bool FindEnteredAdminInDb(AdminModel model)
        {
            AdminModel admin = new AdminModel();
            admin = db.AdminModels.FirstOrDefault(a => a.Login == model.Login && a.Password == model.Password);
            return admin != null;
        }
        protected async Task Authenticate(AdminModel model)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, model.Login)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
