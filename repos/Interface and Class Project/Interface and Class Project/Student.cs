using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Class_Project
{
    class Student : Acquaintance, IPerson, ISchool
    {
        public string Name { get; set; }
        public int Age { get;set }
        public string SchoolName { get; set; }
        public string SchoolDistrict { get; set; } 
    }
}
