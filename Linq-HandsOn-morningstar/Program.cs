using System;
using System.Collections.Generic;
using System.Linq;


namespace Linq_HandsOn_morningstar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region typesOfQuerySyntax
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var querySyntax = from obj in list
                              where Convert.ToInt32(obj) > 5
                              select obj;
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Query Syntax");
            Console.WriteLine("---------------------------");
            foreach (int num in querySyntax)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Method Syntax");
            Console.WriteLine("---------------------------");
            var methodSyntax = list.Where(obj => obj > 2);
            foreach (int num in methodSyntax)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Mixed Syntax");
            Console.WriteLine("---------------------------");
            var mixedSyntax = (from obj in list
                               select obj).Max();
            Console.WriteLine("Max is = " + mixedSyntax);
            #endregion

            #region IEnumerableExample
            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> querySyntax2 = from obj in list
                              where Convert.ToInt32(obj) > 5
                              select obj;
            #endregion

            #region ProjectionOperationInLINQ
            List<Employee> employee = new List<Employee>()
            {
              new Employee(){Id = 1, Name = "Mayank", EmailId="mayank@gmail.com" },
               new Employee() { Id = 2, Name = "Mayank", EmailId = "mayank@gmail.com" },
               new Employee() { Id = 3, Name = "Mayank", EmailId = "mayank@gmail.com" },
               new Employee() { Id = 4, Name = "Mayank", EmailId = "mayank@gmail.com" }
            };

            var basicQuery = (from emp in employee
                              select emp).ToList();

            var basicMethod =  employee
                             .ToList();

            var basicPropQuery = (from emp in employee
                              select emp.Id).ToList();

            var basicPropMethod =employee.Select(
                employee=>employee.Id).ToList();

            var basicPropMethod2 = employee.Select(
                employee => employee.Id+1).ToList();


            #endregion
        }
    }

    public class Employee
    {

        public int Id;
        public string Name;
        public string EmailId;
    }
}
