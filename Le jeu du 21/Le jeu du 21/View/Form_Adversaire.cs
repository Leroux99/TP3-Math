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

        private void button_ContreAI_Click(object sender, EventArgs e)
        {
            // hide main form
            Hide();

            // show other form
            Form_Risque frm = new Form_Risque();
            frm.ShowDialog();

            // close application
            Close();
        }

        private void button_ContreHuman_Click(object sender, EventArgs e)
        {
            // hide main form
            Hide();

            // show other form
            Form_Risque frm = new Form_Risque();
            frm.ShowDialog();

            // close application
            Close();
        }
    }
}