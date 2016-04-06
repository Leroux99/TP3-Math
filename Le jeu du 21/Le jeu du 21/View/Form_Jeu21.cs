using Le_jeu_du_21.View;
using Le_jeu_du_21.Model;
using System.Windows.Forms;

namespace Le_jeu_du_21
{
    public partial class Form_Jeu21 : Form
    {
        /// <summary>
        /// Variables From Others Forms
        /// </summary>
        Joueur player1;//TODO:
        Joueur player2;//TODO:
        PaquetCarte paquetCarte;

        /// <summary>
        /// Variables For this Form
        /// </summary>
        int rounds = 0;
        const int pointingGoal = 21;
        public bool gameOver = false;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        public Form_Jeu21()
        {
            InitializeComponent();
            //----------------------------------------//
            paquetCarte = new PaquetCarte();

            if (!Start.Standard)
            {
                Form_Risque form_ris = new Form_Risque();
                form_ris.ShowDialog();

                if (form_ris.Player1 == Joueur.Risk_Level.Aucun)
                {
                    player1 = new Joueur(leJeuDu21_UserControl1);
                }
                else
                {
                    player1 = new Joueur(leJeuDu21_UserControl1, form_ris.Player1, form_ris.Player1_Playable);
                    Start.AI_1 = new Joueur(leJeuDu21_UserControl1, form_ris.Player1, form_ris.Player1_Playable);
                }

                if (form_ris.Player2 == Joueur.Risk_Level.Aucun)
                {
                    player2 = new Joueur(leJeuDu21_UserControl2);
                }
                else
                {
                    player2 = new Joueur(leJeuDu21_UserControl2, form_ris.Player2, form_ris.Player2_Playable);
                    Start.AI_2 = new Joueur(leJeuDu21_UserControl2, form_ris.Player2, form_ris.Player2_Playable);
                }
            }
            else
            {
                player1 = new Joueur(leJeuDu21_UserControl1, Start.AI_1.riskLevel, Start.AI_1.countCards);
                player2 = new Joueur(leJeuDu21_UserControl2, Start.AI_2.riskLevel, Start.AI_2.countCards);
            }
        }

        /// <summary>
        /// Start the game
        /// </summary>
        private void Jouer(object sender, System.EventArgs e)
        {
            leJeuDu21_UserControl1.AddCard(paquetCarte.drawaCard());
            GameOverForAll();
            EndOfGame();
        }

        /// <summary>
        /// AI Algorithm
        /// </summary>
        private void IA_Jouer(Joueur IA)
        {
            bool aPasser = false;
            Joueur autreJoueur = IA == player1 ? player2 : player1;

            if (autreJoueur.totalScores > pointingGoal)
            {
                aPasser = true;
                IA.AddToLog("Mon adversaire à déjà perdu, donc je passe.");
            }
            else if (autreJoueur.totalScores == pointingGoal)
            {
                IA.LJDUSER.AddCard(paquetCarte.drawaCard());
                IA.AddToLog("Mon adversaire à 21, donc je pige.");
            }
            else if (IA.totalScores <= 10 || IA.LJDUSER.HaveAS && !IA.LJDUSER.BoolASValue)
            {
                IA.LJDUSER.AddCard(paquetCarte.drawaCard());
                IA.AddToLog("J'ai un pointage de 10 et moins, donc je pige.");
            }
            else if (IA.pigeUneCarte(paquetCarte.Probability(pointingGoal - IA.totalScores, IA.countCards, IA)))
            {  
                IA.LJDUSER.AddCard(paquetCarte.drawaCard());
            }
            else
            {
                aPasser = true;
            }
            GameOverForAll();
            IA.GameOver = aPasser;
            EndOfGame();
        }

        /// <summary>
        /// To Make the AI Play Auto
        /// </summary>
        private void Auto_Click(object sender, System.EventArgs e)
        {
            Start.Standard = true;
            Form_Jeu21 Jeux21 = new Form_Jeu21();

            for (int i = 0; i < Start.numericupdownNumber; ++i)
            {
                Clone(Jeux21.player1, Start.AI_1);
                Clone(Jeux21.player2, Start.AI_2);
                IncrementNVR(i);
                Jeux21.gameOver = false;
                while (!Jeux21.gameOver)
                {
                    if (!Jeux21.gameOver)
                    {
                        Jeux21.BTN_IA1_Jouer_Click(sender, e);
                    }
                }
                Jeux21.DialogResult = DialogResult.OK;
                ++rounds;
            }
            IncrementNVR(Start.numericupdownNumber);
            MessageBox.Show("Joueur 1: " + Start.AI_1Scores.ToString() + "     Joueur 2: " + Start.AI_2Scores.ToString() + "      Tours demandés: " + rounds + "      Points Totaux: " + Start.ScoresPerRounds, "Résultats:", MessageBoxButtons.OK);
            for (int i = 0; i < Start.NVRName.Count; ++i)
            {
                MessageBox.Show("NVR: " + Start.NVRName[i] + " PTS: " + Start.Scores[i]);
            }
        }

        /// <summary>
        /// Clone Player, AI
        /// </summary>
        private void Clone(Joueur joueur, Joueur ai)
        {
            joueur.countCards = ai.countCards;
            joueur.GameOver = ai.GameOver;
            joueur.AI_Player = ai.AI_Player;
            joueur.LJDUSER_Log = ai.LJDUSER_Log;
            joueur.totalScores = ai.totalScores;
            joueur.riskLevel = Start.theName;
        }

        /// <summary>
        /// Increment NVR
        /// </summary>
        private void IncrementNVR(int i)
        {
            if (i % 1000 == 0 && i != 0)
            {
                Start.NVRName.Add(Start.theName.ToString());
                Start.Scores.Add(Start.AI_2Scores);
                Start.AI_1Scores = 0;
                Start.AI_2Scores = 0;
                ++Start.theName;
            }
        }

        /// <summary>
        /// Check if the Game is Over
        /// </summary>
        public void EndOfGame()
        {
            if (player1.totalScores >= pointingGoal)
            {
                player1.GameOver = true;
            }

            if (player2.totalScores >= pointingGoal)
            {
                player2.GameOver = true;
            }

            if (player1.GameOver && player2.GameOver)
            {
                EndOfTheGame();
            }
        }

        /// <summary>
        /// Display the winner and display the message
        /// </summary>
        public void EndOfTheGame()
        {
            gameOver = true;
            string messageDeFin = "";

            button_Arrêter.Enabled = false;
            button_Rejouer.Visible = true;

            if (player1.totalScores > pointingGoal && player2.totalScores > pointingGoal)
            {
                messageDeFin = "Les Joueurs ont tous les deux perdu, BAHOOOOO !";
            }
            else if (player1.totalScores > pointingGoal || player2.totalScores > pointingGoal)
            {
                if (player1.totalScores < player2.totalScores)
                {
                    messageDeFin = "Le Joueur 1 à gagné, YAHOOOOO !";
                    ++Start.AI_1Scores;
                    ++Start.ScoresPerRounds;
                }
                else if (player2.totalScores < player1.totalScores)
                {
                    messageDeFin = "Le Joueur 2 à gagné, YAHOOOOO !";
                    ++Start.AI_2Scores;
                    ++Start.ScoresPerRounds;
                }
            }
            else
            {
                if (player1.totalScores == player2.totalScores)
                {
                    messageDeFin = "Partie Nulle, BAHOOOOO !";
                }
                else if (player1.totalScores > player2.totalScores)
                {
                    messageDeFin = "Le Joueur 1 à gagné, YAHOOOOO !";
                    ++Start.AI_1Scores;
                    ++Start.ScoresPerRounds;
                }
                else
                {
                    messageDeFin = "Le Joueur 2 à gagné, YAHOOOOO !";
                    ++Start.AI_2Scores;
                    ++Start.ScoresPerRounds;
                }
            }
            if (!Start.Standard) MessageBox.Show(messageDeFin);
        }

        /// <summary>
        /// Show The log For the current player.
        /// </summary>
        private void ShowTextInTextBox(object sender, System.EventArgs e)
        {
            textBox_GameLog.Text = "Au tour du joueur " + Start.theName.ToString() + " de jouer. Vous avez " + LeJeuDu21_UserControl.ScoreASValue.ToString() + " points.";

            textBox_GameLog.TextAlign = HorizontalAlignment.Center;
            Refresh();
        }

        /// <summary>
        /// Keep Control Enable/Disable
        /// </summary>
        private void GameOverForAll()
        {
            if (!player1.GameOver && !player2.GameOver)
            {
                //TODO:
            }
        }

        /// <summary>
        /// BTN JOUER
        /// </summary>
        private void BTN_IA1_Jouer_Click(object sender, System.EventArgs e)
        {
            IA_Jouer(player1);
        }

        /// <summary>
        /// BTN PASSER
        /// </summary>
        private void Passer(object sender, System.EventArgs e)
        {
            GameOverForAll();
            player1.GameOver = true;
            EndOfGame();
        }

        /// <summary>
        /// JOURNAL AI1
        /// </summary>
        private void BTN_IA1_Journal_Click(object sender, System.EventArgs e)
        {
            new Form_Log(player1.LJDUSER_Log).ShowDialog();
        }

        /// <summary>
        /// JOURNAL AI2
        /// </summary>
        private void BTN_IA2_Journal_Click(object sender, System.EventArgs e)
        {
            new Form_Log(player2.LJDUSER_Log).ShowDialog();
        }

        /// <summary>
        /// BTN REJOUER
        /// </summary>
        private void button_Rejouer_Click(object sender, System.EventArgs e)
        {
            // Hide main form
            Hide();

            // Show other form
            Form_Adversaire frm = new Form_Adversaire();
            frm.ShowDialog();

            // Close application
            Close();
        }

        /// <summary>
        /// BTN ARRETER LA PARTIE
        /// </summary>
        private void button_Arrêter_Click(object sender, System.EventArgs e)
        {
            EndOfTheGame();
        }

        /// <summary>
        /// TOOLSTRIP QUITTER
        /// </summary>
        private void quitterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}