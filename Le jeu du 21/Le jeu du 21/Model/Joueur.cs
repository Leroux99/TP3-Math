namespace Le_jeu_du_21.Model
{
	public abstract class Joueur
	{
		private PaquetCarte Hand;
		public Joueur()
		{
			Hand = new PaquetCarte();
		}

		//Abstract class that will call its child's Jouer() class. It will let the player play.
		public abstract void Jouer();

		//Get the player's current score
		public int GetScore()
		{
			return new LeJeuDu21ScoreCounter().CountScore(Hand);
		}

		//To clear the player's hand after a game
		public void ClearHand()
		{
			Hand.ClearHand();
		}

		public void AddCard(Card C)
		{
			Hand.TakeCard(C);
		}
	}
}
