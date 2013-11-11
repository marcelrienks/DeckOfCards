using System;
using System.Collections.Generic;

namespace DeckOfCards {
	public class Deck {

		#region Properties
		public List<Card> Cards { get; set; } 
		#endregion

		public Deck() {
			Cards = new List<Card>();
		}

		/// <summary>
		/// Generates an Ordered Deck of cards
		/// </summary>
		/// <returns>Deck</returns>
		public Deck GenerateDeckOfCards() {
			for (var ctNumber = 1; ctNumber < 14; ctNumber++) {
				foreach (var suit in Enum.GetValues(typeof(Card.Suits))) {
					Cards.Add(new Card {
						Suit = (Card.Suits)suit,
						Number = ctNumber,
						Face = GetCardFace(ctNumber)
					});
				}
			}

			return this;
		}

		/// <summary>
		/// Generates a Randomly Shuffled Deck of Carrds
		/// </summary>
		/// <param name="numberOfShuffles"></param>
		/// <returns>Deck</returns>
		public Deck GenerateShuffledDeckOfCards(int numberOfShuffles) {
			//Generate an ordered Deck of cards
			var shuffledDeckOfCards = GenerateDeckOfCards();

			//Loop through the ammount of shuffles passed in
			for (var ctShuffles = 0; ctShuffles < numberOfShuffles; ctShuffles++) {

				//Create a temporary deck of cards which is shuffled
				var temporaryDeck = new Deck {
					Cards = new List<Card>()
				};

				//Loop through number of cards in Deck, and randomly select a card, passing it into the temporary deck of cards
				for (var ctRange = 51; ctRange > -1; ctRange--) {
					var randomCard = new Random().Next(0, ctRange);

					temporaryDeck.Cards.Add(shuffledDeckOfCards.Cards[randomCard]);
					shuffledDeckOfCards.Cards.RemoveAt(randomCard);
				}

				//Assign temporary deck of cards back to shuffled deck
				shuffledDeckOfCards = temporaryDeck;
			}

			return shuffledDeckOfCards;
		}

		/// <summary>
		/// Returns a card Face, based on the number of the card passed in
		/// </summary>
		/// <param name="number"></param>
		/// <returns>Card.Faces</returns>
		private Card.Faces GetCardFace(int number) {
			switch (number) {
				case 1:
					return Card.Faces.Ace;
				case 11:
					return Card.Faces.Jack;
				case 12:
					return Card.Faces.Queen;
				case 13:
					return Card.Faces.King;
				default:
					return Card.Faces.None;
			}
		}
	}
}
