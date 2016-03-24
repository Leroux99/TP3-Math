using Le_jeu_du_21.Model;
using System;
using System.Windows.Forms;

namespace Le_jeu_du_21
{

	public partial class Form_Risque : Form
	{
		int[] Pourcents;
		public Form_Risque()
		{
			InitializeComponent();
			radioButton1_Courageux.Checked = true;
			radioButton1_2_Courageux.Checked = true;
			Pourcents = new int[] { Convert.ToInt32(radioButton1_Courageux.Tag), Convert.ToInt32(radioButton1_2_Courageux.Tag) };
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			// hide main form
			Hide();
			SetPercentage();
			GamePlay.NombrePartie = Convert.ToInt32(numericUpDown1.Value);

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

		private void SetPercentage()
		{
			if (!groupBox_Joueur2.Enabled) GamePlay.TabJoueur = new Joueur[] { new Humain(), new IA(Pourcents[0]) };
			else
			{
				GamePlay.TabJoueur = new Joueur[] { new IA(Pourcents[0]), new IA(Pourcents[1]) };
				GamePlay.AllIA = true;
			}
		}

		private void Joueur1_Check_Changed(object sender, EventArgs e)
		{
			Pourcents[0] = Convert.ToInt32(Tag);
		}

		private void Joueur2_Check_Changed(object sender, EventArgs e)
		{
			Pourcents[1] = Convert.ToInt32(Tag);
		}
	}
}