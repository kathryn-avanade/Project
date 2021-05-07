using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plant.Models;
using Plant.Data;
using Plant.Models.Binding;
using Plant.Interfaces;

namespace Plant.Controllers
{

    public class PlantController : Controller
    {
       
        private IRepoWrapper _repo;
        //Dependancy injection
        public PlantController(IRepoWrapper repoWrapper)
        {
            _repo = repoWrapper;
        }


        public IActionResult Plant()
        {
            var allPlants = _repo.Plants.FindAll();
            
            return View(allPlants);
        }

        //get the id in the session
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var plantByID = _repo.Plants.FindByCondition(c => c.ID == id).FirstOrDefault();
            return View(plantByID);
        }

        //renders the page
        public IActionResult Create()
        {
            return View("Create");
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
            _repo.Gardens.Create(gardenToCreate);


            _repo.Plants.Create(plantToCreate);
            
            _repo.Save();
            return RedirectToAction("Plant");
        }


        //edit
        //get the id in the session
        [Route("edit/{id:int}")]
        public IActionResult Edit(int id)
        {
            var plantById = _repo.Plants.FindByCondition(c => c.ID == id).FirstOrDefault();
            return View(plantById);
        }

        [HttpPost]
        [Route("edit/{id:int}")]
        public IActionResult Edit(myPlant plant, int id)
        {
            _repo.Plants.Edit(plant);
            _repo.Save();
            return RedirectToAction("Plant");
        }


        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var plantToDelete = _repo.Plants.FindByCondition(c => c.ID == id).FirstOrDefault();
            _repo.Plants.Delete(plantToDelete);

            //Need to remove the garden from the database

            _repo.Save();
            return RedirectToAction("Plant");



        }
        
        

    }
}
