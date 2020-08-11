using System;

namespace Step71_dailyreport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"True or False\".");

            Console.WriteLine("Where there any positive experiences you would like to share? Please give specific.");

            Console.WriteLine("Is there any other feedback your would like to share? Please be specific.");

            Console.WriteLine("How many hours did you study today?");



        }
    }
}
