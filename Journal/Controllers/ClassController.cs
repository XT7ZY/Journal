using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Journal.Areas.Identity.Data;
using Journal.Core;
using Journal.Models;
using Journal.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Journal.Controllers
{

    public class ClassController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ClassController(ApplicationDbContext db)
        {
            _db = db;
        }

        private List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>(); 
            teachers = _db.Teachers.ToList();
            return teachers;
        }



        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Index()
        {
            ViewBag.TeacherSelectList = new SelectList(GetTeachers(), "Id", "FullName");
            IEnumerable<Class> objClasses = _db.Classes.ToList();
            return View(objClasses);
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Info(int id)
        {
            Class b = _db.Classes.Find(id);
            Teacher teacher = _db.Teachers.Find(b.TeacherId);

            List<Student> studentsList = new List<Student>();
            foreach (Student student in _db.Students)
            {
                if (student.Class == b)
                {
                    studentsList.Add(student);
                }
            }

            IEnumerable<Student> studentsInClass = studentsList;
            string number = b.Number.ToString();
            string letter = b.Letter.ToString();
            string clas = number + letter;

            ViewData["clas"] = clas;
            ViewData["teacher"] = teacher.FullName;
            ViewData["Title"] = clas;

            return View(studentsInClass);
        }





        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Create()
        {
            ViewBag.TeacherSelectList = new SelectList(GetTeachers(), "Id", "FullName");
            return View();

        }


        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public ActionResult Delete(int id)
        {
            Class a = _db.Classes.Find(id);
            if (a == null)
            {
                return NotFound();
            }
            _db.Classes.Remove(a);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Class obj)
        {
            
            _db.Classes.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index"); 

        }
    }
}
