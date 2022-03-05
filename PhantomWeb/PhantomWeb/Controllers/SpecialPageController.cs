using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhantomWeb.DAL;
using PhantomWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhantomWeb.Controllers
{
    public class SpecialPageController : Controller
    {
        private readonly PhantomWebDbContext db;

        public SpecialPageController(PhantomWebDbContext _db)
        {
            db = _db;
        }
        public IActionResult GenericPage(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Generic generic = db.Generics.FirstOrDefault(x => x.Id == id);
            if (generic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(generic);
        }

        public IActionResult Messages(string name, string email, string message) 
        {
            Users user = new Users();
            user.Name = name;
            user.Email = email;
            user.Message = message;
            user.Time = DateTime.Now;
            return Content($"name: {name} email: {email} message: {message}");
        }
    }
}
