using Journal.Areas.Identity.Data;
using Journal.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NuGet.Protocol.Core.Types;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Journal.Tests
{
    public class RoleControllerTests
    {
        [Fact]
        public void IndexViewResultNotNull()
        {
            // Arrange
            RoleController controller = new RoleController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void AdminViewResultNotNull()
        {
            // Arrange
            RoleController controller = new RoleController();

            // Act
            ViewResult result = controller.Admin() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void AdminViewTitleMessageIsAdminPage()
        {
            // Arrange
            RoleController controller = new RoleController();

            // Act
            ViewResult result = controller.Admin() as ViewResult;

            // Assert
            Assert.Equal("Hello!", result?.ViewData["Message"]);
        }

        [Fact]
        public void IndexViewNameEqualIndex()
        {
            // Arrange
            RoleController controller = new RoleController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.Equal("Index", result?.ViewName);
        }
    }
}