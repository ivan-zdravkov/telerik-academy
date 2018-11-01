using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class GenericList<T> 
        where T: IComparable<T>
    {
        private T[] list;
        private int countOfElements;

        public int Count
        {
            get { return this.countOfElements; }
        }

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Argument should not be less than 0");
            }
            else
            {
                this.list = new T[capacity];
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.countOfElements)
                {
                    return this.list[index];
                }
                else
                {
                    throw new ArgumentException("The index was outside the bounds of array!");
                }
            }
            set
            {
                if (index >= 0 && index < this.countOfElements)
                {
                    this.list[index] = value;
                }
                else
                {
                    throw new ArgumentException("The index was outside the bounds of array!");
                }
            }
        }

        public void Add(T element)
        {
            if (countOfElements < list.Length)
            {
                this.list[countOfElements] = element;
                this.countOfElements++;
            }
            else
            {
                this.AutoGrow();
                this.Add(element);
            }
        }

        public void RemoveAt(int possition)
        {
            if (possition >= 0 && possition < this.list.Length)
            {
                for (int i = possition; i < this.countOfElements; i++)
                {
                    this.list[i] = this.list[i + 1];
                }
                this.countOfElements--;
            }
            else
            {
                throw new ArgumentException("The element you requested to remove was outside the list!");
            }
        }

        public void InsertAt(T element, int possition)
        {
            if (countOfElements < this.list.Length)
            {
                for (int i = this.countOfElements - 1; i >= possition; i--)
                {
                    this.list[i + 1] = this.list[i];
                }
                this.list[possition] = element;
                this.countOfElements++;
            }
            else
            {
                this.AutoGrow();
                this.InsertAt(element, possition);
            }
        }

        public void Clear()
        {
            this.list = new T[this.list.Length];
        }

        public int? FindIndexOf(T element)
        {
            for (int i = 0; i < this.countOfElements; i++)
            {
                if (this.list[i].Equals(element))
                {
                    return i;
                }
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < this.countOfElements; i++)
            {
                text.Append(this.list[i]);
                text.Append(", ");
            }
            return text.ToString();
        }

        private void AutoGrow()
        {
            T[] temp = new T[list.Length * 2];
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = this.list[i];
            }
            this.list = temp;
        }

        public static T Min<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) < 0) ? x : y;
        }

        public static T Max<T>(T x, T y)
        {
            return (Comparer<T>.Default.Compare(x, y) > 0) ? x : y;
        }
    }
}
