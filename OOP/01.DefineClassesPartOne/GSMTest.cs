using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
/* Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S. */

namespace _01.DefineClassesPartOne
{
    public class GSMTest
    {
        static void Main()
        {
            string[] models = { "6300", "4S", "3310", "Galaxy S", "Galaxy S4" };
            string[] manufacturer = { "Nokia", "Iphone", "Nokia", "Samsung", "Samsung" };
            decimal[] price = { 400, 1000, 200, 600, 1100 };
            string[] owner = { "Peter Petrov", "Ivan Ivanov", "Hristo Hristov", "Dobri Dobrilov", "Georgi Georgiev" };
            Battery[] batteries = { new Battery(1, 10), new Battery(2, 9), new Battery(3), 
                                      new Battery(4, 7, BatteryType.NiCd),new Battery(5,6,BatteryType.LiIon) };

            Display[] displays = { new Display(),new Display("120x130"), new Display("130x140",16000),
                                     new Display("140x150",17000),new Display("150x160")};

            GSM[] gsms = new GSM[5];

            for (int i = 0; i < 5; i++)
            {
                //create new instance 
                gsms[i] = new GSM(models[i], manufacturer[i], price[i], owner[i], batteries[i], displays[i]);
                //print all the information about the current instance
                Console.WriteLine(gsms[i].ToString());
                Console.WriteLine();
            }

            GSM iphone = GSM.IPhone4S;
            List<Call> calls = new List<Call>();
            calls.Add(new Call("03.03.2013", "10h:25m:30s", "0886 213 456", 340));
            calls.Add(new Call("24.05.2013", "11h:36m:14s", "0887 142 321", 410));
            calls.Add(new Call("06.09.2013", "21h:02m:45s", "0889 541 906", 215));
            for (int i = 0; i < calls.Count; i++)
            {
                iphone.AddCall(calls[i]);
                Console.WriteLine(iphone.CallHistory[i]);
                Console.WriteLine();
            }
            decimal totalPriceOfCalls = iphone.CalculateTotalPriceOfCalls();
            Console.WriteLine("Total price of the calls : {0}", totalPriceOfCalls);
            int longestCall = iphone.FindLongestCallDuration();
            iphone.RemoveCall(longestCall);
            totalPriceOfCalls = iphone.CalculateTotalPriceOfCalls();
            Console.WriteLine("Total price of calls without the longest call : {0}", totalPriceOfCalls);
            iphone.ClearCallHistory();

            int[] arr = new int[8];
            for (int i = 0; i < arr.Length; i++)
            {
                int start = i;
                arr[i] = int.Parse(Console.ReadLine());
                for (int j = i - 1; j >= 0; j--, i--)
                {
                    if (arr[j] > arr[i])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                    else
                    {
                        break;
                    }
                }
                i = start;
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
