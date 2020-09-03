using System;

namespace HowOldAreYou1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good morning!");
            Console.WriteLine("What's your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine("What's your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            // parsing string to interger (number)
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You're " + Age + " years old.");
        }
    }
}
