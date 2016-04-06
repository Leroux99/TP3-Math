using System;
using Le_jeu_du_21.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Le_jeu_du_21.View
{
    public partial class Start : Form
    {
        /// <summary>
        /// Variables
        /// </summary>
        public static Joueur AI_1;
        public static Joueur AI_2;
        public static List<int> Scores = new List<int>();
        public static List<string> NVRName = new List<string>();
        public static Joueur.Risk_Level theName = Joueur.Risk_Level.Standard;
        public static bool Standard = false;
        public static int AI_1Scores = 0;
        public static int AI_2Scores = 0;
        public static int ScoresPerRounds = 0;
        public static int numericupdownNumber = 10000;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        public Start()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Make Many Rounds
        /// </summary>
        private void Demarrage_Load(object sender, EventArgs e)
        {
            while (new Form_Jeu21().ShowDialog() == DialogResult.OK) ;
            Close();
        }
    }
}