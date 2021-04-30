using Plant.Models;
using System;
using Xunit;

namespace PlantTests
{
    public class PlantUtilityTest
    {
        [Fact]
        public void GetViewModel()
        {
            //Arrange the object we want to test
            myPlant testPlant = new myPlant()
            {
                ID = 1,
                Name = "Radish",
                DatePlanted = "30/04/2021",
                DateLastWatered = "30/04/2021",
                Garden = "Windowsill"
            };

            //Act
            var 

            //Assert

        }
    }
}
