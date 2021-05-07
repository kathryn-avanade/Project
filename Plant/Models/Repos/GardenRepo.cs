using Plant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Models.Repos
{
    public class GardenRepo : Repos<myGarden>, ImyGardenRepo
    {
        public GardenRepo(ApplicationDBContext dbContext): base(dbContext)
        {

        }
    }
}
