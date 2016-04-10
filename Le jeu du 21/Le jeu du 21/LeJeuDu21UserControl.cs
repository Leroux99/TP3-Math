using System;
using System.Drawing;
using Le_jeu_du_21.Model;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Le_jeu_du_21
{
    public partial class LeJeuDu21_UserControl : UserControl
    {
        /// <summary>
        /// Pictures of all the cards
        /// </summary>
        public static Bitmap CardsPictures;

        /// <summary>
        /// The cards each player has.
        /// </summary>
        List<Card> Cards_Hand;

        /// <summary>
        /// Image data into pixels of a card.
        /// </summary>
        private const int LARGEURCARTE = 73;
        private const int HAUTEURCARTE = 98;

        /// <summary>
        /// How many cards each player in hand.
        /// </summary>
        private int CardInPlayerHand;

        /// <summary>
        /// Message Log During Game
        /// </summary>
        private const string messageScore = "Scores: ";
        private const string messageWave = "Tours: ";

        /// <summary>
        /// Send Score to Form_Jeu21
        /// </summary>
        public static string ScoreASValue { get; private set; }

        /// <summary>
        /// InitializeComponent
        /// </summary>
        public LeJeuDu21_UserControl()
        {
            InitializeComponent();
            try
            {
                Cards_Hand = new List<Card>();
                CardsPictures = new Bitmap(Properties.Resources.card);
                CardInPlayerHand = 0;
				RefreshScore();
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }

        /// <summary>
        /// Reset Game
        /// </summary>
        public void Reset()
        {
            Cards_Hand.Clear();
            CardInPlayerHand = 0;
			RefreshScore();
			panel1.Controls.Clear();
		}

        /// <summary>
        /// Randomly selected card and adds it to the hand of the player + displayed on the screen.
        /// </summary>
        public void AddCard(Card card)
        {
            Cards_Hand.Add(card);
            PictureBox theCard = new PictureBox();
            Rectangle DrawImage = new Rectangle(LARGEURCARTE * (int)card.Valeur, HAUTEURCARTE * (int)card.Type, LARGEURCARTE, HAUTEURCARTE);
            theCard.Image = CardsPictures.Clone(DrawImage, System.Drawing.Imaging.PixelFormat.DontCare);
            theCard.SetBounds(LARGEURCARTE * CardInPlayerHand, 0, LARGEURCARTE, HAUTEURCARTE);
            panel1.Controls.Add(theCard);
            ++CardInPlayerHand;
            RefreshScore();
        }

        /// <summary>
        /// Calculate each round the points and displays them on the screen.
        /// </summary>
        public int RefreshScore()
        {
			int Temp;
			int Score = 0;
            foreach (Card card in Cards_Hand)
            {
                Temp = card.Value;
                if (Temp == 11)
                {
					if (Score <= 10) Score += Temp;
					else Score += 1;
                }
				else Score += Temp;  
            }
                     
                LBL_Score.Text = messageScore + Score.ToString();
                ScoreASValue = LBL_Score.Text;
            
            return Score;
        }
    }
}