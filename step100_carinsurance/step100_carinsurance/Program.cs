using System;

namespace step100_carinsurance
{
    class Program
    {
        static void Main()
        {
            // Adding Some Spice...ie Color :)
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Make sure applicant is old enough to drive
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            // Our AMAZINGLY LOW PRICE AWESOME insurance only allows the best applicants by asking a true/false question based on there word xD
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.Write(Environment.NewLine);
            
            // SAME AS ABOVE xDD 
            Console.WriteLine("How many speeding tickets do you have?");
            int speeding = Convert.ToInt32(Console.ReadLine());
            Console.Write(Environment.NewLine);

            // Prints true/false if they are qualified. 
            Console.WriteLine("Qualified?: ");
            Console.WriteLine(age > 15 && dui == false && speeding <= 3);
            Console.ReadLine();


        }
    }
}
