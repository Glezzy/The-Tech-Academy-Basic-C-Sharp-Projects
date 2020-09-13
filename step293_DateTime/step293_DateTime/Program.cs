using System;

namespace step293_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is: " + currentTime);
            Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("This will add 7 hours to the time you entered. : " + currentTime.AddHours(userNumber));
        }
    }
}
