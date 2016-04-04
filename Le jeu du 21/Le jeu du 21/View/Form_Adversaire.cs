using System;
using System.Windows.Forms;

namespace Le_jeu_du_21
{
    public partial class Form_Adversaire : Form
	{
		public Form_Adversaire()
		{
			InitializeComponent();
		}

		private void button_ContreHuman_Click(object sender, EventArgs e)
		{
            /// <summary>
            /// Hide Main Form
            /// </summary>
            Hide();

            /// <summary>
            /// Show Other Form
            /// </summary>
            Form_Risque frm = new Form_Risque();
			frm.groupBox_Joueur2.Enabled = false;
            frm.radioButton1_2_Courageux.Checked = false;
            frm.radioButton2_2_Moyen.Checked = false;
            frm.radioButton3_3_Prudent.Checked = false;
            frm.ShowDialog();

            /// <summary>
            /// Close Application
            /// </summary>
            Close();
		}

		private void button_ContreAI_Click(object sender, EventArgs e)
		{
            /// <summary>
            /// Hide Main Form
            /// </summary>
            Hide();

            /// <summary>
            /// Show Other Form
            /// </summary>
            Form_Risque frm = new Form_Risque();
			frm.ShowDialog();

            /// <summary>
            /// Close Application
            /// </summary>
            Close();
		}
	}
}