using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step307_exceptions2
{
    class Program
    {
        public class InputException : Exception
        {
            public InputException() // polymorpthism to allow exception to be inherited
                : base() { }
            public InputException(string message) // overloads constructor
                : base(message) { }
        }
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
                if (age < 1)
                {
                    throw new InputException();
                }
                var today = DateTime.Now;

                string Date = DateTime.Now.ToShortDateString();

                var year1 = today.Year - age;      // Calculating year of birth

                // var year2 = today.Year - age - 1;    // Calculating year of birth

            Console.WriteLine("You were born in " + year1);
            }

            catch (FormatException)         // input error that was not a number. 
            {
                Console.WriteLine("Please enter only an integer");
            }
            catch (InputException)          // input errors of either <1 or a negative number.
            {
                Console.WriteLine("Error! You entered a zero or a negative number! Enter a number that is an actual age!");
            }
            catch (Exception)               // General errors
            { 
                Console.WriteLine("An Error ocurred. Please contact support so we can fix your computer promise?");    
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
