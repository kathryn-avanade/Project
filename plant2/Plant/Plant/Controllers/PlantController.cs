using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plant.Models;
using Plant.Data;
using Plant.Models.Binding;

namespace Plant.Controllers
{

    public class PlantController : Controller
    {
        private readonly ApplicationDBContext DbContext;
        //Dependancy injection
        public PlantController(ApplicationDBContext applicationDbContext)
        {
            DbContext = applicationDbContext;
        }

        public IActionResult Plant()
        {
            var allPlants = DbContext.Plants.ToList();
            return View(allPlants);
        }
        //get the id in the session
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var plantByID = DbContext.Plants.FirstOrDefault(c => c.ID == id);
            return View(plantByID);
        }

        //renders the page
        public IActionResult Create()
        {
            return View();
        }

        //performs the action
        [HttpPost]
        public IActionResult Create(AddPlantBindingModel bindingModel)
        {
            var plantToCreate = new myPlant
            {
                Name = bindingModel.Name,
                DatePlanted = bindingModel.DatePlanted,
                DateLastWatered = bindingModel.DateLastWatered,
                Garden = bindingModel.Garden
            };

            var gardenToCreate = new myGarden
            {
                Name = plantToCreate.Garden
            };
            DbContext.Gardens.Add(gardenToCreate);


            DbContext.Plants.Add(plantToCreate);
            
            DbContext.SaveChanges();
            return RedirectToAction("Plant");
        }


        //edit
        //get the id in the session
        [Route("edit/{id:int}")]
        public IActionResult Edit(int id)
        {
            var plantById = DbContext.Plants.FirstOrDefault(c => c.ID == id);
            return View(plantById);
        }

        [HttpPost]
        [Route("edit/{id:int}")]
        public IActionResult Edit(myPlant plant, int id)
        {
            var plantToUpdate = DbContext.Plants.FirstOrDefault(c => c.ID == id);
            plantToUpdate.Name = plant.Name;
            plantToUpdate.DateLastWatered = plant.DateLastWatered;
            plantToUpdate.DatePlanted = plant.DatePlanted;
            plantToUpdate.Garden = plant.Garden;
            DbContext.SaveChanges();
            return RedirectToAction("Plant");
        }


        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var plantToDelete = DbContext.Plants.FirstOrDefault(c => c.ID == id);
            DbContext.Plants.Remove(plantToDelete);

            //Need to remove the garden from the database
            


            DbContext.SaveChanges();
            return RedirectToAction("Plant");



        }
        
        

    }
}
