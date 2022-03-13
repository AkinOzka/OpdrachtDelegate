using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDelegate
{   
    public class SimpleMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
