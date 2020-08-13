using System;
using System.Text;
using System.Threading;

namespace assignment_page_125
{
    class Program
    {
        static void Main()
        {
            string s1 = "Country road ";
            string s2 = "Take me home ";
            string s3 = "To the place I belong.";

            SlowType(50, s1.ToUpper() + s2 + s3.ToUpper());
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("Sometimes, I wake up in the morning, \n");
            sb.Append("To, red, blue, and yellow skies, \n");
            sb.Append("It's so crazy, I could drink it like tequila sunrise, \n");
            sb.Append("Put on that Hotel California, \n");
            sb.Append("Dance around like I'm insane, \n");
            sb.Append("I feel free when I see no one, \n");
            sb.Append("And nobody knows my name. \n");

            Console.WriteLine(sb);
            Console.ReadLine();

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
