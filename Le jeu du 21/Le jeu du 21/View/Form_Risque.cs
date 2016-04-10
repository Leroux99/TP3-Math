using System;
using System.Linq;
using Le_jeu_du_21.Model;
using System.Windows.Forms;

namespace Le_jeu_du_21
{

	public partial class Form_Risque : Form
	{
        /// <summary>
        /// Variables
        /// </summary>
        public Joueur.Risk_Level Player1;
        public Joueur.Risk_Level Player2;
        public bool Player1_Playable;
        public bool Player2_Playable;

        /// <summary>
        /// Form Constructor
        /// </summary>
        public Form_Risque()
		{
			InitializeComponent();
            Player1 = Player2 = Joueur.Risk_Level.Aucun;
        }

        /// <summary>
        /// Ok Button
        /// </summary>
		private void button_OK_Click(object sender, EventArgs e)
		{
			// hide main form
			Hide();

            //GamePlay.NombrePartie = Convert.ToInt32(numericUpDown1.Value);

            if (groupBox_Joueur1.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                Player1 = (Joueur.Risk_Level)Enum.Parse(typeof(Joueur.Risk_Level), groupBox_Joueur1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
                Player1_Playable = checkBox_Comptage.Checked;
            }

            if (groupBox_Joueur2.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                Player2 = (Joueur.Risk_Level)Enum.Parse(typeof(Joueur.Risk_Level), groupBox_Joueur2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
                Player2_Playable = checkBox_Comptage.Checked;

				if (Player1 == Joueur.Risk_Level.Aucun) Jeu.Joueur1 = new Joueur();
				else Jeu.Joueur1 = new Joueur(Player1, Player1_Playable);
				if (Player2 == Joueur.Risk_Level.Aucun) Jeu.Joueur2 = new Joueur();
				else Jeu.Joueur2 = new Joueur(Player2, Player2_Playable);
            }
			else
			{
				if (Player2 == Joueur.Risk_Level.Aucun) Jeu.Joueur1 = new Joueur();
				else Jeu.Joueur1 = new Joueur(Player2, Player2_Playable);
				if (Player1 == Joueur.Risk_Level.Aucun) Jeu.Joueur2 = new Joueur();
				else Jeu.Joueur2 = new Joueur(Player1, Player1_Playable);
			}

			Jeu.Joueur1.NumeroJoueur = 1;
			Jeu.Joueur2.NumeroJoueur = 2;
			Jeu.numericupdownNumber = Convert.ToInt32(numericUpDown1.Value);

			// show other form
			Form_Jeu21 frm = new Form_Jeu21();
			if (groupBox_Joueur2.Enabled)
			{
				frm.button_NouvelleCarte.Enabled = false;
				frm.button_Passer.Enabled = false;
			}
			frm.ShowDialog();
			// close application
			Close();
		}

        /// <summary>
        /// Annuler Button
        /// </summary>
		private void button_Annuler_Click(object sender, EventArgs e)
		{
			// hide main form
			Hide();

			// show other form
			Form_Adversaire frm = new Form_Adversaire();
			frm.ShowDialog();

			// close application
			Close();
		}
	}
}