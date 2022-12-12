using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Journal.Core;

namespace Journal.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
