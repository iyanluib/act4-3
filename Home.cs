using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act
{
    class Home
    {
        public static void MainHome()
        {
            Console.WriteLine(@"       
                ===================================================================================
                *           █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████            *
                *          ▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀            *
                *          ▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███              *
                *          ░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄            *
                *          ░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒           *
                *          ░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░           *
                *            ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░           *
                *            ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░              *
                *             ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░            *
                ===================================================================================");
           
                                                                                                            
            while (true)
            {
                Console.WriteLine(@"
                                           1. Register
                                           2. Login
                                           3. Exit
                    ");
                Console.Write("Choose: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            }
        }

        public static void Register()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Connection conn = new Connection();
            conn.InsertData(username, password);
        }

        public static void Login()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Connection conn = new Connection();
            bool isValid = conn.ValidateLogin(username, password);

            if (isValid)
                Console.WriteLine("Login successful!");
            else
                Console.WriteLine("Invalid username or password.");
        }
    }
}