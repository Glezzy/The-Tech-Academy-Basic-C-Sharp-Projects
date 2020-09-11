using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Step265_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
               new Employee { FirstName = "Joe", LastName = "Naismith", Id=1 },
                new Employee { FirstName = "Ricky", LastName = "Niasmith", Id=2  },
                new Employee { FirstName = "Jimbo", LastName = "Collins", Id=3 },
                new Employee { FirstName = "Frank", LastName = "Freud", Id=4 },
                new Employee { FirstName = "Timmy", LastName = "Timmons", Id=5 },
                new Employee { FirstName = "Jimmy", LastName = "Jones", Id=6 },
                new Employee { FirstName = "Joe", LastName = "Naysmith", Id=7 },
                new Employee { FirstName = "Baxter", LastName = "Berry", Id=8 },
                new Employee { FirstName = "Berry", LastName = "Baxter", Id=9 },
                new Employee { FirstName = "Scooter", LastName = "Smith", Id=10 },
            };

            List<Employee> thejoes = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    thejoes.Add(employee);
                }
            }

            List<Employee> thejoes2 = new List<Employee>();
            thejoes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee person in thejoes2)
            {
                Console.WriteLine("Name " + person.FirstName + " Added to the thejoes2 using Lambda.");
            }

            List<Employee> idlist = new List<Employee>();
            idlist = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee personid in idlist)
            {
                Console.WriteLine("Name: " + personid.FirstName + " ID: " + personid.Id);
            }
            Console.ReadLine();
        }
    }
}
