using Moq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Plant.Data;
using Plant.Controllers;
using Plant.Interfaces;
using Plant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PlantTests.Utility
{
    public class GardenControllerTest
    {
       
        private GardenController gardenController;
        private myGarden garden;
        private List<myGarden> gardens;
        private Mock<IRepoWrapper> mockRepo;
        private Mock<ImyGarden> gardenMock;
        private List<ImyGarden> gardensMock;

        public GardenControllerTest()
        {
            gardenMock = new Mock<ImyGarden>();
            gardensMock = new List<ImyGarden> { gardenMock.Object };
            mockRepo = new Mock<IRepoWrapper>();
            garden = new myGarden();
            gardens = new List<myGarden>();
            var gardenResultMock = new Mock<IActionResult>();
            var allGardens = GetGardens();
            gardenController = new GardenController(mockRepo.Object);

        }



            //Create dummy data
        private IEnumerable<myGarden> GetGardens()
        {
            return new List<myGarden>() {
                new myGarden{ ID = 1, Name = "Windowsill" },
                new myGarden{ ID = 2, Name = "Front" }
                };
        }
        
        [Fact]
        public void TestGarden()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Gardens.FindAll()).Returns(GetGardens());
            //Act
            ViewResult controllerActionResult = gardenController.Garden() as ViewResult;
            //Assert
            Assert.NotNull(controllerActionResult);
         
            Assert.IsType<ViewResult>(controllerActionResult);
           
        }
    }
}
