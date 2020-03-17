let playerBalance = 20;

let playerAgeInput=23;
let ageRestriction = () => {
    if (playerAgeInput >= 18) {
        console.log("Welcome, please select a game from the options, 1 for Black Jack or 2 for Roulette");
        gameOptions(1)
    } else {
        console.log("Sorry you are under age, you have to be over 18 to play");
    }
};

const gameOptions = () => {
    let choice = 1;
    if (choice == 1) {
        blackJackGame(1)
    } else if (choice == 2) {
        rouletteTableGame(2)
    }
};

const blackJackGame = () => {
    console.log("Please, place your bets");
    userStack = 10;
    playerCardDraw()
}

const playerCardDraw = () => {
    firstCard = (Math.ceil(Math.random() * 11));
    console.log(`Your first card is: ${firstCard}`);
    secondCard = (Math.ceil(Math.random() * 11))
    console.log(`Your second card is:${secondCard}`)
    totalOfFirstDraw = (firstCard + secondCard)
    console.log(`Your total is : ${totalOfFirstDraw}`);
    console.log(`Would you like to hit(1) or stand(2)?`);
    playerChoice()
}

const playerChoice = (choice) => {
    if (choice == 1) {
        nextCard = (Math.ceil(Math.random() * 11));
        total = (totalOfFirstDraw + nextCard)
        console.log(`Your next card is ${nextCard}`);
        console.log(` your current score is ${total}`);
        playerCheckCardScore()
    } else if (total = 21){
        console.log("BlackJack");
        dealersdDraw();
    }
    else {
        (choice == 2)
         console.log(totalOfFirstDraw);
        dealersDraw();
    }
}

const playerCheckCardScore = () => {
    if(total >= 22){
        console.log("You have bust, dealer wins");
    } else if (total == 21) {
        console.log("Black Jack");
        dealersDraw();
    } else {
        playerChoice(2)
    }
}
