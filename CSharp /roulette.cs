using System;

namespace classes
{
    class Roulette
    {
        string input;
        int playerInput;

        public void rouletteGameBeginning()
        {
            Console.WriteLine("Please select what too bet on: Colours, Odds, Numbers");
            input = Console.ReadLine();
            if (input == "Colours")
            {
                Console.WriteLine("Please select Red or Black");
                colourPlayThrough();
            }
            else if (input == "Odds")
            {
                Console.WriteLine("Please select Odd or Even");
                playerOddsThrough();
            }
            else if (input == "Numbers")
            {
                Console.WriteLine("Please select a number from 0 - 37");
                playerNumberThgrough();
            }
            else
            {
                Console.WriteLine("Please select from the options Colour, Odds or Numbers");
            }
        }
        public void colourPlayThrough()
        {
            input = Console.ReadLine();
            Random rnd = new Random();
            string[] colours = { "Black", "Red" };
            int cIndex = rnd.Next(colours.Length);
            Console.WriteLine("The colour is {0}", colours[cIndex]);
            if (input == colours[cIndex])
            {
                Console.WriteLine("You win!!");
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.PlayerWinnings();
            }
            else
            {
                Console.WriteLine("You lose");
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.HouseWinning();
            }
        }
        public void playerOddsThrough()
        {
            input = Console.ReadLine();
            Random rnd = new Random();
            string[] odds = { "Even", "Odd" };
            int oIndex = rnd.Next(odds.Length);
            Console.WriteLine("{0}", odds[oIndex]);
            if (input == odds[oIndex])
            {
                Console.WriteLine("You win!!");
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.PlayerWinnings();
            }
            else
            {
                Console.WriteLine("You lose");
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.HouseWinning();
            }
        }
        public void playerNumberThgrough()
        {
            input = Console.ReadLine();
            Random rnd = new Random();
            int numbers = rnd.Next(0, 38);
            Console.WriteLine("Number is {0}", numbers);
            if (playerInput == numbers)
            {
                Console.WriteLine("You win!!");
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.PlayerWinnings();
            }
            else
            {
                Console.WriteLine("You lose");
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.HouseWinning();
            }
        }
    }
}