namespace RangeExceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; set; }
        public T End { get; set; }
    }
}
