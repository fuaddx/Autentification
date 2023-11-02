using System.Runtime.Serialization;

namespace ConsoleApp2
{
    internal class InvalidPhoneFormat : Exception
    {

        public InvalidPhoneFormat(string? message) : base(message)
        {
        }
    }
}