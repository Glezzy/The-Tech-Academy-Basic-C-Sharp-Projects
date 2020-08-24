using System;
using System.Collections.Generic;

namespace _21cardgame
{
    class Program
    {
        static void Main(string[] args) // void means it returns nothing
                                        // contain parameters or lack of parameters aka "args"
                                        // methods have to be apart of a class
                                        // if methods are used without creating an object of that class then it is static.
        {
            deck deck = new deck();

            deck = shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            };
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static deck shuffle(deck deck) // takes a parameter of type deck
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();
            
            while (deck.Cards.Count > 0)
            {
                int randomindex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomindex]);
                deck.Cards.RemoveAt(randomindex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
