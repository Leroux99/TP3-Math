using System.Drawing;

namespace Le_jeu_du_21.Model
{
    public class Card
    {
        /// <summary>
        /// GET Valeur
        /// </summary>
        public int Value { get { return getValue(); } }

        /// <summary>
        /// Variables
        /// </summary>
        public TypeCarte Type;
        public TitreCarte Valeur;

        /// <summary>
        /// Enum Type Carte
        /// </summary>
        public enum TypeCarte
        {
            Trèfle, Pique, Cœur, Carreau
        }

        /// <summary>
        /// Enum Valeur Carte
        /// </summary>
        public enum TitreCarte
        {
            As, Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi
        }

        /// <summary>
        /// Construction de la Carte
        /// </summary>
        /// <param name="valeurC">Valeur de la Carte</param>
        /// /// <param name="typeC">Type de la Carte</param>
        public Card(int valeurC, int typeC)
        {
            Type = (TypeCarte)typeC;
            Valeur = (TitreCarte)valeurC;
        }

        /// <summary>
        /// Envoie la Carte
        /// </summary>
        private int getValue()
        {
            const int FACEVALUE = 10;
            const int ACEVALUE = 11;
            int result;
            switch (Valeur)
            {
                case TitreCarte.Valet:
                case TitreCarte.Dame:
                case TitreCarte.Roi:
                    result = FACEVALUE;
                    break;

                case TitreCarte.As:
                    result = ACEVALUE;
                    break;

                default:
                    result = (int)Valeur + 1;
                    break;
            }
            return result;
        }
    }
}