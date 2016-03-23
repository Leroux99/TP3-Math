using Le_jeu_du_21.Model;
using System.Windows.Forms;

namespace Le_jeu_du_21
{
    public partial class Form_Jeu21 : Form
    {
		private int JoueurActuel;
		private const int JoueurMax = 1;
        public Form_Jeu21()
        {
            InitializeComponent();
			JoueurActuel = JoueurMax;
            /*Game Card Exemple*/
            Card card = new Card("S2");
            var imgarray  = card.GraphicsCards();
            pictureBox1_Player1.Image = imgarray[0];
            pictureBox2_Player1.Image = imgarray[10];
            pictureBox3_Player1.Image = imgarray[20];
            pictureBox1_Player2.Image = imgarray[30];
            pictureBox2_Player2.Image = imgarray[40];
            pictureBox3_Player2.Image = imgarray[50];

            /*Game Log && Score Center Text*/
            textBox_GameLog.TextAlign = HorizontalAlignment.Center;
            richTextBox_Score1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox_Score2.SelectionAlignment = HorizontalAlignment.Center;
			ShowDialog();
			ChangementJoueur();
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

		private void button_NouvelleCarte_Click(object sender, System.EventArgs e)
		{
			GamePlay.TabJoueur[JoueurActuel].Jouer();
		}

		private void button_Passer_Click(object sender, System.EventArgs e)
		{

		}

		private void button_Arrêter_Click(object sender, System.EventArgs e)
		{

		}

		private void button_DétailsCalculs_Click(object sender, System.EventArgs e)
		{

		}

		private void ChangementJoueur()
		{
			JoueurActuel = JoueurActuel == JoueurMax ? 0 : JoueurActuel += 1;
			if(GamePlay.TabJoueur[JoueurActuel].GetType() == typeof(IA))
			{
				button_NouvelleCarte.Enabled = false;
				button_Passer.Enabled = false;

				System.Threading.Thread.Sleep(2000);
			}
			else
			{
				button_NouvelleCarte.Enabled = true;
				button_Passer.Enabled = true;
			}

		}

	}
}
