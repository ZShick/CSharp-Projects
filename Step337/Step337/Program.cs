using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step337
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list to hold all employees and instances of 10 different employees
            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Employee employee6 = new Employee();
            Employee employee7 = new Employee();
            Employee employee8 = new Employee();
            Employee employee9 = new Employee();
            Employee employee10 = new Employee();

            //giving all 10 employees different names, and Id numbers before adding them to the list
            employee1.FirstName = "Sarah";
            employee1.LastName = "Jones";
            employee1.Id = 1;
            employees.Add(employee1);

            employee2.FirstName = "Joe";
            employee2.LastName = "Kent";
            employee2.Id = 2;
            employees.Add(employee2);

            employee3.FirstName = "Zach";
            employee3.LastName = "King";
            employee3.Id = 3;
            employees.Add(employee3);

            employee4.FirstName = "Jose";
            employee4.LastName = "Alvarez";
            employee4.Id = 4;
            employees.Add(employee4);

            employee5.FirstName = "Mario";
            employee5.LastName = "Luigi";
            employee5.Id = 5;
            employees.Add(employee5);

            employee6.FirstName = "Captain";
            employee6.LastName = "Kirk";
            employee6.Id = 6;
            employees.Add(employee6);

            employee7.FirstName = "Sponge";
            employee7.LastName = "Robert";
            employee7.Id = 7;
            employees.Add(employee7);

            employee8.FirstName = "Joe";
            employee8.LastName = "Sloppy";
            employee8.Id = 8;
            employees.Add(employee8);

            employee9.FirstName = "Bruce";
            employee9.LastName = "Wayne";
            employee9.Id = 9;
            employees.Add(employee9);

            employee10.FirstName = "Arwen";
            employee10.LastName = "Luthien";
            employee10.Id = 10;
            employees.Add(employee10);

            //Below is the Non Lambda version of sorting through the employees list and creating a new list of those who have the first name Joe
            //it is commented out because it is followed by the Lambda version

            //List<Employee> TheJoes = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        TheJoes.Add(employee);
            //    }
            //}

            //foreach (Employee employee in TheJoes)
            //{
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //}

            //Lambda version of the same thing. Sorts through the employees list and creates a new list of all the Joes
            List<Employee> LambdaJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in LambdaJoe)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }


            //another Lambda function that creates a list of all the employees with an Id greater than 5
            List<Employee> IdMoreThan5 = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in IdMoreThan5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine();
        }
    }
}
