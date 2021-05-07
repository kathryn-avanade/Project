using Plant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Models
{
    public class myPlant : ImyPlant
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string DatePlanted { get; set; }
        public string DateLastWatered { get; set; }
        public string Garden { get; set; }
    }
    
}
