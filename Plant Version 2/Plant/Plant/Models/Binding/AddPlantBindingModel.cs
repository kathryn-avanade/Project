using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Models.Binding
{
    public class AddPlantBindingModel
    {
        
        public string Name { get; set; }
        public string DatePlanted { get; set; }
        public string DateLastWatered { get; set; }
        public myGarden Garden { get; set; }
    }
}
