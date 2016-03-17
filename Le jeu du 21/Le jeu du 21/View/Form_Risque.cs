using System;
using System.Windows.Forms;

namespace Le_jeu_du_21
{

    public partial class Form_Risque : Form
    {
        public Form_Risque()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // hide main form
            Hide();

            // show other form
            Form_Jeu21 frm = new Form_Jeu21();
            if (groupBox_Joueur2.Enabled == false)
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
    }
}