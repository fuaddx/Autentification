using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            while (true)
            {
                Again:
                try
                {
                    Console.WriteLine("Enter name:");
                    string userinputname = Console.ReadLine();
                    user.Name = userinputname;
                }
                catch (InvalidNameException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Again;
                }
                Again2:
                try
                {
                    Console.WriteLine("Enter age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    user.Age = age;
                    
                }

                catch (InvalidAgeException ex)
                {
                    Console.WriteLine(ex.Message);
                 goto Again2;
                }
                Again3:
                try
                {
                    Console.WriteLine("Enter phonenumber:");
                    string phonenumber = Console.ReadLine();
                    user.PhoneNumber = phonenumber;
                }
                catch (InvalidPhoneFormat ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Again3;
                }
                Again4:
                try
                {
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();
                    user.Password = password;
                }
                catch (PasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Again4;
                }
            } 
            
        }
    }
}