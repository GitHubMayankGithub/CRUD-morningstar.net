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
            //Console.WriteLine()
            foreach(int num in querySyntax)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Hello World!");
            Console.Read();     
        }
    }
}
