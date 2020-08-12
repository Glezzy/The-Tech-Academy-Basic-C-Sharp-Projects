using System;

namespace step100_carinsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.WriteLine("How many speeding tickets do you have?");
            int speeding = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.WriteLine("Qualified?: ");
            Console.WriteLine(age > 15 && dui == false && speeding <= 3);
            Console.ReadLine();


        }
    }
}
