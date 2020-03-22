using System;

namespace classes
{
    class BlackJack
    {

        string input;
        int playerInput;
        int userBalance;
        int playersTotalOfFirstDraw;
        int playersNextCard;
        int dealersTotalOfFirstDraw;
        int playersTotal;
        int playersHandTotal;

        public void blackJackGame()
        {
            Console.WriteLine("Please place your bets £");
            input = Console.ReadLine();
            playerInput = Convert.ToInt32(input);
            Console.WriteLine("You have placed {0}, Dealer has placed {0}", playerInput);
            playersHand();
        }

        public void playersHand()
        {
            Random rnd = new Random();
            int playersFirstCard = rnd.Next(1, 12);
            Console.WriteLine("Your first card is: {0}", playersFirstCard);
            int playersSecondCard = rnd.Next(1, 12);
            Console.WriteLine("Your second card is: {0}", playersSecondCard);
            playersTotal = playersFirstCard + playersSecondCard;
            Console.WriteLine("Your total is: {0}", playersTotal);
            PlayerChoices();
        }
        public void PlayerChoices()
        {
            Console.WriteLine("Hit or Stand?");
            input = Console.ReadLine();
            Random rnd = new Random();
            if (input == "Hit")
            {
                playersNextCard = rnd.Next(1, 12);
                Console.WriteLine("Your next card is {0}", playersNextCard);
                playersTotal += playersNextCard;
                Console.WriteLine("Your total is: {0}", playersTotal);
                ScoreCheckPlayer(playersTotal);
                input = Console.ReadLine();
                PlayerChoices();
            }
            else if (input == "Stand")
            {
                playersHandTotal += playersTotal;
                Console.WriteLine("You have stand at {0}, dealers turn", playersHandTotal);
                if (playersTotal >= 22)
                {
                    Console.WriteLine("Bust");
                    dealersWinning();
                }
                else if (playersTotal == 21)
                {
                    Console.WriteLine("BlackJack!!");
                    PlayerWinnings();
                }
                Console.Read();
                dealersHand();
            }
        }
        public void ScoreCheckPlayer(int playersTotal)
        {
            if (playersTotal >= 22)
            {
                Console.WriteLine("Bust");
                dealersWinning();
            }
            else if (playersTotal == 21)
            {
                Console.WriteLine("BlackJack!!");
                PlayerWinnings();
            }
            else
            {
                PlayerChoices();
            }
        }
        public void dealersHand()
        {
            Random rnd = new Random();
            int dealersFirstCard = rnd.Next(1, 12);
            Console.WriteLine("Dealer's first card is: {0}", dealersFirstCard);
            int dealersSecondCard = rnd.Next(1, 12);
            Console.WriteLine("Dealer's second card is: {0}", dealersSecondCard);
            dealersTotalOfFirstDraw = dealersFirstCard += dealersSecondCard;
            Console.WriteLine("Dealer's total is: {0}", dealersTotalOfFirstDraw);
            if (dealersTotalOfFirstDraw == 21)
            {
                Console.WriteLine("BlackJack!! Dealer Wins");
                PlayerWinnings();
            }
            else
            {
                dealersChoice(dealersTotalOfFirstDraw);
            }
        }
        public void dealersChoice(int dealersTotalOfFirstDraw)
        {
            Random rnd = new Random();
            if (dealersTotalOfFirstDraw < playersHandTotal)
            {
                int dealersNextCard = 0;
                dealersNextCard = rnd.Next(1, 12);
                Console.WriteLine("Dealer's next card is {0}", dealersNextCard);
                dealersTotalOfFirstDraw += dealersNextCard;
                Console.WriteLine("Dealer's current total is: {0}", dealersTotalOfFirstDraw);
                ScoreCheckDealer(dealersTotalOfFirstDraw);
            }
            else if (dealersTotalOfFirstDraw > playersHandTotal)
            {
                Console.WriteLine("Dealer Wins!!");
                dealersWinning();
            }
            else if (dealersTotalOfFirstDraw == playersHandTotal)
            {
                Console.WriteLine("Tie");
                playAgain();
            }
        }
        public void ScoreCheckDealer(int dealersTotalOfFirstDraw)
        {
            if (dealersTotalOfFirstDraw >= 22)
            {
                Console.WriteLine("Dealer bust, player wins");
                PlayerWinnings();

            }
            else if (dealersTotalOfFirstDraw == 21)
            {
                Console.WriteLine("BlackJack!! Dealer wins!!");
                dealersWinning();
            }
            else
            {
                dealersChoice(dealersTotalOfFirstDraw);
            }
        }
        public void PlayerWinnings()
        {
            playerInput += userBalance;
            Console.WriteLine("Player wins {0}", playerInput);
            Console.WriteLine("PlayerWinnings updated balance {0}", userBalance);
            playAgain();
        }

        public void dealersWinning()
        {
            playerInput -= userBalance;
            Console.WriteLine("Dealer wins {0}", playerInput);
            Console.WriteLine("User balance is: {0}", userBalance);
            playAgain();
        }
        public void playAgain()
        {
            Console.WriteLine("Play Again? Yes or No");
            input = Console.ReadLine();
            if (input == "Yes")
            {
                playersHandTotal = 0;
                dealersTotalOfFirstDraw = 0;
                blackJackGame();
            }
            else if (input == "No")
            {
                CSharp.Program casinoGame = new CSharp.Program();
                casinoGame.gameOptions();
            }
        }
    }
}
