// See https://aka.ms/new-console-template for more information

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            string firstName = "Maaz";
            string lastName = "Ahmed";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name+$"{"\n"}");

            // Console.WriteLine(firstName.Length);
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);

            }
        }
    }
}

