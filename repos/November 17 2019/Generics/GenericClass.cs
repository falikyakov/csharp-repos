using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericClass<T>
    {
        private T[] array;
        public GenericClass(int size)
        {
            array = new T[size + 1];
        }
        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
            

    }
}
