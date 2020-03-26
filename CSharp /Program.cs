using System;

namespace CSharp
{
    class Program
    {
        string input;
        int userBalance = 100;
        int bettingHoldingPile;
         int playerInput;
        int playerAgeInput;
        string playerGameOptionInput = Console.ReadLine();

        public void ageRestriction()
        {
            Console.WriteLine("Please enter age");
            input = Console.ReadLine();
            playerAgeInput = Convert.ToInt32(input);
            if (playerAgeInput >= 18)
            {
                Console.WriteLine("Welcome, please select a game from the options, BlackJack or Roulette");
                playerInputNextRound();
            }
            else
            {
                Console.WriteLine("Sorry you are under age, you have to be over 18 to play");
            }
        }
         public void playerInputNextRound()
         {      
                string playerGameOptionInput = Console.ReadLine();
                gameOptions(playerGameOptionInput);
         }
        public void gameOptions(string playerGameOptionInput)
        {
            if (playerGameOptionInput == "BlackJack")
            {
                classes.BlackJack blackJackGamePlay = new classes.BlackJack();
                blackJackGamePlay.playersHand();
            }
            else if (playerGameOptionInput == "Roulette")
            {
                classes.Roulette rouletteGamePlay = new classes.Roulette();
                rouletteGamePlay.rouletteGameBeginning();
            }
            else
            {
                gameOptions(playerGameOptionInput);
            }
        }
        public void playerBets()
        {
            Console.WriteLine("Please place your bets £");
            input = Console.ReadLine();
            playerInput = Convert.ToInt32(input);
            if (playerInput > 100)
            {
                System.Console.WriteLine("Betting limit is upto £100, please re-enter betting amount");
                playerBets();
            }
            else
            {
                Console.WriteLine("You have placed £{0}, Dealer has placed £{0}", playerInput);
                // gameOptions(playerGameOptionInput);
                playerInputNextRound();
            }
        }

        public void PlayerWinnings()
        {
            playerInput += userBalance;
            userBalance = playerInput += bettingHoldingPile;
            Console.WriteLine("Player wins £{0}", playerInput);
            Console.WriteLine("Player's updated balance: £{0}", userBalance);
            playAgain();
        }
        public void HouseWinning()
        {
            playerInput -= userBalance;
            userBalance = playerInput -= bettingHoldingPile;
            Console.WriteLine("House wins £{0}", playerInput);
            Console.WriteLine("Player's updated balance is: £{0}", userBalance);
            playAgain();
        }

         public void playAgain()
        {
            Console.WriteLine("Play Again? Yes or No");
            input = Console.ReadLine();
            if (input == "Yes")
            {
                playerBets();
            }
            else if (input == "No")
            {
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.gameOptions(playerGameOptionInput);
            }
        }

        static void Main(string[] args)
        {
            Program casinoGame = new Program();
            casinoGame.ageRestriction();
        }
    }
}

