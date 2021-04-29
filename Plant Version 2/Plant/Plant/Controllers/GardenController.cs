using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Controllers
{
    
        
        public class GardenController : Controller {

        private readonly ApplicationDBContext DbContext;
        //Dependancy injection
        public GardenController(ApplicationDBContext applicationDbContext)
        {
            DbContext = applicationDbContext;
        }
        public IActionResult Garden()
        {
            var allGardens = DbContext.Gardens.ToList();
            return View(allGardens);
        }
    }
}
