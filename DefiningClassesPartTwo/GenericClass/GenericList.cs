namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T>
    {
        private const uint DefaultInitialSize = 4;
        private T[] array;
        private uint rightIndex;

        public GenericList()
        {
            this.array = new T[DefaultInitialSize];
        }

        public GenericList(int initialSize)
            : this()
        {
            this.array = new T[initialSize];
            this.rightIndex = 0;
        }

        // accessing elements by index
        public T this[uint index]
        {
            get
            {
                if (0 <= index && index <= this.rightIndex)
                {
                    return this.array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                if (0 <= index && index <= this.rightIndex)
                {
                    this.array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(T element)
        {
            this.array[this.rightIndex] = element;
            this.rightIndex++;
            if (this.rightIndex > this.array.Length - 1)
            {
                this.DoubleSize();
            }
        }

        public void RemoveAt(int index)
        {
            if (0 <= index && index <= this.rightIndex - 1)
            {
                T[] temp = new T[this.array.Length - 1];
                Array.Copy(this.array, temp, index);
                Array.Copy(this.array, index + 1, temp, index, this.array.Length - 1 - index);
                this.array = temp;
                this.rightIndex--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public void InsertAt(int index, T value)
        {
            // copy the array to another array with 2 elements bigger size
            T[] temp = new T[this.array.Length + 2];
            for (int i = 0; i <= index - 1; i++)
            {
                temp[i] = this.array[i];
            }

            temp[index] = value;
            for (int i = index; i < this.array.Length; i++)
            {
                temp[i + 1] = this.array[i];
            }

            this.array = temp;
            this.rightIndex++;
        }

        public void Clear()
        {
            this.array = new T[DefaultInitialSize];
            this.rightIndex = 0;
        }

        public int IndexOf(T value)
        {
            return Array.IndexOf(this.array, value);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < this.rightIndex; i++)
            {
                builder.AppendLine(this.array[i].ToString());
            }

            return builder.ToString();
        }

        public T Min<T>()
            where T : IComparable
        {
            T minValue = (dynamic)this.array[0];
            for (int i = 0; i < this.rightIndex; i++)
            {
                if (minValue.CompareTo(this.array[i]) > 0)
                {
                    minValue = (dynamic)this.array[i];
                }
            }

            return minValue;
        }

        public T Max<T>()
           where T : IComparable
        {
            T minValue = (dynamic)this.array[0];
            for (int i = 0; i < this.rightIndex; i++)
            {
                if (minValue.CompareTo(this.array[i]) < 0)
                {
                    minValue = (dynamic)this.array[i];
                }
            }

            return minValue;
        }

        private void DecreseSize()
        {
            T[] temp = new T[this.rightIndex + 1];
            Array.Copy(this.array, temp, this.rightIndex + 1);
            this.array = temp;
        }

        private void DoubleSize()
        {
            T[] temp = new T[this.array.Length * 2];
            this.array.CopyTo(temp, 0);
            this.array = temp;
        }        
    }
}
