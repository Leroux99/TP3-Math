namespace Le_jeu_du_21.Exceptions
{
	class BustException : LeJeuDu21Exception
	{
		// The name of a cardholder who's been busted
		private string nomJoueur;

		// The score of a cardholder who's been busted
		private int score;


		/// <summary>
		/// Name property
		/// </summary>
		public string PlayerName
		{
			get { return nomJoueur; }
			set { nomJoueur = value; }
		}

		/// <summary>
		/// Initializes BustException with the name and the total score of a cardholder who's been busted
		/// </summary>
		/// <param name="name">Card holder's name</param>
		/// <param name="s">Card holder's score</param>
		public BustException(string name = "Unknown", int s = 22)
		{
			score = s;
			message = name + " : bust!\n Score: " + s;
		}
	}
}
