using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class People
    {
        public List<Person> GetAllPeople(string filter)
        {
            List<Person> Names = new List<Person> {
            new Person{ ID=1,FullName="Yakov Falik"},
             new Person{ ID=2,FullName="Moshe Dickman"},
              new Person{ ID=3,FullName="Yossi Zaguri"},
               new Person{ ID=4,FullName="Mendy Falik"},
            };

            Names = (from n in Names
                     where n.FullName.Contains(filter)
                     select n).ToList<Person>();
                
            return Names;
        }
            
    }
}