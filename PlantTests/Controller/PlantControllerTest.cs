using Plant.Models;
using System;
using Xunit;
using FluentAssertions;
using Plant.Controllers;
using System.Collections.Generic;
using Plant.Interfaces;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Plant.Models.Binding;

namespace PlantTests
{
    public class PlantControllerTest
    {
        
        private PlantController plantController;
        private myPlant plant;
        private List<myPlant> plants;
        private Mock<IRepoWrapper> mockRepo;
        private Mock<ImyPlant> plantMock;
        private List<ImyPlant> plantsMock;

        private AddPlant addPlant;
        private UpdatePlant updatePlant;
        private Mock<IAddPlant> addPlantMock;
        private Mock<IUpdatePlant> updatePlantMock;

        public PlantControllerTest()
        {
            //Mock Setup
            plantMock = new Mock<ImyPlant>();
            plantsMock = new List<ImyPlant> { plantMock.Object };
            addPlantMock = new Mock<IAddPlant>();
            updatePlantMock = new Mock<IUpdatePlant>();
            mockRepo = new Mock<IRepoWrapper>();
            plant = new myPlant();
            plants = new List<myPlant>();
            var allPlants = GetPlants();
            

            //Sample Models
            addPlant = new AddPlant { ID = 1, Name = "Radish", DatePlanted = "29.10.2019", DateLastWatered = "30.10.2019", Garden = "Windowsill" };
            updatePlant = new UpdatePlant { ID = 1, Name = "Radish", DatePlanted = "29.10.2019", DateLastWatered = "30.10.2019", Garden = "Windowsill" };

            //Controller Setup
            var plantResultMock = new Mock<IActionResult>();
            plantController = new PlantController(mockRepo.Object);
        }

        private myPlant GetPlant()
        {
            return GetPlants()[0];

        }

        //Create dummy data
        private List<myPlant> GetPlants()
        {
            return new List<myPlant>() {
                new myPlant{ ID = 1, Name="Bok Choy", DatePlanted= "2021-04-19", DateLastWatered = "2021-04-19", Garden="Back" },

                new myPlant{ ID = 2, Name = "Swiss Chard", DatePlanted="2021-04-19", DateLastWatered= "2021-04-19", Garden="Front" }
                };
        }

        [Fact]
        public void TestPlant()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Plants.FindAll()).Returns(GetPlants());
            //Act
            var controllerActionResult = plantController.Plant();
            //Assert
            Assert.NotNull(controllerActionResult);
            
        }
        //[Fact]
        //public void TestCreate()
        //{
            
        //    //Arrange
        //    mockRepo.Setup(repo => repo.Plants.FindByCondition(c => c.ID == It.IsAny<int>())).Returns(GetPlants());
        //    //Act
        //    var controllerActionResult = plantController.Create(addPlant);
        //    //Assert
        //    Assert.NotNull(controllerActionResult);
            

        //}

        [Fact]
        public void TestDelete()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Plants.FindByCondition(r => r.ID == It.IsAny<int>())).Returns(GetPlants());
            mockRepo.Setup(repo => repo.Plants.Delete(GetPlant()));
            //Act
            var controllerActionResult = plantController.Delete(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }
        //[Fact]
        //public void TestDeleteView()
        //{
        //    var controllerActionResult = plantController.Delete(It.IsAny<int>());
        //    //Assert
        //    Assert.NotNull(controllerActionResult);
        //    Assert.IsType<ViewResult>(controllerActionResult);
        //}

        [Fact]
        public void TestDetails()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Plants.FindByCondition(r=>r.ID == It.IsAny<int>())).Returns(GetPlants());
            //Act
            var controllerActionResult = plantController.Details(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }
        //[Fact] 
        //public void TestDetailsView()
        //{
        //    var controllerActionResult = plantController.Details(It.IsAny<int>());
        //    Assert.NotNull(controllerActionResult);
        //    Assert.IsType<ViewResult>(controllerActionResult);
        //}

        //[Fact]
        //public void TestEdit()
        //{
        //    //Arrange
        //    mockRepo.Setup(repo => repo.Plants.FindByCondition(r => r.ID == It.IsAny<int>())).Returns(GetPlants());
        //    //Act
        //    var controllerActionResult = plantController.Edit(updatePlant,It.IsAny<int>());
        //    //Assert
        //    Assert.NotNull(controllerActionResult);

        //}
    }


}
