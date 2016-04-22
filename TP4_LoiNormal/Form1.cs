using System;
using System.Windows.Forms;

namespace TP4_LoiNormal
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Réinitialiser_Click(object sender, EventArgs e)
        {
            textBox_Min.Text = "";
            textBox_Max.Text = "";
            textBox_Moy.Text = "";
            textBox_ET.Text = "";
            textBox_Prob.Text = "";
        }
    }
}