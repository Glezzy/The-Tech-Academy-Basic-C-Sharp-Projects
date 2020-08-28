using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace step237_polymorphism
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Hello, my name is: ");
            base.SayName();
        }
    }
}
