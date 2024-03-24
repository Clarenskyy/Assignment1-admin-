using System;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            String username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            String password = Console.ReadLine();
            if (username == "Admin" && password == "Admin1234!")
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("\n\nIncorrect Password or Username");
                Console.WriteLine("\t3 attemps left");

                Console.WriteLine("Enter username: ");
                username = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
                if (username == "Admin" && password == "Admin1234!")
                {
                    Console.WriteLine("Login Successful!");
                }
                else
                {
                    Console.WriteLine("\n\nIncorrect Password or Username");
                    Console.WriteLine("\t2 attemps left");

                    Console.WriteLine("Enter username: ");
                    username = Console.ReadLine();

                    Console.WriteLine("Enter password: ");
                    password = Console.ReadLine();
                    if (username == "Admin" && password == "Admin1234!")
                    {
                        Console.WriteLine("Login Successful!");
                    }
                    else
                    {
                        Console.WriteLine("\n\nIncorrect Password or Username");
                        Console.WriteLine("\t1 attemps left");

                        Console.WriteLine("Enter username: ");
                        username = Console.ReadLine();

                        Console.WriteLine("Enter password: ");
                        password = Console.ReadLine();
                        if (username == "Admin" && password == "Admin1234!")
                        {
                            Console.WriteLine("Login Successful!");
                        }
                        else
                        {
                            Console.WriteLine("\n\nIncorrect Password or Username");
                            Console.WriteLine(" Account lock for a few minutes, try again later. ");
                        }
                    }
                }
            }

        }
    }
}


