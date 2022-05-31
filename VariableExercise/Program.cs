using System;

namespace VariableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Cristian";

            int myAge = 18;

            char myLastNameInitial = 'E';

            bool cSharp = true;

            double myWeight = 185.5;

            decimal myHeight = 68.4m;

            Console.WriteLine($"My name is {myName} and my last name inital is {myLastNameInitial}.");
            Console.WriteLine($"I am {myAge} years old and it is {cSharp} im learning C#.");
            Console.WriteLine($"My weight is {myWeight} pounds and my height is {myHeight} inches.");

        }
    }
}

