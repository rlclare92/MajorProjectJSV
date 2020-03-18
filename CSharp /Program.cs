using System;

namespace CSharp
{
    class Program
    {
        string input;
        int playerAgeInput;
        int playerInput;
        int userBalance; 
        int playersTotalOfFirstDraw;
        int dealersTotalOfFirstDraw;

    //     public void ageRestriction()
    //     {
    //     Console.WriteLine("Please enter age");
    //     input = Console.ReadLine();
    //     playerAgeInput = Convert.ToInt32(input);
    //     // Console.WriteLine(playerAgeInput);

    //      if (playerAgeInput >= 18) {
    //     Console.WriteLine("Welcome, please select a game from the options, BlackJack or Roulette");
    //     gameOptions();
    // } else {
    //     Console.WriteLine("Sorry you are under age, you have to be over 18 to play");
    // }
    // }

    // public void gameOptions()
    // {
    //     input = Console.ReadLine();

    //     if(input == "BlackJack"){
    //         blackJackGame();
    //     } else if (input == "Roulette"){
    //         // rouletteTableGame();
    // }
    // }

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
        int playersFirstCard = rnd.Next(1,12);
        Console.WriteLine("Your first card is: {0}", playersFirstCard);
        int playersSecondCard = rnd.Next(1,12);
        Console.WriteLine("Your second card is: {0}", playersSecondCard);
        playersTotalOfFirstDraw = (playersFirstCard + playersSecondCard);
        Console.WriteLine("Your total is: {0}", playersTotalOfFirstDraw);
        if(playersTotalOfFirstDraw == 21)
        {
            Console.WriteLine("BlackJack!!, Player wins");
            PlayerWinnings();
        } else {
            playerChoices(playersTotalOfFirstDraw);
        }
    }

        public void playerChoices(int playersTotalOfFirstDraw)
        {
        Console.WriteLine("Hit or Stand?");
        input = Console.ReadLine();
        Random rnd = new Random();
        if(input == "Hit")
        {
            int playersNextCard = rnd.Next(1,12);
            Console.WriteLine("Your next card is {0}", playersNextCard);
            playersTotalOfFirstDraw += playersNextCard;
            Console.WriteLine("Your current total is: {0}", playersTotalOfFirstDraw);
            ScoreCheckPlayer(playersTotalOfFirstDraw);
        }
        else if (input == "Stand")
        {
          Console.WriteLine("You have stand at {0}, dealers turn",playersTotalOfFirstDraw);
          Console.Read();
          dealersHand();
        }
    }
    public void ScoreCheckPlayer(int playersTotalOfFirstDraw)
    {
        if(playersTotalOfFirstDraw >= 22)
        {
            Console.WriteLine("Bust");
            dealersWinning();
        } else if (playersTotalOfFirstDraw == 21)
        {
             Console.WriteLine("BlackJack!!");
             PlayerWinnings();
        }
        else {
            playerChoices(playersTotalOfFirstDraw);
        }
    }
    public void dealersHand()
    {
        Random rnd = new Random();
        int dealersFirstCard = rnd.Next(1,12);
        Console.WriteLine("Dealer's first card is: {0}", dealersFirstCard);
        int dealersSecondCard = rnd.Next(1,12);
        Console.WriteLine("Dealer's second card is: {0}", dealersSecondCard);
        int dealersTotalOfFirstDraw = (dealersFirstCard + dealersSecondCard);
        Console.WriteLine("Dealer's total is: {0}", dealersTotalOfFirstDraw);
        if(dealersTotalOfFirstDraw == 21)
        {
            Console.WriteLine("BlackJack!! Player Wins");
             PlayerWinnings();
        } else {
            dealersChoice(dealersTotalOfFirstDraw);
        }
    }

    public void dealersChoice(int dealersTotalOfFirstDraw)
    {
        Random rnd = new Random();
        // Console.WriteLine("{0}", dealersTotalOfFirstDraw);
        if(dealersTotalOfFirstDraw <= playersTotalOfFirstDraw)
        {
            int dealersNextCard = rnd.Next(1,12);
            Console.WriteLine("Dealer's next card is {0}", dealersNextCard);
            dealersTotalOfFirstDraw += dealersNextCard;
            Console.WriteLine("Dealer's current total is: {0}", dealersTotalOfFirstDraw);
            ScoreCheckDealer(dealersTotalOfFirstDraw);
        }
        else if (dealersTotalOfFirstDraw > playersTotalOfFirstDraw)
        {
          Console.WriteLine("Dealer Wins!!");
          dealersWinning();
        }
    }
    public void ScoreCheckDealer(int dealersTotalOfFirstDraw)
    {
        if(dealersTotalOfFirstDraw> 22)
        {
            Console.WriteLine("Dealer bust, player wins");
            PlayerWinnings();

        } else if (dealersTotalOfFirstDraw == 21)
        {
             Console.WriteLine("BlackJack!! Dealer wins!!");
            dealersWinning();
        }
        else {
            dealersChoice(dealersTotalOfFirstDraw);
        }
    }
    public void PlayerWinnings()
    {
          playerInput += userBalance;
          Console.WriteLine("Player wins {0}", playerInput);
          Console.WriteLine("PlayerWinnings updated balance {0}", userBalance);
    }

    public void dealersWinning()
    {
        playerInput -= userBalance;
        Console.WriteLine("Dealer wins {0}", playerInput);
        Console.WriteLine("User balance is: {0}", userBalance);
    }

        static void Main(string[] args)
        {
            // Program casinoGame = new Program();
            // casinoGame.ageRestriction();
            Program casinoGame = new Program();
            casinoGame.blackJackGame();
        }
    }
}
