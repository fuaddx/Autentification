using System.Runtime.Serialization;

namespace ConsoleApp2
{

    internal class PasswordException : Exception
    {

        public PasswordException(string? message) : base(message)
        {
        }


    }
}