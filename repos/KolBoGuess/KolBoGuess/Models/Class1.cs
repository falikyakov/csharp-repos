using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KolBoGuess.Models
{
    public class Class1
    {
        public int YourNumber(int a, int b, int c)
        {
            int sub_a = a * 15;
            int sub_b = b * 21;
            int sub_c = c * 70;
            int subTotal = (sub_a+sub_b+sub_c);
            int total;

            if (subTotal>315)
            {
                total = subTotal - 315;
            }
            else if (subTotal > 210)
            {
                total = subTotal - 210;
            }
            else if (subTotal > 105)
            {
                total = subTotal - 105;
            }
            else
            {
                total = subTotal;
            }

            return total;
        }
    }
}