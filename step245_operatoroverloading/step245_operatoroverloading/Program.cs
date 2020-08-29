using System;

namespace step245_operatoroverloading
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Id = 1612;
            
            Employee employee2 = new Employee();
            employee2.Id = 1558;

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();

            Employee employee3 = new Employee();
            employee3.Id = 1935;

            Employee employee4 = new Employee();
            employee4.Id = 0248;

            Console.WriteLine(employee3 == employee4);
            Console.WriteLine(employee3 != employee4);
        }
    }
}
