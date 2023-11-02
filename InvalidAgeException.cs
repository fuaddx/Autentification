using System.Runtime.Serialization;

namespace ConsoleApp2
{
    internal class InvalidAgeException : Exception
    {

        public InvalidAgeException(string? message) : base(message)
        {
        }

    }
}