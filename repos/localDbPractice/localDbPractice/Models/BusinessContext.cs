using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace localDbPractice.Models
{
    public class BusinessContext:DbContext 
    {
        public BusinessContext():base()
        {

        }

        public DbSet<Business> Businesses { get; set; }
    }

    
}