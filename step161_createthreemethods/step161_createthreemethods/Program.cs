using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step161_createthreemethods
{
    class Program
    {
        static void Main()
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number to be added by 34, multiplied by 3, and divided by 9: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number + " + 34 = " + math.Add(number) + "\n" + number + " * 2 = " + math.multiply(number) + "\n" + number + " / 2 = " + math.divide(number));

            Console.ReadLine();
        }
    }
}
