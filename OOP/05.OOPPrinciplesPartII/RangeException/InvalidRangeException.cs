using System;
using System.Collections.Generic;

namespace RangeException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        public string ErrorMessage { get; set; }
        public T MinRange { set; get; }
        public T MaxRange { set; get; }

        public InvalidRangeException() : base("The argument you entered was outside the allowed range!")
        {
        }

        public InvalidRangeException(T minRange, T maxRange) : this()
        {
            this.MinRange = minRange;
            this.MaxRange = maxRange;
        }

        public InvalidRangeException(string message, T minRange, T maxRange) : base (message)
        {
            this.MinRange = minRange;
            this.MaxRange = maxRange;
        }
    }
}
