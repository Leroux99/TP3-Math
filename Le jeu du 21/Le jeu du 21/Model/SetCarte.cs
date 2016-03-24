using System.Collections.Generic;

namespace Le_jeu_du_21.Model
{
	/// <summary>
	/// The class is basically a wrapper over the list of cards
	/// </summary>
	public class SetCarte
	{
		/// <summary>
		/// List of cards in a set
		/// </summary>
		protected List<Card> cards = new List<Card>();

		/// <summary>
		/// The method adds new card to the set
		/// </summary>
		/// <param name="card">The card to be added</param>
		public void AddCard(Card card)
		{
			cards.Add(card);
		}


		/// <summary>
		/// Indexer for a card in a set
		/// </summary>
		/// <param name="idx">Index of a card</param>
		/// <returns>The card with index <paramref name="idx"/></returns>
		public Card this[int idx]
		{
			get { return cards[idx]; }
			set { cards[idx] = value; }
		}


		/// <summary>
		/// Returns the number of cards in the set
		/// </summary>
		/// <returns>The number of cards in the set</returns>
		public int GetCardsNumber()
		{
			return cards.Count;
		}


		/// <summary>
		/// The method removes all cards from the set
		/// </summary>
		public void Clear()
		{
			cards.Clear();
		}
	}
}
