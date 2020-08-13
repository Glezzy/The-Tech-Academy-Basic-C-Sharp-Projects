using System;
using System.Threading;


namespace step121_booleancomparisons
{
    class Program
    {
        static void Main()
        {
            // Set color of text and title
            Console.Title = "Glezzy Coffee/Tea Recommendations";
            Console.WriteLine("{0}", Console.Title);
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Add slow type animation
            
            SlowType(50, "Do you prefer coffee or tea? Please type \"coffee\" or \"tea\". ");
            string answer1 = Console.ReadLine().ToLower();
            bool check1 = true;
            Console.Write(Environment.NewLine);

            while (check1)
            {
                switch (answer1)
                {
                    case "coffee":
                        SlowType(50, "Then you should try our flagship Tunnel Viz roast, it will take you out of this world! ;) ");
                        Console.Write(Environment.NewLine);
                        check1 = false;
                        break;
                    case "tea":
                        SlowType(50, "That's cool here is some hot water the tea packets are over there zzz ");
                        Console.Write(Environment.NewLine);
                        check1 = false;
                        break;
                    default:
                        SlowType(50, "Incorrect input. ");
                        Console.Write(Environment.NewLine);
                        SlowType(50, "Do you prefer coffee or tea? ");
                        answer1 = Console.ReadLine().ToLower();
                        Console.Write(Environment.NewLine);
                        break;
                }
            }

           SlowType(50, "Cream, sugar or both in your coffee? Please type \"cream\" or \"sugar\" or \"both\". ");
            string answer2 = Console.ReadLine().ToLower();
            bool check2 = true;
            Console.Write(Environment.NewLine);

            do
            {
                switch (answer2)
                {
                    case "cream":
                        SlowType(50, "Great! You should try are homemade cream we get it from the cows out back. ");
                        Console.Write(Environment.NewLine);
                        check2 = false;
                        break;
                    case "sugar":
                        SlowType(50, "Nice! Here is our all natural sugar that we source from Africa. ");
                        Console.Write(Environment.NewLine);
                        check2 = false;
                        break;
                    case "both":
                        SlowType(50, "I mean is it even coffee anymore? Starbucks is across the street dude I recommend leaving, k? ");
                        Console.Write(Environment.NewLine);
                        check2 = false;
                        break;

                    default:
                        SlowType(50, "Incorrect input.");
                        Console.Write(Environment.NewLine);
                        SlowType(50, "Cream, sugar or both in your coffee? Please type \"cream\" or \"sugar\" or \"both\". ");
                        answer2 = Console.ReadLine().ToLower();
                        Console.Write(Environment.NewLine);
                        break;
                }
            }
            while (check2);
        }
            static void SlowType(int milsec_delay, string str)
            {
                foreach (char c in str)
                {
                    Console.Write(c);
                    Thread.Sleep(milsec_delay);
                }
            }
        
    }
}
