using System;
using System.Linq.Expressions;

namespace step165_classesandmethodspart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            try
            {
                Console.WriteLine("Please enter a single number or two numbers whose sum will be divided by 4:  ");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter your first number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number: ");
                string temp = Console.ReadLine();

                if (temp == "")
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Calculating...");
                    Console.WriteLine(number1 + "/ 4 = " + math.Operation(number1));
                }
                else
                {
                    int number2 = Convert.ToInt32(temp);

                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Calculating...");
                    Console.WriteLine("(" + number1 + " + " + number2 + ") / 4 = " + math.Operation(number1, number2));
                }

            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
            }
                

                Console.ReadLine();
        }
    }
}
