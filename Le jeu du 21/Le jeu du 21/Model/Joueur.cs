﻿using System.Collections.Generic;

namespace Le_jeu_du_21.Model
{
    public class Joueur
    {
        /// <summary>
        /// Class Variables
        /// </summary>
        public enum Risk_Level { Aucun, Standard = 40, Courageux = 50, Moyen = 65, Prudent = 80 }
        public LeJeuDu21_UserControl LJDUSER { get; set; }
        public int totalScores { get { return LJDUSER.RefreshScore(); } set { LJDUSER.Reset(); } }
        public bool countCards { get; set; }
        public bool AI_Player { get; set; }
        public bool GameOver { get; set; }
		public int NumeroJoueur { get; set; }
        /// <summary>
        /// Risk Level of AI
        /// </summary>
        public Risk_Level riskLevel;

        /// <summary>
        /// Constructor
        /// </summary>
        public Joueur()
        {
            AI_Player = false;
            GameOver = false;
        }

        /// <summary>
        /// Constructor with Risk and Card Number
        /// </summary>
        public Joueur(Risk_Level risk_Level, bool count_Cards)
        {
            riskLevel = risk_Level;
            countCards = count_Cards;
            AI_Player = true;
            GameOver = false;
        }

		public void setUserControl(LeJeuDu21_UserControl LJD_USER)
		{
			LJDUSER = LJD_USER;
		}

        /// <summary>
        /// AI Want Pick A Card ?!
        /// </summary>
        /// <param name="ExceedingPossibility">Valeur possible de dépasser</param>
        public bool pigeUneCarte(double ExceedingPossibility)
        {
            return ExceedingPossibility >= ((double)riskLevel / 100.0);
        }

        /// <summary>
        ///Writes a message for the AI
        /// </summary>
        /// <param name="NumberCards">Valeur des Cartes</param>
        /// /// <param name="NumberGoodCards">Nombre de bonnes cartes</param>
        /// /// <param name="ExceedingPossibility">Valeur possible de dépasser</param>
        public void AddToLog(int NumberGoodCards, double ExceedingPossibility, int NumberCards)
        {
            string message = "Mon score est de " + LJDUSER.RefreshScore() + ". ";
            message += "Je pige seulement si j'ai " + ((int)riskLevel).ToString() + "% de chance de ne pas dépasser, ";
            message += "il y a " + NumberGoodCards.ToString() + " bonnes cartes sur " + NumberCards.ToString();
            message += ", les chances de ne pas dépasser sont estimées à " + ((int)(ExceedingPossibility * 100)).ToString() + "%";

            if ((double)riskLevel / 100 < ExceedingPossibility)
            {
                message += ", donc je pige.";
            }
            else
            {
                message += ", donc je passe.";
            }
            Jeu.Log.Add("Joueur " + NumeroJoueur + ": " + message);
        }

        /// <summary>
        ///Add Message Direct to the Log
        /// </summary>
        /// <param name="message">Le Message</param>
        public void AddToLog(string message)
        {
            Jeu.Log.Add("Joueur " + NumeroJoueur + ": " + message);
        }

		public void NewGame()
		{
			totalScores = 0;
			GameOver = false;
		}
    }
}