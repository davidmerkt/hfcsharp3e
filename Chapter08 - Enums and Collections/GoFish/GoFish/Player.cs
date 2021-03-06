﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        // Here's a property and a few short methods that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            // The constructor for the Player class initializes four private fields, and then
            // adds a line to the TextBox control on the form that says, "Joe has just
            // joined the game"—but use the name in the private field, and don't forget to
            // add a line break at the end of every line you add to the TextBox.
            this.name = name;
            this.random = random;
            cards = new Deck();
            this.textBoxOnForm.Text = textBoxOnForm.Text.ToString() + name + " has just joined the game\n";
            //textBoxOnForm.Text = this.textBoxOnForm.Text;
        }

        public IEnumerable<Values> PlayerPullOutBooks() 
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValue(value);
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            // This method gets a random value—but it has to be a value that's in the deck!
            return cards.Peek(random.Next(cards.Count)).Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            // This is where an opponent asks if I have any cards of a certain value
            // Use Deck.PullOutValues() to pull out the values. Add a line to the TextBox
            // that says, "Joe has 3 sixes"—use the new Card.Plural() static method
            Deck cardsToReturn = cards.PullOutValue(value);

            textBoxOnForm.Text = textBoxOnForm.Text + name + " has " + cardsToReturn.Count + " " + value + "\n";

            return cardsToReturn;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Here's an overloaded version of AskForACard()—choose a random value
            // from the deck using GetRandomValue() and ask for it using AskForACard()
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Values randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
            }
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            // Ask the other players for a value. First add a line to the TextBox: "Joe asks
            // if anyone has a Queen". Then go through the list of players that was passed in
            // as a parameter and ask each player if he has any of the value (using his
            // DoYouHaveAny() method). He'll pass you a deck of cards—add them to my deck.
            // Keep track of how many cards were added. If there weren't any, you'll need
            // to deal yourself a card from the stock (which was also passed as a parameter),
            // and you'll have to add a line to the TextBox: "Joe had to draw from the stock"

            textBoxOnForm.Text = textBoxOnForm.Text + name + " asks if anyone has a " + value + "\n";

            int cardQuantity = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    cardQuantity += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        cards.Add(CardsGiven.Deal());
                }
            }
            if (cardQuantity == 0 && stock.Count > 0)
            {
                textBoxOnForm.Text += Name + " had to draw from the stock" + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 2; i <= 14; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValue(value);
                }
            }
            return books;
        }
    }
}
