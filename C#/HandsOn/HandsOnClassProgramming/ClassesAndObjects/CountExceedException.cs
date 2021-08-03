using System;
using System.Runtime.Serialization;

namespace ClassesAndObjects
{
    [Serializable]
    internal class CountExceedException : Exception
    {
        public CountExceedException()
        {
        }

        public CountExceedException(string message) : base(message)
        {
        }

        public CountExceedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CountExceedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}