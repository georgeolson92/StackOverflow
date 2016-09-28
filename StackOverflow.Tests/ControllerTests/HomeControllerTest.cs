using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackOverflow.Controllers;
using StackOverflow.Models;
using Xunit;

namespace StackOverflow.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}