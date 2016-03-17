using System.Windows.Forms;

namespace Le_jeu_du_21
{
    public partial class Form_Jeu21 : Form
    {
        public Form_Jeu21()
        {
            InitializeComponent();

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
        }
    }
}
