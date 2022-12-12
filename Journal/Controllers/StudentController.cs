using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Journal.Areas.Identity.Data;
using Journal.Core;
using Journal.Models;
using Journal.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Journal.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        private List<Class> GetClasses()
        {
            var classes = new List<Class>();
            classes = _db.Classes.ToList();
            return classes;
        }
        private List<Parent> GetParents()
        {
            var parents = new List<Parent>();
            parents = _db.Parent.ToList();
            return parents;
        }


        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult StudentList()
        {
            IEnumerable<Student> objStudents = _db.Students.ToList();
            return View(objStudents);
        }


        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Create()
        {
            ViewBag.ParentsSelectList = new SelectList(GetParents(), "Id", "LastName");
            ViewBag.ClassesSelectList = new SelectList(GetClasses(), "Id", "Nubmer");
            return View();
        }
    }
}
