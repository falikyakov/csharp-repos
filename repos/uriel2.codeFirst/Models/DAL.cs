using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using uriel2.codeFirst.Models;

namespace uriel2.codeFirst
{
    public class DAL : DbContext
    {
        private static DAL dal { get; set; }
        private DAL() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Uriel2_CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer<DAL>(new DropCreateDatabaseIfModelChanges<DAL>());
        }

        public static DAL Get
        {
            get
            {
                if (dal == null)
                {
                    dal = new DAL();
                }
                return dal;
            }
        }

        private void Seed()
        {
            new Food { Item = "Bread", Calories = 237 };
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Goals> Goals { get; set; }
        public DbSet<dailyActual> DailyActuals { get; set; }
        public DbSet<dailyPlan> DailyPlans { get; set; }
        public DbSet<admin> Admin { get; set; }
        public DbSet<Food> FoodDetails { get; set; }
        public DbSet<WeeklyUpdate> WeeklyUpdates { get; set; }
        public DbSet<WeightList> WeightLists { get; set; } 
    }
}
