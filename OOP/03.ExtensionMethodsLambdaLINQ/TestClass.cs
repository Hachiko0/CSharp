using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _03.ExtensionMethodsLambdaLINQ
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class TestClass
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("krasimir");
            Console.WriteLine(sb.Substring(1, 7));
            Console.WriteLine(sb.Substring(1));

            List<long> numbers = new List<long>() { 1, 2, 3, 4 };
            Console.WriteLine("Average : {0}", numbers.Average());
            Console.WriteLine("Product : {0}", numbers.Product());
            Console.WriteLine("Min : {0}", numbers.Min());
            Console.WriteLine("Max : {0}", numbers.Max());
            Console.WriteLine("Sum : {0}", numbers.Sum());
            List<char> charr = new List<char>() { 'a', 'b', 'c' };

            var ordered = LINQ.FirstNameBeforeLast();
            var ageBetween = LINQ.FindAgeBetweenInterval();
            var divisible = LINQ.NumbersDivisibleByThreeAndSeven();
            PrintCollection(ordered);
            PrintCollection(ageBetween);
            PrintCollection(divisible);
            LINQ.SortByFirstLastNameDescendingWithLambda();
        }
        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-',30));
        }
    }
}
