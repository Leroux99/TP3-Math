using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_jeu_du_21.Model
{
	public static class Jeu
	{
		public static Joueur Joueur1;
		public static Joueur Joueur2;
		public static List<int> Scores = new List<int>();
		public static List<string> NVRName = new List<string>();
		public static Joueur.Risk_Level theName = Joueur.Risk_Level.Standard;
		public static bool Standard = false;
		public static int Joueur1_Score = 0;
		public static int Joueur2_Score = 0;
		public static int ScoresPerRounds = 0;
		public static int numericupdownNumber = 10000;
		public static List<String> Log = new List<string>();
		public const int PAUSE = 1000;
		public static List<Form> Liste = new List<Form>();
		public static Form_Adversaire principale;
	}
}
