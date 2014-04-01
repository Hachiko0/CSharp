using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.ExtensionMethodsLambdaLINQ
{
    public static class LINQ
    {
        public static IEnumerable FirstNameBeforeLast()
        {
            var students = new[]
            {  
                new { First = "Krasimir", Last = "Triov" },
                new { First = "Martin", Last = "Hristov" },
                new { First = "Ivan", Last = "Georgiev"},
                new { First = "Borko", Last = "Asenov" },
                new { First = "Asen", Last = "Blatechki" },
                new { First = "Anastatiq", Last = "Kodzakoli" }
            };
            //взимам само тези студенти, които първото им име е преди второто и след това ги сортирам по първо име
            //а ако първите им имена са еднакви сравнявам по второ
            var result =
                (from s in students
                 where s.First.CompareTo(s.Last) == -1
                 select s).OrderBy(x => x.First).ThenBy(x => x.Last);
            return result.ToList();
        }
        public static IEnumerable FindAgeBetweenInterval()
        {
            var students = new[]
            {  
                new { First = "Krasimir", Last = "Triov", Age = 15 },
                new { First = "Martin", Last = "Hristov", Age = 20 },
                new { First = "Ivan", Last = "Georgiev", Age = 18},
                new { First = "Borko", Last = "Asenov" , Age = 25},
                new { First = "Asen", Last = "Blatechki", Age = 36 },
                new { First = "Anastatiq", Last = "Kodzakoli", Age = 21 }
            };
            var result = from s in students
                         where s.Age >= 18 && s.Age <= 24
                         select new { First = s.First, Last = s.Last };
            return result.ToList();
        }
        public static IEnumerable SortByFirstLastNameDescendingWithLINQ()
        {
            var students = new[]
            {  
                new { First = "Krasimir", Last = "Triov", Age = 15 },
                new { First = "Martin", Last = "Hristov", Age = 20 },
                new { First = "Ivan", Last = "Georgiev", Age = 18},
                new { First = "Borko", Last = "Asenov" , Age = 25},
                new { First = "Asen", Last = "Blatechki", Age = 36 },
                new { First = "Anastatiq", Last = "Kodzakoli", Age = 21 }
            };
            var ordered = 
                from s in students
                orderby s.First descending, s.Last descending
                select s;
            return ordered;
        }

        public static IEnumerable SortByFirstLastNameDescendingWithLambda()
        {
            var students = new[]
            {  
                new { First = "Krasimir", Last = "Triov", Age = 15 },
                new { First = "Martin", Last = "Hristov", Age = 20 },
                new { First = "Ivan", Last = "Georgiev", Age = 18},
                new { First = "Borko", Last = "Asenov" , Age = 25},
                new { First = "Asen", Last = "Blatechki", Age = 36 },
                new { First = "Anastatiq", Last = "Kodzakoli", Age = 21 }
            };
            var ordered = students.OrderByDescending(x => x.First).ThenByDescending(x => x.Last);
            return ordered;
        }

        public static IEnumerable NumbersDivisibleByThreeAndSeven()
        {
            var array = new[] { 1, 2, 3, 4, 21, 5, 11, 42, 0 };
            return
                from a in array
                where a % (3 * 7) == 0
                select a;
        }
    }
}
