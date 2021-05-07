using Plant.Models;
using System;
using Xunit;
using FluentAssertions;
using Planting.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Plant.Interfaces;

namespace PlantTests
{
    public class HomeControllerTest
    {
        //private HomeController homeController;
        private Mock<ILogger<HomeController>> logger;
        private HomeController homeController;
        private Mock<IErrorViewModel> errorViewModelMock;

        public HomeControllerTest()
        {
            logger = new Mock<ILogger<HomeController>>();
            homeController = new HomeController(logger.Object);
            errorViewModelMock = new Mock<IErrorViewModel>();
        }
        
        [Fact]
        public void TestIndexAction()
        {
            //Arrange the object we want to test

            //Act
            ViewResult result = homeController.Index() as ViewResult;
            //Assert 
            Assert.NotNull(result);
            Assert.Equal("Index", result.ViewName);
            Assert.IsType<ViewResult>(result);
        }

    }
}
