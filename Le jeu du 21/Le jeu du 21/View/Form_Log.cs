using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Le_jeu_du_21.View
{
    public partial class Form_Log : Form
    {
        /// <summary>
        /// Ne peux Dépasser 23
        /// </summary>
        private const int distance = 23;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        ///  /// <param name="Actions">Passé les actions au Log</param>
        public Form_Log(List<string> Actions)
        {
            InitializeComponent();

            foreach (string Line in Actions) textBox1.Text += Line + "\r\n";

        }

		private void button_OK_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		public void Clear()
		{
			textBox1.Text = "";
		}
	}
}