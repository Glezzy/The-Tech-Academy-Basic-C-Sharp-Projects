using System;
using System.Collections.Generic;
using System.Text;

namespace _21cardgame
{
    public class deck
    {
        public deck()
        {
            Cards = new List<Card>();
            List<string> suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> faces = new List<string>()
            {
                "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in faces)
            {
                foreach (string suit in suits)
                {
                    Card card = new Card();
                    card.suit = suit;
                    card.face = face;
                    Cards.Add(card);
                }
            }


        }
        public List<Card> Cards { get; set; }
    }
}
