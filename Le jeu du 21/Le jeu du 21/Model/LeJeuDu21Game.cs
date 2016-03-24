namespace Le_jeu_du_21.Model
{
	public static class GamePlay
    {
		public static Joueur[] TabJoueur = null;
		public static int NombrePartie = 1;
		public const int NombreTourMax = 3;
		public static int PartieJouee = 0;

		public static bool PeutJouer(IA ia)
		{
			//TODO La fonction qui détermine si le AI peut jouer ou non.
			return true;
		}
    }
}