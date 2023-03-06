using casino;
using Microsoft.VisualBasic;
using System;

Card card = new Card();
Deck deck = new Deck();
int cardsInHendNumber = 5;

deck.MixDeck();

for (int i = 0; i < cardsInHendNumber; i++)
{
    deck.getCardInDeck();
    Console.Write(i + 1 + ")");
    Console.Write(deck.cardsInHend[i] + " ");
}
Console.WriteLine("\n");
Console.WriteLine("Введите номера карт, которые вы хотите заменить через пробел");
Console.WriteLine("Например, 1 3 4 - заменят 1, 3 и 4 карты соответсвенно");

//int UserChoice = Convert.ToInt32(Console.ReadLine());
string UserChoice = Console.ReadLine();

//string[] arrUserChoice = UserChoice.Split(" ");

int[] a = UserChoice.Split(' ').
          Where(x => !string.IsNullOrWhiteSpace(x)).
          Select(x => int.Parse(x)).ToArray();

for (int i = 0; i < a.Length; i++)
{
    switch (a[i])
    {
        case 1:
            deck.getCardInDeck();
            deck.cardsInHend[0] = deck.cardsInHend.Last();
            deck.cardsInHend.RemoveAt(5);
            break;
        case 2:
            deck.getCardInDeck();
            deck.cardsInHend[1] = deck.cardsInHend.Last();
            deck.cardsInHend.RemoveAt(5);
            break;
        case 3:
            deck.getCardInDeck();
            deck.cardsInHend[2] = deck.cardsInHend.Last();
            deck.cardsInHend.RemoveAt(5);
            break;
        case 4:
            deck.getCardInDeck();
            deck.cardsInHend[3] = deck.cardsInHend.Last();
            deck.cardsInHend.RemoveAt(5);
            break;
        case 5:
            deck.getCardInDeck();
            deck.cardsInHend[4] = deck.cardsInHend.Last();
            deck.cardsInHend.RemoveAt(5);
            break;
    }
}
foreach (Card i in deck.cardsInHend)
{
    Console.Write(i + " ");
}

Combinations.getCombinations(deck);

//Card card = new Card("4", "\u2600");
//Card card1 = new Card("2", "\u2660");
//Card card2 = new Card("1", "\u2600");
//Card card3 = new Card("3", "\u2600");
//Card card4 = new Card("9", "\u2600");

//Deck deck = new Deck(card, card1, card2, card3, card4);

//Combinations.getCombinations(deck);

