using System;
using System.Collections.Generic;
using ExtensionMethodsDelegatesLambdaLINQ;

namespace GenericClass
{
    public class GenericClass<T>
        where T : IComparable
    {
        private T a;
        private T b;
        private T[] arr;
        private int count;

        public GenericClass(int elements)
        {
            arr = new T[elements];
        }

        public int this[T value]
        {
            get
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (value.CompareTo(arr[i]) == 0)
                    {
                        return i;
                    }
                }
                throw new ArgumentException("Cant find the value");
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
                arr[index] = value;
            }
        }
        public T MaxProperty
        {
            get
            {
                if (a.CompareTo(b) == 1)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
        }

        public dynamic Ehoo(dynamic a, dynamic b)
        {
            return a + b;
        }
        public T Max()
        {
            if (a.CompareTo(b) == 1)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}