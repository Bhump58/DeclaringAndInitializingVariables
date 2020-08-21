using System;

namespace DeclareAndInitializeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Brian";
            int age = 27;
            char favoriteLetter = 'B';
            bool isFun = true;
            double heightInFeet = 6.1;
            decimal heightInInches = 73.0m;


            Console.WriteLine($"Hello my name is {name}, and I am {age} years old");
            Console.WriteLine($"Fun fact about me is my favorite letter is {favoriteLetter}, " +
                $"and if you ask my friends if I am fun they will say it is {isFun}");
            Console.WriteLine($"My height in feet is {heightInFeet} Ft, but in inches that is  {heightInInches}.");
        }
    }
}
