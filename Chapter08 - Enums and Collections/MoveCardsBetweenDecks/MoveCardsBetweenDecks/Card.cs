﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveCardsBetweenDecks
{
    class Card
    {
        public Suits Suit;
        public Values Value;
        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return "A" + Name + "s";
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    enum Suits
    {
        Spades, Clubs, Diamonds, Hearts
    }

    enum Values
    {
        Two = 2, 
        Three = 3, 
        Four = 4, 
        Five = 5, 
        Six = 6, 
        Seven = 7, 
        Eight = 8,
        Nine = 9, 
        Ten = 10,
        Jack = 11,
        Queen = 12, 
        King = 13,
        Ace = 14
    }
}