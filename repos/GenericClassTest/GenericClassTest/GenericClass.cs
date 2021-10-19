using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassTest
{
    class GenericClass<T>
    {
        private T[] t1;
        public GenericClass(int size)
        {
            t1 = new T[size+1];           
        }

        public void SetItem(int index,T value)
        {
            t1[index] = value;
        }

        public T GetItem(int index)
        {
            return t1[index];
        }
    }
}
