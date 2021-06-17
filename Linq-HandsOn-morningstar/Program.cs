using System;
using System.Collections.Generic;
using System.Linq;


namespace Linq_HandsOn_morningstar
{
    class Program
    {
        static void Main(string[] args)
        {
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
            var mixedSyntax=(from obj in list
                             select obj).Max();
            Console.WriteLine("Max is = "+mixedSyntax);


        }
    }
}
