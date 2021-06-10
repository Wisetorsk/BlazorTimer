using System;

namespace BlazorTimer
{
    public class TimerAlreadySetException : Exception
    {
        public TimerAlreadySetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public TimerAlreadySetException(string message) : base(message)
        {
        }
    }
}