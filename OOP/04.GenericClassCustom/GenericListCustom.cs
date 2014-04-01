using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericListCustom<T>
       where T : IComparable
    {
        private T[] arr;
        private int count = 0;

        public GenericListCustom(int capacity = 8)
        {
            this.arr = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
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
                if (index >= 0 && index < this.Count)
                {
                    this.arr[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
            }
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
            if (element != null)
            {
                if (this.count == this.arr.Length)
                {
                    this.AutoGrow();
                }
                this.arr[this.count] = element;
                this.count++;
            }
            else
            {
                throw new ArgumentNullException("Argument cant be null");
            }
        }

        public void InsertAt(int index, T element)
        {
            count++;
            if (index >= 0 && index < this.Count)
            {
                if (this.Count == this.arr.Length)
                {
                    this.AutoGrow();
                }
                T[] copyArray = new T[this.arr.Length];
                Array.Copy(this.arr, copyArray, this.arr.Length);
                arr = new T[this.arr.Length];
                for (int i = 0, j = 0; i < this.Count; i++, j++)
                {
                    if (i == index)
                    {
                        this.arr[i] = element;
                        i++;
                    }
                    this.arr[i] = copyArray[j];
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range !");
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                this.count--;
                T[] copyArray = new T[this.arr.Length];
                Array.Copy(this.arr, copyArray, this.arr.Length);
                this.arr = new T[this.arr.Length];
                for (int i = 0, j = 0; i < this.Count; i++, j++)
                {
                    if (i == index)
                    {
                        j++;
                    }
                    this.arr[i] = copyArray[j];
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public void Clear()
        {
            this.arr = new T[0];
            this.count = 0;
        }

        public T Min()
        {
            if (this.Count > 0)
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
            else
            {
                throw new Exception("There are no elements in the list");
            }
            
        }

        public T Max()
        {
            if (this.Count > 0)
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
            else
            {
                throw new Exception("There are no elements in the list");
            }
        }

        public override string ToString()
        {
            if (this.Count > 0)
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < this.Count; i++)
                {
                    result.AppendFormat("{0} ", this.arr[i]);
                }
                return result.ToString().Trim();
            }
            return string.Empty;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.arr[i];
            }
        }
    }
}
