using System;

namespace step174_inheritance
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.FirstName = "Mr.";
            employee.LastName = "Jenkins";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
