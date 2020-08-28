using System;
using System.Collections.Generic;
using System.Text;

namespace step240_quittableemployeebutnotmexd
{
    class Employee : person, Quit
    {
        public override void SayName()
        {
            Console.WriteLine("Hello, my name is: ");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("I quit because I found 100k software dev job and was just smurfing here. :p");
            Console.ReadLine();
        }
    }
}
