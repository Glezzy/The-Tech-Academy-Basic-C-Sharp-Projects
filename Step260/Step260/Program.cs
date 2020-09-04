using System;

namespace Step260
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 2.5799m;

            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }

    public struct Number
    {
        public decimal Amount { get; set; }
    }
}
