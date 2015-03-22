namespace _5._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class BitArray64 : IEnumerable<int>, IComparable
    {
        private ulong number;

        #region Constructors
        public BitArray64()
        {
            this.Number = 0;
        }

        public BitArray64(ulong inputNumber)
        {
            this.Number = inputNumber;
        }
        #endregion

        #region Properties
        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        #endregion

        #region Indexer
        public ulong this[int index]
        {
            get
            {
                if (index < 0 || index > NumberOfBits(this.number))
                {
                    throw new IndexOutOfRangeException();
                }

                return (number >> index) & 1;
            }
            set
            {
                if (index < 0 || index > NumberOfBits(this.number))
                {
                    throw new IndexOutOfRangeException();
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value");
                }

                SetBit(index, (byte)value);
            }
        }
        #endregion

        public int Length
        {
            get
            {
                ulong temp = this.Number;
                int length = 0;
                while (temp != 0)
                {
                    length++;
                    temp >>= 1;
                }

                return length;
            }
        }

        private int NumberOfBits(ulong number)
        {
            int bitsNum = 0;
            while (number != 0)
            {
                bitsNum++;
                number /= 2;
            }

            return bitsNum;
        }

        private void SetBit(int position, byte setValue)
        {
            if (setValue == 0)
            {
                this.number = (ulong)~(1 << position) & this.number;
            }
            else if (setValue == 1)
            {
                ulong mask = (ulong)(1 << position);
                this.number = mask | this.number;
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        #region Overrides
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BitArray64 compareValue = obj as BitArray64;
            if (compareValue == null)
            {
                return false;
            }
            return this.Number.Equals(obj as BitArray64);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            var num = this.Number;
            while (num != 0)
            {
                builder.Insert(0, (num & 1));
                num = num >> 1;
            }

            return builder.ToString();
        }
        #endregion

        #region OperatorsOverloading
        public static bool operator ==(BitArray64 x, BitArray64 y)
        {
            return x.Number == y.Number;
        }

        public static bool operator !=(BitArray64 x, BitArray64 y)
        {
            return x.Number != y.Number;
        }
        #endregion

        #region IEnumerable
        public IEnumerator<int> GetEnumerator()
        {
            int[] arr = this.ToString().ToCharArray().Select(x => (int)char.GetNumericValue(x)).ToArray();
            foreach (var bit in arr)
            {
                yield return bit;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
