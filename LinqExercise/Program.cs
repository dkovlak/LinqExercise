using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine("~~~~~ Sum Of Numbers ~~~~~");
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine("\n~~~~~ Average Of Numbers ~~~~~");
            Console.WriteLine(average);

            //TODO: Order numbers in ascending order and print to the console
            var ascendingOreder = numbers.OrderBy(x => x);
            Console.WriteLine("\n~~~~~ Ascending Order Of Numbers ~~~~~");

            foreach (var i in ascendingOreder)
            {
                Console.WriteLine(i);
            }

            //TODO: Order numbers in descending order and print to the console
            var descendingOrder = numbers.OrderByDescending(x => x);
            Console.WriteLine("\n~~~~~ Descending Order Of Numbers ~~~~~");

            foreach (var i in descendingOrder)
            {
                Console.WriteLine(i);
            }

            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(x => x > 6);
            Console.WriteLine("\n~~~~~ Numbers Greater Than Six ~~~~~");

            foreach (var i in greaterThanSix)
            {
                Console.WriteLine(i);
            }

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var ascendingOreder2 = numbers.OrderBy(x => x).Take(4);
            Console.WriteLine("\n~~~~~ Ascending Order Of 4 Numbers ~~~~~");

            foreach (var i in ascendingOreder2)
            {
                Console.WriteLine(i);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            var descendingOrder2 = numbers.Select(x => x == 4 ? 19 : x).OrderByDescending(x => x);
            Console.WriteLine("\n~~~~~ Descending Order Of Numbers With My Age ~~~~~");

            foreach (var i in descendingOrder2)
            {
                Console.WriteLine(i);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var sort = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName);
            Console.WriteLine("\n~~~~~ Fist Name Starts With C Or S (Ascending Order) ~~~~~");

            foreach (var i in sort)
            {
                Console.WriteLine(i.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var sortAge = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            Console.WriteLine("\n~~~~~ Employees Over the Age of 26 (Ordered by Age and FirstName) ~~~~~");
            int count = 0;

            foreach (var i in sortAge)
            {
                Console.WriteLine($"Employee #{++count}: {i.FirstName} {i.Age} y.o.");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var YOE = employees.Where(x => x.YearsOfExperience <= 10 || x.Age > 35).Sum(x => x.YearsOfExperience);
            var average1 = employees.Where(x => x.YearsOfExperience <= 10 || x.Age > 35).Average(x => x.YearsOfExperience);

            Console.WriteLine("\n~~~~~ Sum And Average Of YOE  ~~~~~");
            Console.WriteLine($"YOE: {YOE}, Average: {average1}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            var newone = new Employee();
            newone.FirstName = "David";
            newone.LastName = "Kovlak";
            var newEmployees = employees.Append(newone);

            foreach (var i in newEmployees)
            {
                Console.WriteLine($"Employee #{++count}: {i.FullName}");
            }

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
