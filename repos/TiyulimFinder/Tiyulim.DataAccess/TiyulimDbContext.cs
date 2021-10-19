using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiyulim.BusinessEntities;

namespace Tiyulim.DataAccess
{
    class TiyulimDbContext:DbContext
    {
        public TiyulimDbContext():base()
        {

        }

        public DbSet<Tours> TiyulimTable { get; set; }
    }
} 
