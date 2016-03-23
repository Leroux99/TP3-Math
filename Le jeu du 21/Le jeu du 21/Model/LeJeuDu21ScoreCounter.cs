namespace Le_jeu_du_21.Model
{
    /// <summary>
    /// Class for counting the total score in a cardset
    /// </summary>
    public class LeJeuDu21ScoreCounter
    {
        /// <summary>
        /// Main method counts the total score
        /// </summary>
        /// <param name="hand">The set of cards for which the score is calculated</param>
        /// <returns>Total score in the cardset</returns>
        public byte CountScore(PaquetCarte hand)
        {
            byte score = 0;

            byte aces = 0;

            while (score > 21 && aces > 0)
            {
                score -= 10;
                aces--;
            }

            return score;
        }
    }
}
