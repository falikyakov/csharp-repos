using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AnimalContext:DbContext
    {
        public AnimalContext():base()
        {

        }

        public DbSet<Animal> Animals { get; set; }
    }
}