using Microsoft.EntityFrameworkCore;
using Plant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }


        //Create a table called Plants which has rows of myPlant objects
        //Create a table called Gardens which has rows of myGarden objects
        public DbSet<myPlant> Plants { get; set; }
        public DbSet<myGarden> Gardens { get; set; }
    }
}
