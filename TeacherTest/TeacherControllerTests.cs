using Journal.Areas.Identity.Data;
using Journal.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TeacherTest
{
    [TestClass]
    public class TeacherControllerTests
    {
        private readonly ApplicationDbContext db;

        [TestMethod]
        public void TestIndexView()
        {
            var controller = new TeachersController(db);
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}