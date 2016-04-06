﻿using System;
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
        /// Bool AS 1 OR 11
        /// </summary>
        public bool BoolASValue { get; private set; }

        /// <summary>
        /// Send Score to Form_Jeu21
        /// </summary>
        public static string ScoreASValue { get; private set; }

        /// <summary>
        /// IF Player have a AS TO DO...
        /// </summary>
        public bool HaveAS
        {
            get
            {
                bool result = false;
                foreach (Card card in Cards_Hand)
                {
                    result |= card.Value == 11;
                }
                return result;
            }
        }

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
                BoolASValue = false;
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
            int scorePlayer1, scorePlayer2; int Temp; int numberOfAs = 0; int result = 0; int total = 0; const int ASSCORE = 10;
            foreach (Card card in Cards_Hand)
            {
                Temp = card.Value;
                if (Temp == 11)
                {
                    ++numberOfAs;
                }
                total += Temp;
            }
            if (numberOfAs > 0)
            {
                scorePlayer1 = (total - (numberOfAs * ASSCORE));
                scorePlayer2 = total;
                LBL_Score.Text = messageScore + scorePlayer1.ToString() + " ou " + scorePlayer2.ToString();

                if (scorePlayer1 > 21 && scorePlayer2 > 21)
                {
                    result = scorePlayer1 < scorePlayer2 ? scorePlayer1 : scorePlayer2;
                }
                else if (scorePlayer1 <= 21 && scorePlayer2 > 21)
                {
                    result = scorePlayer1;
                    BoolASValue = true;
                }
                else result = scorePlayer2;
            }
            else
            {
                result = total;
                LBL_Score.Text = messageScore + total.ToString();
                ScoreASValue = LBL_Score.Text;
            }
            return result;
        }
    }
}