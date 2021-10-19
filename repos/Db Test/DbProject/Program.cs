using Db_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { Name = "Martha" };

            

              

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                
            }

            
        }
    }
}
