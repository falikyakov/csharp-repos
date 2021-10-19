using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_9._8._19__4
{
    class Program
    {
        static void Main(string[] args)
        {
            //object initializer:
            Student w = new Student { Age = 969, Name = "Mesushelach" };

            //working with 'out' parameter
            Student q;

            // 'out' does not necessitate initiating instance first
            Stam2(out q);
            Console.WriteLine(q.Name);
        }


        // 'out' does not necessitate initiating instance first
        static void Stam2(out Student b)
        {
            b = new Student();
            b.Name = "Moishy";
            b.Age = 900;
        }
    }

    public class Student
    {
        public string Name;
        public int Age;

        //public Student(string Name, int Age)
        //{
        //    this.Name = Name;
        //    this.Age = Age;
        //}
    }
}
