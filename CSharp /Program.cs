using System;

namespace CSharp
{
    class Program
    {
        string input;
        int playerAgeInput;

        public void ageRestriction()
        {
            Console.WriteLine("Please enter age");
            input = Console.ReadLine();
            playerAgeInput = Convert.ToInt32(input);
            if (playerAgeInput >= 18)
            {
                Console.WriteLine("Welcome, please select a game from the options, BlackJack or Roulette");
                gameOptions();
            }
            else
            {
                Console.WriteLine("Sorry you are under age, you have to be over 18 to play");
            }
        }
        public void gameOptions()
        {
            input = Console.ReadLine();
            if (input == "BlackJack")
            {
                classes.BlackJack blackJackGamePlay = new classes.BlackJack();
                blackJackGamePlay.blackJackGame();
            }
            else if (input == "Roulette")
            {
               classes.Roulette rouletteGamePlay = new classes.Roulette();
                rouletteGamePlay.rouletteGameBeginning();
            }
        }
        static void Main(string[] args)
        {
            Program casinoGame = new Program();
            casinoGame.ageRestriction();

            // classes.BlackJack blackJackGamePlay = new classes.BlackJack();
            // blackJackGamePlay.blackJackGame();

            // classes.Roulette rouletteGamePlay = new classes.Roulette();
            // rouletteGamePlay.rouletteGameBeginning();
        }
    }
}

