using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class Person:DbContext 
    {
        public int ID { get; set; }
        public string FullName { get; set; } 
    }
}