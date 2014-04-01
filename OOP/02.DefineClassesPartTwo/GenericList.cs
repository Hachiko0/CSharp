using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.DefineClassesPartTwo
{
    public class GenericList<T>
        where T: IComparable
    {
        private T[] arr;
        private int count = -1;

        public GenericList(int capacity = 8)
        {
            this.arr = new T[capacity];
        }

        private void AutoGrow()
        {
            T[] oldArr = new T[this.arr.Length];
            Array.Copy(this.arr, oldArr, this.arr.Length);
            this.arr = new T[arr.Length * 2];
            Array.Copy(oldArr, this.arr, oldArr.Length);
        }
        public void Add(T element)
        {
            this.count++;
            if (this.count == this.arr.Length)
            {
                this.AutoGrow();
            }
            this.arr[this.count] = element;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                T[] copyArray = new T[this.arr.Length];
                Array.Copy(this.arr, copyArray, this.arr.Length);
                this.arr = new T[this.arr.Length - 1];
                for (int i = 0, j = 0; i < this.arr.Length; i++,j++)
                {
                    if (i == index)
                    {
                        j++;
                    }
                    this.arr[i] = copyArray[j];
                }
                this.count--;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public void InsertAt(int index, T element)
        {
            count++;
            if (index >= 0 && index < this.arr.Length)
            {
                if (this.count == this.arr.Length)
                {
                    this.AutoGrow();
                }
                T[] copyArray = new T[this.arr.Length];
                Array.Copy(this.arr,copyArray,this.arr.Length);
                arr = new T[this.arr.Length];
                for (int i = 0, j = 0; i < this.arr.Length; i++,j++)
                {
                    if (i == index)
                    {
                        this.arr[i] = element;
                        i++;
                    }
                    this.arr[i] = copyArray[j];
                }
            }
        }

        public void ClearList()
        {
            this.arr = new T[0];
            this.count = 0;
        }

        public T Min()
        {
            T min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min.CompareTo(arr[i]) == 1)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max.CompareTo(arr[i]) < 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.arr.Length)
                {
                    return this.arr[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
            }
            set
            {
                if (index >= 0 && index < this.arr.Length)
                {
                    this.arr[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
            }
        }

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in this.arr)
            {
                result.AppendFormat("{0} ", item);
            }
            return result.ToString();
        }
    }
}
