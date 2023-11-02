using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class User
    {
        public string _name;
        public int _age;
        public string _password;
        public string _phonenumber;

       public string  Name { get=>_name; set 
            {

                if(value.Length>=2 && value.Length <= 30)
                {
                    _name = value;
                }
                else
                {
                    throw new InvalidNameException("Wrong");
                }
            }
        }
       public int Age { get=> _age; set 
            { 

                if(value<0 || value == 0)
                {
                    throw new InvalidAgeException("Age is wrong");
                }
                else
                {
                    _age = value;
                }}
        }

       public string PhoneNumber { get => _phonenumber; set 

            {

            Regex regex = new Regex(@"^\+994-(50)|(55)|(70)|(99)-[0-9]{}-[0-9]{3}-[0-9]{2}-[0-9]{2}");

                if (!regex.IsMatch(value))
                {
                    throw new InvalidPhoneFormat("Invalid phone number format.");
                }
                _phonenumber = value;
            } 
        }
       public string Password { get=> _password; set

            {
                Regex regex = new Regex(@"^(?=,*?[A-Z])(&=.*?[a-z])(?=.*[#&!@#$%-]).{8,}$");

                if (!regex.IsMatch(value))
                {
                    throw new PasswordException("Invalid password.");
                }
                _password = value;
            }
        }
        }

    }

