using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtDelegate
{
    
    internal class Program
    {
        public delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            SimpleMath simpleMath = new SimpleMath();
            Operation operation = new Operation(simpleMath.Add);
            int result=operation(10, 2);
            Console.WriteLine(result);

            Operation operation2 = new Operation(simpleMath.Subtract);
            int result2=operation2(10, 2);
            Console.WriteLine(result2);

            Operation operation3 = new Operation(simpleMath.Multiply);
            int result3 = operation3(10, 2);
            Console.WriteLine(result3);

            Operation operation4 = new Operation(simpleMath.Divide);          
            Console.WriteLine(operation4.Invoke(10,2));
        }
    }
}
