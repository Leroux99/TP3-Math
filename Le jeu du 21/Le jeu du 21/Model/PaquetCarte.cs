using Le_jeu_du_21.Exceptions;

namespace Le_jeu_du_21.Model
{
	public class PaquetCarte
    {

        protected string name;
        protected SetCarte hand = new SetCarte();


        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="nm">The name of a card holder</param>
        public PaquetCarte(string nm = "Unknown")
        {
            name = nm;
        }

        /// <summary>
        /// Name property
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Hand property
        /// </summary>
        public SetCarte PlayerHand
        {
            get { return hand; }
            set { hand = value; }
        }



        /// <summary>
        /// Method for taking new card and adding to card holder's hand
        /// </summary>
        /// <param name="card">The card received by card holder</param>
        public void TakeCard(Card card)
        {
            hand.AddCard(card);
        }


        /// <summary>
        /// Method clears the card holder's hand
        /// </summary>
        public void ClearHand()
        {
            hand.Clear();
        }
    }
}
