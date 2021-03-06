using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Car
    {
        public int ID { get; set; }
        public string Owner { get; set; }
        public int Model { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Owner: {Owner}; Model#: {Model}; ID#: {ID}");
            return result.ToString();
        }
    }
}
