using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Deck : IDeck
    {
        public Card card { get; set; }
        //List<Card> cardsInHend { get; set; }

        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        string[] suits = { "\u2660", "\u2665", "\u2666", "\u2663" };

        List<Card> deck = new List<Card>();

        public List<Card> cardsInHend = new List<Card>();

        Random random = new Random();

        //public Deck(Card card1, Card card2, Card card3, Card card4, Card card5)
        //{ 
        //    cardsInHend.Add(card1);
        //    cardsInHend.Add(card2);
        //    cardsInHend.Add(card3);
        //    cardsInHend.Add(card4);
        //    cardsInHend.Add(card5);
        //    foreach (var decks in cardsInHend)
        //    {

        //        Console.WriteLine(decks);
        //    }
        //}

        public Deck() 
        {
                for (int i = 0; i < ranks.Length; i++)
                {
                    for (int j = 0; j < suits.Length; j++)
                    {
                        card = new Card(ranks[i], suits[j]);
                        deck.Add(card);
                    }
                }
            //foreach (var decks in deck)
            //{

            //    Console.WriteLine(decks);
            //}
        }   

        public void getCardInDeck()
        {
            card = deck[random.Next(deck.Count)];
            cardsInHend.Add(card);
            deck.Remove(card);
            //Console.WriteLine(" ");
            //foreach (var decks in deck)
            //{

            //    Console.WriteLine(decks);
            //}
        }


        public void MixDeck()
        {
            for (int i = deck.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                Card tmp = deck[j];
                deck[j] = deck[i];
                deck[i] = tmp;
            }

            //foreach (var decks in deck)
            //{

            //    Console.WriteLine(decks);
            //}
        }
    }
}
