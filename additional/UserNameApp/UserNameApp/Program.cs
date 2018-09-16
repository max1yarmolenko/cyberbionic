using System;

namespace UserNameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Enter your name: ";
            Console.Write(message); 

            string name = Console.ReadLine();

            Console.Write("You entered the name: " + name);

            Console.ReadKey();
        }
    }
}
