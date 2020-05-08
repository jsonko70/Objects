using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class Card
    {
        // card data
        string rank;
        string suit;
        int val;

        public Card(string rank, string suit, int val)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Val = val;
        }

        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }

        public override string ToString()
        {
            return Rank + " " + Suit;
        }
    }
}