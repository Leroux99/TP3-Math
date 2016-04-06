using System;
using System.Collections.Generic;

namespace Le_jeu_du_21.Model
{
    public class PaquetCarte
    {
        /// <summary>
        /// Variables
        /// </summary>
        private List<Card> theDeck = new List<Card>(DECKOFFIFTYTWO);
        private static Random randomG;
        public const int DECKOFFIFTYTWO = 52;
        private int calculate;

        /// <summary>
        /// Build and Shuffle
        /// </summary>
        public PaquetCarte()
        {
            if (randomG == null)
            {
                randomG = new Random();
            }

            calculate = -1;

            for (int i = 0; i < Enum.GetNames(typeof(Card.TitreCarte)).Length; ++i)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Card.TypeCarte)).Length; ++j)
                {
                    theDeck.Add(new Card(i, j));
                }
            }
            shuffle();
        }

        /// <summary>
        /// Send next Card
        /// </summary>
        public Card drawaCard()
        {
            calculate %= DECKOFFIFTYTWO;
            ++calculate;
            return theDeck[calculate];
        }

        /// <summary>
        /// Shuffle Card and Place Into The Deck.
        /// </summary>
        private void shuffle()
        {
            Card TempDeck;
            int rand = 0;

            for (int i = 0; i < DECKOFFIFTYTWO; ++i)
            {
                rand = randomG.Next(DECKOFFIFTYTWO);
                TempDeck = theDeck[i];
                theDeck[i] = theDeck[rand];
                theDeck[rand] = TempDeck;
            }
        }

        /// <summary>
        /// Calculate the probability
        /// </summary>
        public double Probability(int valeurANePasDepasser, bool compteLesCartes, Joueur IA)
        {
            double CalProbability;
            int nbCartesRestantes = compteLesCartes ? DECKOFFIFTYTWO - calculate - 1 : DECKOFFIFTYTWO;
            int nbBonnesCartesRestantes = 0;
            if (compteLesCartes)
            {
                for (int i = calculate + 1; i < DECKOFFIFTYTWO; ++i)
                {
                    if ((theDeck[i].Value == 11 && valeurANePasDepasser >= 1) || (theDeck[i].Value <= valeurANePasDepasser))
                    {
                        ++nbBonnesCartesRestantes;
                    }
                }
            }
            else
            {
                List<Card> nouveauDeck = new PaquetCarte().theDeck;
                for (int i = 0; i < DECKOFFIFTYTWO; ++i)
                {
                    if ((nouveauDeck[i].Value == 11 && valeurANePasDepasser >= 1) || (nouveauDeck[i].Value <= valeurANePasDepasser))
                    {
                        ++nbBonnesCartesRestantes;
                    }
                }
            }
            CalProbability = (double)nbBonnesCartesRestantes / nbCartesRestantes;
            IA.AddToLog(nbBonnesCartesRestantes, CalProbability, nbCartesRestantes);
            return CalProbability;
        }
    }
}