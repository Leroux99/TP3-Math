using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Le_jeu_du_21.View
{
    public partial class Form_Log : Form
    {
        /// <summary>
        /// Ne peux Dépasser 23
        /// </summary>
        private const int distance = 23;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        ///  /// <param name="Actions">Passé les actions au Log</param>
        public Form_Log(List<string> Actions)
        {
            InitializeComponent();
            int count = 0;

            foreach (string Line in Actions)
            {
                count++;
                Label label = new Label();
                label.AutoSize = true;
                label.Text = count.ToString();
                label.Location = new Point(distance, distance * count);
                Controls.Add(label);

                Label textLabel = new Label();
                textLabel.AutoSize = true;
                textLabel.Text = Line;
                textLabel.Location = new Point(distance + distance, distance * count);
                Controls.Add(textLabel);
            }
        }
    }
}