using System;
using System.Collections.Generic;
using System.Text;

namespace step240_quittableemployeebutnotmexd
{
    class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
