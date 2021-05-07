using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plant.Data;
using Plant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Controllers
{
    
        
        public class GardenController : Controller {


        //attempt at mock testing
        private IRepoWrapper _repo;
        //Dependancy injection
        public GardenController(IRepoWrapper repoWrapper)
        {
            _repo = repoWrapper;
        }
        public IActionResult Garden()
        {
            var allGardens = _repo.Gardens.FindAll();
            return View(allGardens);
        }
    }
}
