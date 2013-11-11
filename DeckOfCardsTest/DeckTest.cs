using DeckOfCards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeckOfCardsTest {
	/// <summary>
	///This is a test class for DeckTest and is intended
	///to contain all DeckTest Unit Tests
	///</summary>
	[TestClass]
	public class DeckTest {

		/// <summary>
		///A test for GenerateDeckOfCards
		///</summary>
		[TestMethod]
		public void GenerateDeckOfCardsTest() {
			var actual = new Deck().GenerateDeckOfCards();

			AssertCommonFacts(actual);

			//todo//assert that cards are in sequence
		}

		/// <summary>
		///A test for GenerateShuffledDeckOfCards
		///</summary>
		[TestMethod]
		public void GenerateShuffledDeckOfCardsTest() {
			var actual = new Deck().GenerateShuffledDeckOfCards(1);

			AssertCommonFacts(actual);

			//todo//assert that cards are not in sequence
		}

		private void AssertCommonFacts(Deck actual) {
			//Assert basic facts of a deck of cards
			Assert.IsNotNull(actual);
			Assert.IsNotNull(actual.Cards);
			Assert.AreEqual(actual.Cards.Count, 52);

			//Assert that there are no duplicates
			for (var ct1 = 0; ct1 < actual.Cards.Count; ct1++) {
				var card1 = actual.Cards[ct1];

				for (var ct2 = 0; ct2 < actual.Cards.Count; ct2++) {
					var card2 = actual.Cards[ct2];

					if (ct1 != ct2) {
						Assert.AreNotSame(card1, card2);
					}
				}
			}
		}
	}
}
