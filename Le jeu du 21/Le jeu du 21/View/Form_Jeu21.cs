using Le_jeu_du_21.View;
using Le_jeu_du_21.Model;
using System.Windows.Forms;
using System.ComponentModel;

namespace Le_jeu_du_21
{
	public partial class Form_Jeu21 : Form
	{
		/// <summary>
		/// Variables From Others Forms
		/// </summary>
		private PaquetCarte paquetCarte;
		private Joueur[] TabJoueur;
		private int JoueurActuel;
		private BackgroundWorker bw;
		private bool Quitter;

		/// <summary>
		/// Variables For this Form
		/// </summary>
		private int rounds;
		private const int pointingGoal = 21;

		/// <summary>
		/// InitializeComponent
		/// </summary>
		public Form_Jeu21()
		{
			InitializeComponent();
			//----------------------------------------//
			bw = new BackgroundWorker();
			bw.DoWork += StartIA;
			bw.RunWorkerCompleted += IAWork;
			paquetCarte = new PaquetCarte();
			Jeu.Joueur1.setUserControl(leJeuDu21_UserControl1);
			Jeu.Joueur2.setUserControl(leJeuDu21_UserControl2);
			TabJoueur = new Joueur[] { Jeu.Joueur1, Jeu.Joueur2 };
			JoueurActuel = 0;
			rounds = 1;
			Quitter = false;
			Jeu.Log.Add("DÉBUT DE LA PARTIE NUMÉRO " + rounds + "!");
			ifAllAI();
		}

		private void ifAllAI()
		{
			int nbr = 0;
			foreach (Joueur j in TabJoueur) if (j.AI_Player) nbr++;
			if (nbr == TabJoueur.Length) bw.RunWorkerAsync();
		}

		private void StartIA(object sender, DoWorkEventArgs e)
		{
			System.Threading.Thread.Sleep(Jeu.PAUSE);
		}

		private void IAWork(object sender, RunWorkerCompletedEventArgs e)
		{
			Jouer(null, null);
		}
		/// <summary>
		/// Start the game
		/// </summary>
		private void Jouer(object sender, System.EventArgs e)
		{
			TabJoueur[JoueurActuel].LJDUSER.AddCard(paquetCarte.drawaCard());
			if (!EndOfGame()) ChangerJoueur();
		}

		private void ResetForm()
		{
			if (rounds < Jeu.numericupdownNumber)
			{
				for(int i = 0; i < TabJoueur.Length; i++)
				{
					TabJoueur[i].NewGame();
					TabJoueur[i].LJDUSER.Reset();
				}
				paquetCarte = new PaquetCarte();
				JoueurActuel = 0;
				rounds++;
				Jeu.Log.Add("DÉBUT DE LA PARTIE NUMÉRO " + rounds + "!");
				TabJoueur[JoueurActuel].AddToLog("J'ai un pointage de 10 et moins, donc je pige.");
				ifAllAI();
			}
			else
			{
				button_Passer.Enabled = false;
				button_NouvelleCarte.Enabled = false;
			}
		}
		private void ChangerJoueur()
		{
			if (!Quitter)
			{
				JoueurActuel = JoueurActuel == 1 ? 0 : 1;
				if (TabJoueur[JoueurActuel].AI_Player)
				{
					button_NouvelleCarte.Enabled = false;
					button_Passer.Enabled = false;
					IA_Jouer(TabJoueur[JoueurActuel]);
				}
				else
				{
					button_NouvelleCarte.Enabled = true;
					button_Passer.Enabled = true;
				}
			}
		}

		/// <summary>
		/// AI Algorithm
		/// </summary>
		private void IA_Jouer(Joueur IA)
		{
			Joueur autreJoueur = IA == TabJoueur[0] ? TabJoueur[1] : TabJoueur[0];

			if (autreJoueur.totalScores > pointingGoal)
			{
				IA.GameOver = true;
				Passer(null, null);
				IA.AddToLog("Mon adversaire à déjà perdu, donc je passe.");
			}
			else if (autreJoueur.totalScores == pointingGoal)
			{
				bw.RunWorkerAsync();
				IA.AddToLog("Mon adversaire à 21, donc je pige.");
			}
			else if (IA.totalScores <= 10)
			{
				bw.RunWorkerAsync();
				IA.AddToLog("J'ai un pointage de 10 et moins, donc je pige.");
			}
			else if (IA.pigeUneCarte(paquetCarte.Probability(pointingGoal - IA.totalScores, IA.countCards, IA)))
			{
				bw.RunWorkerAsync();
			}
			else
			{
				IA.GameOver = true;
				Passer(null, null);
			}
		}

		/// <summary>
		/// Check if the Game is Over
		/// </summary>
		public bool EndOfGame()
		{
			if (TabJoueur[0].totalScores >= pointingGoal)
			{
				TabJoueur[0].GameOver = true;
			}

			if (TabJoueur[1].totalScores >= pointingGoal)
			{
				TabJoueur[1].GameOver = true;
			}

			if (TabJoueur[0].GameOver && TabJoueur[1].GameOver)
			{
				EndOfTheGame();
				return true;
			}
			return false;
		}

		/// <summary>
		/// Display the winner and display the message
		/// </summary>
		public void EndOfTheGame()
		{
			string messageDeFin = "";

			button_Arrêter.Enabled = false;
			button_Rejouer.Visible = true;

			if (TabJoueur[0].totalScores > pointingGoal && TabJoueur[1].totalScores > pointingGoal)
			{
				messageDeFin = "Les Joueurs ont tous les deux perdu, BAHOOOOO !";
			}
			else if (TabJoueur[0].totalScores > pointingGoal || TabJoueur[1].totalScores > pointingGoal)
			{
				if (TabJoueur[0].totalScores < TabJoueur[1].totalScores)
				{
					messageDeFin = "Le Joueur 1 à gagné, YAHOOOOO !";
					++Jeu.Joueur1_Score;
					++Jeu.ScoresPerRounds;
				}
				else if (TabJoueur[1].totalScores < TabJoueur[0].totalScores)
				{
					messageDeFin = "Le Joueur 2 à gagné, YAHOOOOO !";
					++Jeu.Joueur2_Score;
					++Jeu.ScoresPerRounds;
				}
			}
			else
			{
				if (TabJoueur[0].totalScores == TabJoueur[1].totalScores)
				{
					messageDeFin = "Partie Nulle, BAHOOOOO !";
				}
				else if (TabJoueur[0].totalScores > TabJoueur[1].totalScores)
				{
					messageDeFin = "Le Joueur 1 à gagné, YAHOOOOO !";
					++Jeu.Joueur1_Score;
					++Jeu.ScoresPerRounds;
				}
				else
				{
					messageDeFin = "Le Joueur 2 à gagné, YAHOOOOO !";
					++Jeu.Joueur2_Score;
					++Jeu.ScoresPerRounds;
				}
			}
			if (!Jeu.Standard && !Quitter) MessageBox.Show(messageDeFin);
			Jeu.Log.Add(messageDeFin);
			Jeu.Log.Add("FIN DE LA PARTIE NUMÉRO " + rounds + "!");
			ResetForm();
		}

		/// <summary>
		/// Show The log For the current player.
		/// </summary>
		private void ShowTextInTextBox(object sender, System.EventArgs e)
		{
			textBox_GameLog.Text = "Au tour du joueur " + Jeu.theName.ToString() + " de jouer. Vous avez " + LeJeuDu21_UserControl.ScoreASValue.ToString() + " points.";

			textBox_GameLog.TextAlign = HorizontalAlignment.Center;
			Refresh();
		}

		/// <summary>
		/// BTN PASSER
		/// </summary>
		private void Passer(object sender, System.EventArgs e)
		{
			TabJoueur[JoueurActuel].GameOver = true;
			if (!EndOfGame()) ChangerJoueur();
		}

		/// <summary>
		/// JOURNAL
		/// </summary>
		private void BTN_IA1_Journal_Click(object sender, System.EventArgs e)
		{
			new Form_Log(Jeu.Log).ShowDialog();
		}

		/// <summary>
		/// BTN REJOUER
		/// </summary>
		private void button_Rejouer_Click(object sender, System.EventArgs e)
		{
			Quitter = true;
			Jeu.Log.Clear();
			// Hide main form
			Hide();

			// Show other form
			Form_Adversaire frm = new Form_Adversaire();
			frm.ShowDialog();

			// Close application
			Close();
			}

		/// <summary>
		/// BTN ARRETER LA PARTIE
		/// </summary>
		private void button_Arrêter_Click(object sender, System.EventArgs e)
		{
			EndOfTheGame();
			button_NouvelleCarte.Enabled = false;
			button_Passer.Enabled = false;
		}

		/// <summary>
		/// TOOLSTRIP QUITTER
		/// </summary>
		private void quitterToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}