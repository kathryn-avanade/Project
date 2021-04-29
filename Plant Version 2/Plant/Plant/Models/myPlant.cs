using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Models
{
    public class myPlant
    {
        //do i need this?
        public int ID { get; set; }
        public string Name { get; set; }
        public string DatePlanted { get; set; }
        public string DateLastWatered { get; set; }

        //One to one relationship with gardens 
        public virtual myGarden Garden { get; set; }
    }
    
}
