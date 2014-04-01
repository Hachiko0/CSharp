using System;
using System.Collections.Generic;

namespace GenericClass
{
    public class GenericClassTest
    {
        static void Main()
        {
            GenericListCustom<int> list = new GenericListCustom<int>();
            Console.WriteLine(list);
            for (int i = 0; i < 15; i++)
            {
                list.Add(i + 1);
            }
            foreach (var item in list)
            {
                Console.Write(item);
            }
            //Console.WriteLine(list);
            //list.InsertAt(15, 666);
            //Console.WriteLine(list);
            //list.RemoveAt(5);
            //Console.WriteLine(list);
            //list.Clear();
            //Console.WriteLine(list);
            
        }
    }
}

