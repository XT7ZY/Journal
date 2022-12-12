using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Journal.Areas.Identity.Data;
using Journal.Core;
using Journal.Models;

namespace Journal.Controllers
{
    public class ParentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ParentController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Index()
        {
            IEnumerable<Parent> objTeachers = _db.Parent;
            return View(objTeachers);
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Parent obj)
        {
            _db.Parent.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
