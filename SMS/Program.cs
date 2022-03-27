using System;
using SMS.Controllers;
using SMS.Models;

namespace SMS
{
    class Program
    {
        static void Main(string[] args)
        {

        startpoint:
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("----- Welcome to SMS by group 10 ! -------");
            Console.WriteLine("==========================================");
            while (true)
            {
                Console.WriteLine(" 1-Login \n 2-Registration");
                Console.WriteLine("==========================================");

                String Selected_1 = Console.ReadLine();

                UserController user = new UserController();

                switch (Selected_1)
                {
                    case "1":
                        Console.WriteLine("------- Login -------");
                        Console.Write("Email : ");
                        String email = Console.ReadLine();
                        Console.Write("Password : ");
                        String password = Console.ReadLine();
                        Console.WriteLine("==========================================");

                        Console.WriteLine("Logged in !!!");

                        user.login(email, password);

                        break;

                    case "2":
                        Console.WriteLine("------- Register ------");
                        Console.Write("Name : ");
                        String studentName = Console.ReadLine();
                        Console.Write("Email : ");
                        String studentEmail = Console.ReadLine();
                        Console.Write("Password : ");
                        String studentPassword = Console.ReadLine();
                        Console.Write("Course : ");
                        String course = Console.ReadLine();
                        Console.WriteLine("==========================================");

                        Console.WriteLine("Registered !!!");

                        user.register(studentName, studentEmail, studentPassword, course);

                        break;

                    default:
                        Console.WriteLine("Wrong Choice!!!");
                        break;
                }
            }
            
            
        }
    }
}

