using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Journal.Areas.Identity.Data;
using Journal.Core;
using Journal.Models;


namespace Journal.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TeachersController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Index()
        {
            IEnumerable<Teacher> objTeachers = _db.Teachers;
            return View(objTeachers);
        }



        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher obj)
        {
            _db.Teachers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
