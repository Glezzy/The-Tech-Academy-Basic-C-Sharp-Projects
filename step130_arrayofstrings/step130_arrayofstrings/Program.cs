using System;
using System.Collections.Generic;
using System.Threading;

namespace assignment_page_129
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // 1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] stringArray = {"Red", "Blue", "Yellow", "Green", "Ocean Blue"};
            SlowType(50, "The program will now display a specified string stored in an array depending on your response.\nPlease choose a number from 1 to 5: ");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            bool check1 = true;

            do
            {
                if (answer1 >= 1 && answer1 <= 5)
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine(stringArray[answer1 - 1]);
                    Console.ReadLine();
                    check1 = false;
                }
                // 3. Add in a message that displays when the user selects an index that doesn’t exist.
                else
                {
                    SlowType(50, "Incorrect input.");
                    Console.Write(Environment.NewLine);
                    SlowType(50, "Please choose a number from 1 to 5: ");
                    answer1 = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (check1);

            // 2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] intArray = { 10, 20, 30, 40, 50 };
            SlowType(50, "The program will now display a specified integer stored in an array depending on your response.\nPlease choose a number from 1 to 5: ");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            bool check2 = true;

            do
            {
                if (answer2 >= 1 && answer2 <= 5)
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine(intArray[answer2 - 1]);
                    Console.ReadLine();
                    check2 = false;
                }
                // 3. Add in a message that displays when the user selects an index that doesn’t exist.
                else
                {
                    SlowType(50, "Incorrect input.");
                    Console.Write(Environment.NewLine);
                    SlowType(50, "Please choose a number from 1 to 5: ");
                    answer2 = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (check2);

            // 4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> stringList = new List<string>();
            stringList.Add("Peg 35 Blue");
            stringList.Add("Peg 35 Grey");
            stringList.Add("Peg 36 Black");
            stringList.Add("Tempo Black");
            stringList.Add("Cascadia 13 Blue");
            SlowType(50, "The program will now display a specified string stored in a list depending on your response.\nPlease choose a number from 1 to " + stringList.Count + ": ");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            bool check3 = true;

            do
            {
                if (answer3 >= 1 && answer3 <= stringList.Count)
                {
                    Console.Write(Environment.NewLine);
                    SlowType(50, stringList[answer3 - 1]);
                    Console.ReadLine();
                    check3 = false;
                }
                // 3. Add in a message that displays when the user selects an index that doesn’t exist.
                else
                {
                    SlowType(50, "Incorrect input.");
                    Console.Write(Environment.NewLine);
                    SlowType(50, "Please choose a number from 1 to " + stringList.Count + ": ");
                    answer3 = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (check3);

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
}
