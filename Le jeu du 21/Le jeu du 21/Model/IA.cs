namespace Le_jeu_du_21.Model
{
    public class IA : Joueur
    {
		private int Chance;
		public IA()
		{
			Chance = 80;
		}
		public IA(int PourcentageChance)
		{
			Chance = PourcentageChance >= 0 && PourcentageChance <= 100 ? PourcentageChance : 80;
		}

		public int GetPourcentage()
		{
			return Chance;
		}
	}
}
