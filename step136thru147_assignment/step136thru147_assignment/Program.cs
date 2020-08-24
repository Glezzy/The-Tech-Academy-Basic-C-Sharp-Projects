using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace step136thru147_assignment
{
    class Program
    {
        private const bool V = false;

        static void Main()
        {
            // step 137 Create a one-dimensional Array of strings. 
            // Ask the user to input some text. 
            // Create a loop that goes through each string in the Array, adding the 
            // user's text to the string.
            // Then create a loop that prints off each string in the Array on a separate line. 
            string[] inputs = { "", "", "" };

            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine("Please enter some text to populate inputs[" + i + "]: ");
                inputs[i] = Console.ReadLine();
                Console.Write(Environment.NewLine);
            }

            for (int j = 0; j < inputs.Length; j++)
            {
                Console.WriteLine("The text in inputs[" + j + "] is: " + inputs[j]);
                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
            // step 138
            // for (int a = 0; a < 50; a--) this  line of code will run forever.            
            // Console.WriteLine("value : {0}", a);  this line of code will run forever.
            // step 139 fixing infinite loop.
            bool check = true;
            while (check)
            {
                Console.WriteLine("This is not eternity");
                check = false;
            }
            Console.ReadLine();
            // step 140  Creating a loop where the comparison that's used to determine whether to 
            // continue iterating the loop is a "<" operator. 
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number < 50)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine(number + " is less than 50.");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine(number + " is greater than 50.");
            Console.ReadLine();
            // step 141 
            // Create a loop where the comparison that’s used to determine whether to 
            // continue iterating the loop is a “<=” operator.
            Console.WriteLine("Please enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            while (number2 <= 50)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine(number2 + " is less than or equal to 50.");
                Console.Write(Environment.NewLine);
                Console.WriteLine("Please enter a number: ");
                number2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine(number2 + " is greater than 50.");
            Console.ReadLine();
            // step 142
            // Create a List of strings where each item in the list is unique. 
            // Ask the user to input text to search for in the List. Create a loop that iterates through the List 
            // and then displays on the screen the index of the List item that matches the user input.
            List<string> doggos = new List<string>();
            doggos.Add("Husky");
            doggos.Add("German Shepard");
            doggos.Add("Coonhound");
            doggos.Add("Golden Retriever");
            doggos.Add("Coonhound");
            doggos.Add("Australian Shepard");

            Console.WriteLine("Please guess a word in the list. Hint the list is the names of my favorite dog breeds. ");
            StringBuilder input = new StringBuilder(Console.ReadLine());
            input[0] = Char.ToUpper(input[0]);
            string guess2 = input.ToString();
            bool check2 = false;
            foreach (string dog in doggos)
            {
             while (!check2)
                if (guess2 == dog)
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Correct guess. " + dog + " is in the list.");
                    break;
                }
                // step 143 
                else
                {
                    Console.Write(guess2 + " is not in the list.");
                    Console.Write("Please guess again a different dog breed on the list: ");
                        
                }
            }
            Console.ReadLine();
            // step 144 Add code to that above loop that stops it from executing once a match has been found.
            List<string> doggos2 = new List<string>();
            doggos2.Add("Husky");
            doggos2.Add("German Shepard");
            doggos2.Add("Coonhound");
            doggos2.Add("Golden Retriever");
            doggos2.Add("Coonhound");
            doggos2.Add("Australian Shepard");

            Console.WriteLine("Please guess a dog breed on the list: ");
            StringBuilder input2 = new StringBuilder(Console.ReadLine());
            input2[0] = Char.ToUpper(input2[0]);
            string guess3 = input2.ToString();
            bool check3 = false;
                
                    foreach (string dog2 in doggos2)
                    {
                        if (guess3 == dog2)
                        {
                            Console.Write(Environment.NewLine);
                            Console.WriteLine("Correct guess. " + dog2 + " is in the list.");
                            check3 = true;
                            break;
                        }
                    }
                    if (check3 == false)
                    {
                        Console.Write(Environment.NewLine);
                        Console.WriteLine(guess3 + " is not on the list. ");     
                        Console.Write(Environment.NewLine);
                        Console.WriteLine("Please guess a different dog breed.");
                    }
        

        Console.ReadLine();
            // step 145
            // Create a List of strings that has at least two identical strings in the List. 
            // Ask the user to select text to search for in the List. Create a loop that iterates 
            // through the loop and then displays the indices of the array that contain matching 
            // text on the screen.
            List<string> stringList = new List<string>();
            stringList.Add("yes");
            stringList.Add("yes");
            stringList.Add("no");
            stringList.Add("yes");

            Console.WriteLine("Please enter yes or no: ");
            string guess4 = Console.ReadLine().ToLower();

            for (int i = 0; i < stringList.Count; i++)
            {
                if (guess4 == stringList[i])
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("stringList[" + i + "] = \"" + stringList[i] + "\"");
                }
            }

            Console.ReadLine();

            // step 146 
            // Add code to that above loop that tells a user if they put in text that isn’t in the List.

            Console.WriteLine("Please enter yes or no: ");
            string guess5 = Console.ReadLine().ToLower();
            bool check4 = false;

            for (int i = 0; i < stringList.Count; i++)
            {
                if (guess5 == stringList[i])
                {
                    Console.Write(Environment.NewLine);
                    Console.WriteLine("stringList2[" + i + "] = \"" + stringList[i] + "\"");
                    check4 = true;
                }
            }

            if (check4 == false)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine(guess5 + " is not in the list.");
            }

            Console.ReadLine();

            // step 147
            // Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, and displays a message 
            // showing the string and whether or not it has already appeared in the list.

            SlowType(50, "Let's see if there are any duplicates in the dog breed list we made earlier. \n");
            Console.Write(Environment.NewLine);

            var distinct = new List<string>();
            var duplicates = new List<string>();


            foreach (var doggo in doggos)
            {
                if (!distinct.Contains(doggo))
                    distinct.Add(doggo);
                else
                    duplicates.Add(doggo);
            }
            foreach (var doggo in distinct)

                SlowType(50, "The doggo breed " + doggo + " has not already appeared in the list. \n");
            Console.Write(Environment.NewLine);
            foreach (var doggo in duplicates)

                SlowType(50, "The doggo breed " + doggo + " has already appeared in the list. \n");
            Console.Write(Environment.NewLine);

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

