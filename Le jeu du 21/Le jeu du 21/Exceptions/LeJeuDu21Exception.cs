using System;

namespace Le_jeu_du_21.Exceptions
{
    class LeJeuDu21Exception: Exception
    {
        /// <summary>
        /// The message of an exception
        /// </summary>
        protected string message;

        /// <summary>
        /// Initializes BlackJackException with the name of a cardholder who's got some blackjack game exception (score=21 by default)
        /// </summary>
        /// <param name="msg">Message by default ("BlackJack!")</param>
        public LeJeuDu21Exception(string msg = "Le Jeu Du 21!")
        {
            message = msg;
        }
    }
}
