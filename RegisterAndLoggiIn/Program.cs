using System;

namespace RegisterAndLoggiIn
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("please enter username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("----------------------");
        }

        public static void Login()
        {
            Console.WriteLine("please enter your username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login succesful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password");  
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username");
            }
        }
    }
}
