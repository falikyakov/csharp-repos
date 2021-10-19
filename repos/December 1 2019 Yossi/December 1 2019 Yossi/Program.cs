using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace December_1_2019_Yossi
{
    class Program
    {
        static void Main(string[] args)
        {
            Family Levi = new Family { Abba = "Shmuel", Ima = "Mina" };
            Levi.Children.AddRange(new[] { "Dani", "Dudi" });

            //using the revamped IEnumerable-GetEnumerator()
            foreach (string familyMember in Levi)
            {
                Console.WriteLine(familyMember);
            }

            //using the indexer
            Console.WriteLine(Levi[1]);

            Console.ReadLine();
        }
    }


    public class Family : IEnumerable
    {
        public string Abba { get; set; }
        public string Ima { get; set; }
        public List<string> Children { get; set; }

        public string  this[int i] {
            get { return Children[i]; }
            set { } }

        public Family()
        {
            Children = new List<string>();
        }

        public void AddChild(string name)
        {
            Children.Add(name);
        }

        //this is an override of the foreach function (foreach in general uses the Enumerator)
        public IEnumerator GetEnumerator()
        {
            yield return "Father's name is: " + Abba;
            yield return "Mother's name is: " + Ima;
            int i = 1;
            foreach (string child in Children)
            {
                yield return $"Child {i}'s name is :" + child;
                i++;
            }
        }
    }
}
