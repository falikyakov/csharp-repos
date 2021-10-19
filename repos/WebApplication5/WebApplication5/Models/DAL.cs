using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.Models
{
    public class DAL : DbContext
    {
        private static DAL Data;
        private DAL() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ShabbatGuests;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer<DAL>(new DropCreateDatabaseIfModelChanges<DAL>());
            if (foodCategories.Count() == 0) Seed();
        }


        public static DAL Get { get { if (Data == null) Data = new DAL(); return Data; } }

        private void Seed()
        {
            FoodCategory fCategory = new FoodCategory { name = "Fish" };
            foodCategories.Add(fCategory);
            guests.Add(new Guest { firstName = "Avraham", lastName = "Kohn" });
            SaveChanges();
        }

        public DbSet<Food> foods { get; set; }

        public DbSet<FoodCategory> foodCategories { get; set; }

        public DbSet<FoodToGuest> foodToGuests { get; set; }

        public DbSet<Guest> guests { get; set; }
    }
}
