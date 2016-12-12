using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbledCards
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numberOfCards = 10;

            Random random = new Random();

            List<Card> cardList = new List<Card>();

            createCards(numberOfCards, random, cardList);

            cardList.Sort(new CardComparer_byValue());

            Console.WriteLine("\nThose same cards, sorted: ");
            foreach (Card card in cardList)
            {
                Console.WriteLine(card.ToString());
            }

            Console.ReadKey();
        }

        private static void createCards(int numberOfCards, Random random, List<Card> cardList)
        {
            Console.WriteLine("{0} random cards: ", numberOfCards.ToString());

            for (int i = 0; i < numberOfCards; i++)
            {

                Card card = new Card((Suit)random.Next(4), (Face)random.Next(2, 15));
                Console.WriteLine(card.ToString());
                cardList.Add(card);
            }
        }
    }
}
