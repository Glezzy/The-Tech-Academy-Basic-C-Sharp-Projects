using System;
using System.Collections.Generic;

namespace step248_generics
{
    class Program
    {
        static void Main()
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>();
            employee1.Things.Add("Coffee");
            employee1.Things.Add("Bean");
            employee1.Things.Add("Boy");

            Employee<int> employee2 = new Employee<int>();
           employee2.Things = new List<int>();
            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);

            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
