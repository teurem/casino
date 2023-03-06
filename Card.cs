using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        string[] suits = { "\u2660", "\u2665", "\u2666", "\u2663" };

        string RankRandom;
        string SuitRandom;

        public Card() 
        {
        }

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        Random random = new Random();

        public string getRandomCard()
        {
            RankRandom = ranks[random.Next(ranks.Length)];
            SuitRandom = suits[random.Next(suits.Length)];
            Rank = RankRandom;
            Suit = SuitRandom;
            return Rank+Suit;
        }

        public override string ToString()
        {
            return Rank+Suit;
        }
    }
}
