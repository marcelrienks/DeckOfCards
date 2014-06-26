using System;

namespace DeckOfCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShowDeckOfCards();
            Console.WriteLine("============================================");
            ShowShuffledDeckOfCards();
            Console.ReadKey();
        }

        /// <summary>
        ///     Shows a Deck of Cards to the Console
        /// </summary>
        private static void ShowDeckOfCards()
        {
            foreach (var card in new Deck().GenerateDeckOfCards().Cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        /// <summary>
        ///     Shows a Shuffled Deck of cards to the Console
        /// </summary>
        private static void ShowShuffledDeckOfCards()
        {
            foreach (var card in new Deck().GenerateShuffledDeckOfCards(3).Cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}