namespace Le_jeu_du_21.Model
{
    /// <summary>
    /// Deck class
    /// </summary>
    class Paquet
    {
         /// <summary>
        /// The number of cards in each deck is 52 by default (from 2♥ to A♠)
        /// </summary>
        public const byte DECK_SIZE = 52;

        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Paquet()
        {
            UnpackNew();
        }

        
        /// <summary>
        /// Method fills a deck with cards sequentially from 2♥ to A♠
        /// </summary>
	    public void UnpackNew()
        {
    
            for (byte i = 0; i < DECK_SIZE; i++)
            {
                // for testing blackjacks (only Q,K and A are generated)
                //card.setNumber((byte)(r.Next() % 3 + 49) );

            }
        }


        /// <summary>
        /// Method shuffles new deck
        /// </summary>
	    public void Shuffle( int nDeck )
        {
            UnpackNew();
        }
    }
}
