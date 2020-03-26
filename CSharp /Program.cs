using System;

namespace CSharp
{
    class Program
    {
        string input;
        int userBalance = 100;
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
                playerInputNextRound();
            }
            else
            {
                Console.WriteLine("Sorry you are under age, you have to be over 18 to play");
            }
        }
         public void playerInputNextRound()
         {      
                Console.WriteLine("Press enter to make a bet");
                string playerGameOptionInput = Console.ReadLine();
                playerBets();
         }
        public void gameOptions()
        {
            Console.WriteLine("Welcome, please select a game from the options, BlackJack or Roulette");
            string playerGameOptionInput = Console.ReadLine();
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
                gameOptions();
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
                gameOptions();
            }
        }

        public void PlayerWinnings()
        {
            playerInput += userBalance;
            Console.WriteLine("Player wins £{0}", playerInput);
            Console.WriteLine("Player's updated balance: £{0}", userBalance);
            playAgain();
        }
        public void HouseWinning()
        {
            playerInput -= userBalance;
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
                playerInputNextRound();
            }
            else if (input == "No")
            {
              System.Console.WriteLine("Thanks for playing!!");
            }
        }

        static void Main(string[] args)
        {
            Program casinoGame = new Program();
            casinoGame.ageRestriction();
        }
    }
}

