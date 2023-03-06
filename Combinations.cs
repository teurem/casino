using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public static class Combinations
    {
        static List<Card> cards = new List<Card>();
        static List<Card> cardsForSuit = new List<Card>();
        public static void getCombinations(Deck deck)
        {
            int kolvoElementov = deck.cardsInHend.Count;

            for (int i = 0; i < kolvoElementov; i++)
            {
                for (int j = i+1; j < kolvoElementov; j++)
                { 
                    if (deck.cardsInHend[i].Rank.Contains(deck.cardsInHend[j].Rank))
                    {
                        cards.Add(deck.cardsInHend[i]);
                        cards.Add(deck.cardsInHend[j]);
                    }
                }
                if (deck.cardsInHend[i].Suit == deck.cardsInHend[i].Suit)
                {
                    cardsForSuit.Add(deck.cardsInHend[i]);
                }
            }
            //Console.WriteLine("jhgfd");
            //foreach (var i in cardsForSuit)
            //{
            //    Console.WriteLine(i);
            //}
            switch (cards.Count)
            {
                case 2:
                    Console.WriteLine("У вас Пара");
                    break;
                case 4:
                    Console.WriteLine("У вас две Пары");
                    break;
                case 6:
                    Console.WriteLine("У вас тройка");
                    break;
                case 5:
                    Console.WriteLine("Флэш");
                    break;
            }
        }
    }
}
