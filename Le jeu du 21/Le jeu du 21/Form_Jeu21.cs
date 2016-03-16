using System.Windows.Forms;

namespace Le_jeu_du_21
{
    public partial class Form_Jeu21 : Form
    {
        public Form_Jeu21()
        {
            InitializeComponent();

            Card card = new Card("S2");
            var imgarray  = card.GraphicsCards();
            pictureBox_Player1.Image = imgarray[0];
            pictureBox_Player2.Image = imgarray[51];
        }
    }
}
