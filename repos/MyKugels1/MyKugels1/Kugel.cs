using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKugels1
{
    class Kugel:IKugels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IngredientsFilePath { get; set; }

    }
}
