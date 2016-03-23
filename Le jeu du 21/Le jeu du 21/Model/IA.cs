namespace Le_jeu_du_21.Model
{
    public class IA : Joueur
    {
		private bool hasPassed; //when the AI passes, it stores it in this variable so it doesnt have to do the maths again
		private int Chance;
		public IA()
		{
			hasPassed = false;
			Chance = 80;
		}
		public IA(int PourcentageChance)
		{
			hasPassed = false;
			Chance = PourcentageChance;
		}

		//Makes the AI play
		public override void Jouer()
		{

		}
	}
}
