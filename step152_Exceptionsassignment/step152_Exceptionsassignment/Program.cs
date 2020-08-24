﻿using System;
using System.Collections.Generic;

namespace step152_Exceptionsassignment
{
    class Program
    {
        static void Main()
        {
            List<int> integers = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                integers.Add(rnd.Next(1, 100));
            }

            try
            {
                Console.WriteLine("Please enter a number to divide each number in the pre-generated integer list by: ");
                int input = Convert.ToInt32(Console.ReadLine());

                foreach (int integer in integers)
                {
                    Console.WriteLine(integer + " divided by " + input + " equals " + (integer / input));
                }
            }
            catch (FormatException)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter an integer.");
            }
            catch (DivideByZeroException)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Unable to divide by zero.");
            }
            catch (Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}