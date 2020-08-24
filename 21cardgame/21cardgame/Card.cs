using System;
using System.Collections.Generic;
using System.Text;

namespace _21cardgame
{
    public class Card
    {
        public Card()       // constructor method name is alwasy the name of the class.
        {
            suit = "Spades";
            face = "Two";
        }
        public string suit { get; set; }
        public string face { get; set; }
    }
}
