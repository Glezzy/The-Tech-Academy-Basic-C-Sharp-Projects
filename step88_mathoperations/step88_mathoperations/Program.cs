using System;

namespace step88_mathoperations
{
    class Program
    {
        static void Main()
        {
            int n1, n2, n3, n4, n5;

            Console.Write("Taking a number and multiply it by 50: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            int result1 = n1 * 50;
            Console.WriteLine(result1);

            Console.Write("Take a number and add 25: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            int result2 = n2 + 25;
            Console.WriteLine(result2);

            Console.Write("Take any number and divide by 12.5: ");
            n3 = (int)Convert.ToDecimal(Console.ReadLine());
            double result3 = (double)(n3 / 12.5m);
            Console.WriteLine(result3);

            Console.Write("Take a number and see if it is greater than 50: ");
            n4 = Convert.ToInt32(Console.ReadLine());
            bool x = n4 > 50;
            Console.WriteLine(x.ToString());

            Console.Write("Take any number and print the remainder when dividing by 7: ");
            n5 = Convert.ToInt32(Console.ReadLine());
            int result5 = n5 % 7;
            Console.WriteLine(result5);

        }
    }
}
