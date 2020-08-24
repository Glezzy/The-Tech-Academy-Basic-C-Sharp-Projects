using System;

namespace step169_methodswithoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide divide = new Divide();

            Console.WriteLine("Please enter a number to be divided by 2: ");
            int input = Convert.ToInt32(Console.ReadLine());

            divide.Operation(input, out int result);

            Console.Write(Environment.NewLine);

            Console.WriteLine(input + " / 2 = " + result);

            Console.Write(Environment.NewLine);

            Console.WriteLine(MyStaticClass.Desc);
            Console.ReadLine();

        }
    }
}
