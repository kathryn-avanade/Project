using Plant.Data;
using Plant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Models.Repos
{
    public class RepoWrapper : IRepoWrapper
    {
        //Dependency injection for 'fake' db
        ApplicationDBContext _repoContext;
        public RepoWrapper(ApplicationDBContext repoContext)
        {
            _repoContext = repoContext;
        }

        ImyGardenRepo _gardens;
        ImyPlantRepo _plants;

        public ImyGardenRepo Gardens
        {
            get
            {
                if (_gardens == null)
                {
                    _gardens = new GardenRepo(_repoContext); 
                }
                return _gardens; 
            }
        }
        public ImyPlantRepo Plants
        {
            get
            {
                if (_plants == null)
                {
                    _plants = new PlantRepo(_repoContext);
                }
                return _plants;
            }
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
