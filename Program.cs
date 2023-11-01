using Core.Models;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class Program
    {


        
        static void Main(string[] args)
        {
            User user = new User();


            string name;
            string surname;
            string username;
            string password;

            while (true)
            {
                Console.WriteLine("1 -> Login\n2-> Register\n3->GetUsers\n4->Logout");
                byte option = 0;
                option = Convert.ToByte(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Username:");
                         username = Console.ReadLine();
                        Console.WriteLine("Password:");
                         password = Console.ReadLine();
                        Authorization.Login(username, password);
                        Console.WriteLine("Logged in");
                        break;
                    case 2:
                        Console.WriteLine("Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Surname:");
                         surname= Console.ReadLine();
                        Console.WriteLine("Username:");
                         username = Console.ReadLine();
                        Console.WriteLine("Password:");
                        password = Console.ReadLine();
                        Console.WriteLine("Registered");
                        Authorization.Register(name, surname, username, password);
                     break;
                    case 3:
                        Authorization.GetUsers();
                        break;
                    case 4:
                        Authorization.Logout();
                    break;
                }
            }

        }
        public static List<User> users { get; set; } = new List<User>() ;
        //public static User LogedIn { get; set; }

    public static class Authorization
    {
        public static void Register(string name, string surname, string username, string password)
        {
            User user = new User()
            {
                Name = name,
                Surname = surname,
                UserName = username,
                Password = password
            };
                 users.Add(user);
            }


        public static void Login(string username, string password)
        {
            foreach (var item in  users)
            {
                if (item.UserName == username && item.Password == password)
                {
                    Console.WriteLine("Logged in");
                }
            }
        }


            public static void GetUsers()
            {
                foreach (var item in  users)
                {
                    Console.WriteLine(item.UserName);
                }

            }
        public static void Logout()
        {   
            
        }
        



    }
}
    }