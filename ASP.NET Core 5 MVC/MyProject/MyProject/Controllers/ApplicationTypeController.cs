using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.Books;
            return View(objList);
        }
        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            _db.Books.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
