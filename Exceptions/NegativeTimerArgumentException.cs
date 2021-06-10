using System;

namespace BlazorTimer
{
    public class NegativeTimerArgumentException : Exception
    {
        public NegativeTimerArgumentException(string message, Exception innerException = null) : base(message, innerException)
        {
        }

        public NegativeTimerArgumentException(string message) : base(message)
        {
        }
    }
}