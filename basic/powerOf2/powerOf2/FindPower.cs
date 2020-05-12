using System;
using System.Collections.Generic;
using System.Text;

namespace powerOf2
{
    class FindPower
    {
        public static int powerOf2(int value)
        {
            int finalValue = 1;
            for (int i = 1; i <=value; i++)
            {
                finalValue *= 2;
            }
            return finalValue;
        }
    }

}
