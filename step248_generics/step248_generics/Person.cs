using System;
using System.Collections.Generic;
using System.Text;

namespace step248_generics
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
