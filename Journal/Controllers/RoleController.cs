using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Journal.Core;

namespace Journal.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Admin()
        {
            ViewData["Title"] = "Страница Администратора";
            ViewData["Message"] = "Hello!";
            return View();
        }

    }
}
