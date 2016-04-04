using System;
using System.Collections.Generic;

namespace Le_jeu_du_21.Model
{
	public abstract class Joueur
	{
        /// <summary>
        /// Class Variables
        /// </summary>
        public enum Risk_Level { Aucun, Standard = 40, Courageux = 50, Moyen = 65, Prudent = 80 }
        public int pointageTotal { get { return LJDUSER.RefreshScore(); } set { LJDUSER.Reset(); } }
        public bool countCards { get; set; }
        public bool AI_Player { get; set; }
        public LeJeuDu21_UserControl LJDUSER { get; set; }
        public bool GameOver { get; set; }
        public List<string> LJDUSER_Log { get; set; }
        //Risk Level of AI
        public Risk_Level riskLevel;


        /// <summary>
        /// Constructor
        /// </summary>
        public Joueur(LeJeuDu21_UserControl LJD_USER)
        {
            LJDUSER = LJD_USER;
            AI_Player = false;
            GameOver = false;
            LJDUSER_Log = new List<string>();
        }

        public Joueur(LeJeuDu21_UserControl LJD_USER, Risk_Level risk_Level, bool count_Cards)
        {
            LJDUSER = LJD_USER;
            AI_Player = true;
            risk_Level = riskLevel;
            countCards = count_Cards;
            GameOver = false;
            LJDUSER_Log = new List<string>();
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
            string message = "J'ai un score de " + LJDUSER.RefreshScore() + ". ";
            message += "Je pige si j'ai " + ((int)riskLevel).ToString() + "% de chance de ne pas dépasser, ";
            message += "il y a présentement " + NumberGoodCards.ToString() + " bonnes cartes sur " + NumberCards.ToString();
            message += ", les chances de ne pas dépasser sont évaluées à " + ((int)(ExceedingPossibility * 100)).ToString() + "%";

            if ((double)riskLevel / 100 < ExceedingPossibility)
            {
                message += ", donc je pige une carte.";
            }
            else
            {
                message += ", donc je passe mon tour.";
            }

            // Sent Message
            LJDUSER_Log.Add(message);
        }

        /// <summary>
        ///Add Message Direct to the Log
        /// </summary>
        /// <param name="message">Le Message</param>
        public void AddToLog(string message)
        {
            //Sent Message
            LJDUSER_Log.Add(message);
        }
    }
}