using System;

namespace CSharp
{
    class Program
    {
        int playerAgeInput;
        void ageRestriction()
        {
        Console.WriteLine(Convert.ToDouble(playerAgeInput));
        Console.WriteLine("Please enter age");
        // playerAgeInput = Console.ReadLine();
        Console.WriteLine(playerAgeInput);

         if (playerAgeInput >= 18) {
        Console.WriteLine("Welcome, please select a game from the options, 1 for Black Jack or 2 for Roulette");
        // gameOptions(1);
    } else {
        Console.WriteLine("Sorry you are under age, you have to be over 18 to play");
    }
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
