namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T>
    {
        private const uint defaultInitialSize = 4;
        private T[] array;
        private uint rightIndex;

        public GenericList()
        { 
            this.array = new T[defaultInitialSize];
        }
        public GenericList(int initialSize) :this()
        {
            this.array = new T[initialSize];
            this.rightIndex = 0;
        }

        public void Add(T element)
        {
            this.array[rightIndex] = element;
            this.rightIndex++;
            if (rightIndex > this.array.Length - 1)
            {
                DoubleSize();
            }
        }

        private void DoubleSize()
        {
            T[] temp = new T[this.array.Length * 2];
            this.array.CopyTo(temp, 0);
            this.array = temp;
        }

        //accessing elements by index
        public T this[uint index]
        {            
            get 
            {
                if (0<= index && index <= rightIndex)
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
                if (0 <= index && index <= rightIndex)
                {
                    this.array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public void RemoveAt(int index)
        {
            if(0 <= index && index <= rightIndex-1)
            {
                T[] Temp = new T[this.array.Length - 1];
                Array.Copy(this.array, Temp, index);
                Array.Copy(this.array, index + 1, Temp, index, this.array.Length - 1 - index);
                this.array = Temp;
                rightIndex--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void DecreseSize()
        {
            T[] temp = new T[rightIndex + 1];
            Array.Copy(this.array, temp, rightIndex + 1);
            this.array = temp;
        }

        public void InsertAt(int index, T value)
        {
            //copy the array toanother array with 2 elements bigger size
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
            rightIndex++;
        }

        public void Clear()
        {
            this.array = new T[defaultInitialSize];
            this.rightIndex = 0;
        }

        public int IndexOf(T value)
        {
            return Array.IndexOf(this.array, value);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < rightIndex; i++)
            {
                builder.AppendLine(this.array[i].ToString());
            }
            return builder.ToString();
        }

        public T Min<T>()
            where T: IComparable
        {
            T minValue = (dynamic)this.array[0];
            for (int i = 0; i < rightIndex; i++)
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
            for (int i = 0; i < rightIndex; i++)
            {
                if (minValue.CompareTo(this.array[i]) < 0)
                {
                    minValue = (dynamic)this.array[i];
                }
            }
            return minValue;
        }
    }
}
