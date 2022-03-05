using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhantomWeb.DAL;
using PhantomWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PhantomWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhantomWebDbContext db;

        public HomeController(PhantomWebDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                Banners = db.Banners.FirstOrDefault(),
                Projects = db.Projects.ToList(),

            };
            return View(hvm);
        }

        
        
    }
}
