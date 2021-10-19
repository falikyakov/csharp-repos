using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_9._8._19__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Dani", 28);
            Stam(ref a);

            Console.WriteLine(a.Name);

            
        }

        public static void Stam(ref Student s) 
        {
            Console.WriteLine(s.Name);
            s = null;
        }
    }

    class Student
    {
        public  string Name;
        public int Age;

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
