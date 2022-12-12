using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Journal.Areas.Identity.Data;
using Journal.Core;
using Journal.Models;
using Journal.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Journal.Controllers
{
    public class ObjectController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ObjectController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Object> objObJects = _db.Objects.ToList();
            return View(objObJects);
        }
    }
}
