using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbledCards
{
    class Card
    {
        private Suit suit;
        private Face face;

        public Suit Suit { get { return suit; } }
        public Face Face { get { return face; } }

        public Card(Suit suit, Face face)
        {
            this.suit = suit;
            this.face = face;
        }

        public string Name
        {
            get { return face.ToString() + " of " + suit.ToString();}
        }

        public override string ToString()
        {
            return Name;
        }
    }

    enum Suit { Spade, Heart, Club, Diamond }

    enum Face
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
