using System;

namespace Step89_mathandcomparisonoperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            // Weeks in a year
            int weeksinyear = 52;


            // Person 1
            Console.WriteLine("Jimbo");
            Console.Write("What is your hourly salary?: ");
            double jimboperhour = Convert.ToDouble(Console.ReadLine());
            // stingy company so we only pay on the hour hehe
            Console.Write("How many hours did you work this week? Make sure to round!: ");
            int jimbohoursworked = Convert.ToInt32(Console.ReadLine());
            // Person 2 
            Console.WriteLine("Nathan");
            Console.Write("What is your hourly salary?: ");
            double nathanperhour = Convert.ToDouble(Console.ReadLine());
            // hours worked for Nathan
            Console.Write("How many hours do you work on average?: ");
            double nathanhoursworked = Convert.ToDouble(Console.ReadLine());

            // Annual Salary Section
            int Jimbo, Nathan;
            Console.Write("Annual Salary of Jimbo: ");
            Jimbo = (int)(jimboperhour * jimbohoursworked * weeksinyear);
            Console.WriteLine(Jimbo);

            Console.Write("Annual Salary of Nathan: ");
            Nathan = (int)(nathanperhour * nathanhoursworked * weeksinyear);            
            Console.WriteLine(Nathan);

            Console.Write("Does Jimbo make more money than Nathan? ");
            bool n = Jimbo > Nathan;
            Console.WriteLine(n.ToString());
        }
    }
}
