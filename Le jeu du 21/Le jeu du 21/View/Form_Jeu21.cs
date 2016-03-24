using Le_jeu_du_21.Model;
using System.Windows.Forms;

namespace Le_jeu_du_21
{
	public partial class Form_Jeu21 : Form
	{
		private int JoueurActuel;
		private int TourJoue;
		private const int JoueurMax = 1;
		public Form_Jeu21()
		{
			InitializeComponent();
			/*Game Card Exemple*/
			//Card card = new Card("S2");
			//var imgarray  = card.GraphicsCards();
			//pictureBox1_Player1.Image = imgarray[0];
			//pictureBox2_Player1.Image = imgarray[10];
			//pictureBox3_Player1.Image = imgarray[20];
			//pictureBox1_Player2.Image = imgarray[30];
			//pictureBox2_Player2.Image = imgarray[40];
			//pictureBox3_Player2.Image = imgarray[50];
			/*Game Log && Score Center Text*/
		}

		public void Reset()
		{
			Controls.Clear();
			InitializeComponent();
		}

		private void button_Rejouer_Click(object sender, System.EventArgs e)
		{
			// hide main form
			Hide();

			// show other form
			Form_Adversaire frm = new Form_Adversaire();
			frm.ShowDialog();

			// close application
			Close();
		}

		private void Jouer(object sender, System.EventArgs e)
		{
			GamePlay.TabJoueur[JoueurActuel].Jouer();
			//TODO Afficher carte
			ChangementTour();
		}

		private void Passer(object sender, System.EventArgs e)
		{
			//TODO Afficher X à la position de la carte
			ChangementTour();
		}

		private void button_Arrêter_Click(object sender, System.EventArgs e)
		{
			//TODO Arrêter la partie
		}

		private void button_DétailsCalculs_Click(object sender, System.EventArgs e)
		{
			//TODO afficher une forme avec les détails
		}

		private void ChangementTour()
		{
			if (JoueurActuel == JoueurMax) TourJoue++;
			if (TourJoue == GamePlay.NombreTourMax) FinPartie();
			else
			{
				JoueurActuel = JoueurActuel == JoueurMax ? 0 : JoueurActuel + 1;
				AfficherTextes();
				GestionProchainTour();
			}
		}

		private void GestionProchainTour()
		{
			if (GamePlay.TabJoueur[JoueurActuel].GetType() == typeof(IA)) TourIA();
			else TourHumain();
		}

		private void FinPartie()
		{
			MessageBox.Show("MessageBox temporaire qui montre lorsqu'une nouvelle partie commence.");
			//Afficher le gagnant
			GamePlay.PartieJouee++;
			if (GamePlay.PartieJouee == GamePlay.NombrePartie) button_Rejouer_Click(null, null);
			else Reset();
		}

		private void TourHumain()
		{
			button_NouvelleCarte.Enabled = true;
			button_Passer.Enabled = true;
		}

		private void TourIA()
		{
			button_NouvelleCarte.Enabled = false;
			button_Passer.Enabled = false;
			System.Threading.Thread.Sleep(2000);
			if (GamePlay.PeutJouer((IA)GamePlay.TabJoueur[JoueurActuel])) Jouer(null, null);
			else Passer(null, null);
		}

		private void AfficherTextes()
		{
			textBox_GameLog.Text = "Au tour du joueur " + (JoueurActuel + 1) + " de jouer. Vous avez " +
				GamePlay.TabJoueur[JoueurActuel].GetScore() + " points.";
			richTextBox_Score1.Text = GamePlay.TabJoueur[0].GetScore().ToString();
			richTextBox_Score2.Text = GamePlay.TabJoueur[1].GetScore().ToString();

			textBox_GameLog.TextAlign = HorizontalAlignment.Center;
			richTextBox_Score1.SelectionAlignment = HorizontalAlignment.Center;
			richTextBox_Score2.SelectionAlignment = HorizontalAlignment.Center;
			this.Refresh();
		}
	}
}
