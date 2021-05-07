using Plant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Models.Repos
{
    public class PlantRepo : Repos<myPlant>, ImyPlantRepo
    {
        public PlantRepo(ApplicationDBContext dbContext) : base(dbContext)
        {

        }
    }
}
