using System.Runtime.Serialization;

namespace ConsoleApp2
{
    [Serializable]
    internal class InvalidNameException : Exception
    {

        public InvalidNameException(string? message) : base(message)
        {
        }

    }
}