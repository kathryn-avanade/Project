using Plant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Interfaces
{
    public interface IRepoWrapper
    {
        ImyGardenRepo Gardens { get; }
        ImyPlantRepo Plants { get; }

        void Save() { }
    }
}
