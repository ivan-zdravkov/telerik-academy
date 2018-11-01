// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
// The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class PlayingCards
{
	static void Main()
	{
        string[] colors = {"Diamonds", "Spades", "Hearts", "Clubs"};
        string[] cards = {"Ace", "Two", "Three", "Four", "Five", "Six",  "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < colors.Length; j++)
            {
                Console.Write("{0,18}", cards[i] + " of " + colors[j]);
            }
            Console.WriteLine();
        }
    }
}

