using System;
using System.Collections.Generic;

namespace Le_jeu_du_21.Model
{
    public class PaquetCarte
    {
        /// <summary>
        /// Member
        /// </summary>
        private static Random _randomGen;
        private int _count;
        public const int DECKOFFIFTYTWO = 52;
        private List<Card> _deck = new List<Card>(DECKOFFIFTYTWO);


        /// <summary>
        /// Build and Shuffle
        /// </summary>
        public PaquetCarte()
        {
            if (_randomGen == null)
            {
                _randomGen = new Random();
            }

            _count = -1;

            for (int i = 0; i < Enum.GetNames(typeof(Card.TitreCarte)).Length; ++i)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Card.TypeCarte)).Length; ++j)
                {
                    _deck.Add(new Card(i, j));
                }
            }
            shuffle();
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
                rand = _randomGen.Next(DECKOFFIFTYTWO);
                TempDeck = _deck[i];
                _deck[i] = _deck[rand];
                _deck[rand] = TempDeck;
            }
        }

        /// <summary>
        /// Calculate the probability
        /// </summary>
        public double Probability(int valeurANePasDepasser, bool compteLesCartes, Joueur IA)
        {
            double CalProbability;
            int nbCartesRestantes = compteLesCartes ? DECKOFFIFTYTWO - _count - 1 : DECKOFFIFTYTWO;
            int nbBonnesCartesRestantes = 0;
            if (compteLesCartes)
            {
                for (int i = _count + 1; i < DECKOFFIFTYTWO; i++)
                {
                    if ((_deck[i].Value == 11 && valeurANePasDepasser >= 1) || (_deck[i].Value <= valeurANePasDepasser))
                        nbBonnesCartesRestantes++;
                }
            }
            else
            {
                List<Card> nouveauDeck = new PaquetCarte()._deck;
                for (int i = 0; i < DECKOFFIFTYTWO; i++)
                {
                    if ((nouveauDeck[i].Value == 11 && valeurANePasDepasser >= 1) || (nouveauDeck[i].Value <= valeurANePasDepasser))
                        nbBonnesCartesRestantes++;
                }
            }

            CalProbability = (double)nbBonnesCartesRestantes / nbCartesRestantes;
            IA.AddToLog(nbBonnesCartesRestantes, CalProbability, nbCartesRestantes);

            return CalProbability;
        }
    }
}