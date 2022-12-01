using System;
using System.Runtime.Serialization;

namespace MusicPlayer
{
    internal class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string? message) : base(message)
        {
        }

        public CustomException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
