using System;
using System.Collections.Generic;
using System.Text;

namespace step164_moreclassesandmethodspractice
{
    public class Math
    {
        public int Operation(int x, int y)
        {
            return x + y;
        }

        public int Operation(decimal x, decimal y)
        {
            return Convert.ToInt32(x - y);
        }

        public int Operation(string x, string y)
        {
            return Convert.ToInt32(x) * Convert.ToInt32(y);
        }
    }
}
