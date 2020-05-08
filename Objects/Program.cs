using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Unicode is the standard for universal language
            Card card;                      // declare a Card variable
            card = new Card("A", "♥", 14);  // creating a Card (instantiating)
        
            List<Card> deck = new List<Card>(); // creating an empty Card List

            // the value of v:  0    1    2    3    4    5    6    7    8     9   10    11   12  
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "♥", "♦", "♣", "♠" };
            for (int s = 0; s < suits.Length; s++)                  // do this 4 times
            {
                for (int r = 0; r < ranks.Length; r++)             // do this 13 times
                {
                    card = new Card(ranks[r], suits[s], r + 2);   //  so this happens 52 = 4 x 13 times
                    deck.Add(card);
                }
            }
           // deck.ForEach(c => Console.WriteLine(c));            // prints out deck
            
            // foreach (var c in deck) 
            {
                // Console.WriteLine(c);                         // alt to print out deck
            }
            // for (int i = 0; i < deck.Count; i++)
            {
             //   Console.WriteLine(deck[i]);                   // alt to print out deck
            }
            // shuffling the deck
            Random rnd = new Random();                          // create a random number generator
            deck = deck.OrderBy(card => rnd.Next()).ToList();   // order the deck randomly
            // order by value
            deck = deck.OrderBy(card => card.Val).ToList();
            // order by rank
            deck = deck.OrderBy(card => card.Rank).ToList();
            deck.ForEach(c => Console.WriteLine(c));  //

            var hand = deck.Take(5).ToList();                   //  deal 5 cards
            deck.RemoveAll(hand.Contains);                      //  remove all 5 cards from the deck
        }
    }
}
