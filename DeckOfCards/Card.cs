using System;

namespace DeckOfCards
{
    public class Card
    {
        public enum Faces
        {
            None,
            Jack,
            Queen,
            King,
            Ace
        }

        public enum Suits
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }

        public Suits Suit { get; set; }
        public int Number { get; set; }
        public Faces Face { get; set; }

        /// <summary>
        ///     Overrides the .ToString method, returning a string describing the card
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var value = Number.ToString();

            if (Face != Faces.None)
            {
                value = Face.ToString();
            }

            return String.Format("{0} of {1}", value, Suit);
        }
    }
}