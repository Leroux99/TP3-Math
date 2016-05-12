using System;
using System.Windows.Forms;

namespace PFI3
{
	public partial class Form1 : Form
	{
		Random random;
		double Total_Pts = 10000;
		double Y_Min = 0;
		double Y_Max;
		double X_Min, X_Max;
		double toDouble = 100000;
		public Form1()
		{
			InitializeComponent();
			comboBox_Fonction.SelectedIndex = 0;
			numericUpDown_A.Maximum = numericUpDown_B.Maximum - Convert.ToDecimal(0.01);
			random = new Random();
		}

		private void buttonCalculer_Click(object sender, EventArgs e)
		{
			if (numericUpDown_A.Value > numericUpDown_B.Value)
				MessageBox.Show("La valeur de la variable a ne peut être supérieure à celle de la variable b.");
			else
			{
				X_Min = Convert.ToDouble(numericUpDown_A.Value);
				X_Max = Convert.ToDouble(numericUpDown_B.Value);
				TrouverFonction();
			}
		}

		private void TrouverFonction()
		{
			if (comboBox_Fonction.SelectedIndex == 0) Fonction1();
			else if (comboBox_Fonction.SelectedIndex == 1) Fonction2();
			else if (comboBox_Fonction.SelectedIndex == 2) Fonction3();
			else if (comboBox_Fonction.SelectedIndex == 3) Fonction4();
			else if (comboBox_Fonction.SelectedIndex == 4) Fonction5();

		}

		private void Fonction1()
		{
			Y_Max = 5;
			double Nbr_Points = 0;
			for (int i = 1; i <= Total_Pts; ++i)
			{
				double rand_x = random.Next(Convert.ToInt32(X_Min * toDouble), Convert.ToInt32(X_Max * toDouble) + 1);
				rand_x = rand_x / toDouble;
				double rand_y = random.Next(Convert.ToInt32(Y_Min * toDouble), Convert.ToInt32(Y_Max * toDouble) + 1);
				rand_y = rand_y / toDouble;
				//(x^2 - 16x + 63)^1/3 + 4
				double formule_y = Math.Pow((Math.Pow(rand_x, (double)2) - (double)16 * rand_x + (double)63), (double)1 / (double)3) + (double)4;

				if (rand_y <= formule_y) Nbr_Points++;
			}

			double p = Nbr_Points / Total_Pts;
			double ME = 1.96 * Math.Sqrt(p * (1 - p) / Total_Pts);
			double Aire = (X_Max - X_Min) * Y_Max * p;
			double ME_Aire = ME * Aire;

			textBox_Pi.Text = p.ToString("0.0000");
			textBox_IC.Text = (p * 100).ToString("0.00") + "% +/- " + (ME * 100).ToString("0.00") + "%";
			textBox_ME.Text = (ME * 100).ToString("0.00");
			textBox_Aire.Text = Aire.ToString("0.0000") + " +/- " + ME_Aire.ToString("0.0000");

		}

		private void Fonction2()
		{
			Y_Max = 5;
			double Nbr_Points = 0;
			for (int i = 1; i <= Total_Pts; ++i)
			{
				double rand_x = random.Next(Convert.ToInt32(X_Min * toDouble), Convert.ToInt32(X_Max * toDouble) + 1);
				rand_x = rand_x / toDouble;
				double rand_y = random.Next(Convert.ToInt32(Y_Min * toDouble), Convert.ToInt32(Y_Max * toDouble) + 1);
				rand_y = rand_y / toDouble;
				//3((x-7)/5)^5-5((x-7)/5)^3 + 3
				double formule_y = (double)3 * Math.Pow(((rand_x - (double)7) / (double)5), (double)5) - (double)5 * Math.Pow(((rand_x - (double)7) / (double)5), (double)3) + (double)3;

				if (rand_y <= formule_y) Nbr_Points++;
			}

			double p = Nbr_Points / Total_Pts;
			double ME = 1.96 * Math.Sqrt(p * (1 - p) / Total_Pts);
			double Aire = (X_Max - X_Min) * Y_Max * p;
			double ME_Aire = ME * Aire;

			textBox_Pi.Text = p.ToString("0.0000");
			textBox_IC.Text = (p * 100).ToString("0.00") + "% +/- " + (ME * 100).ToString("0.00") + "%";
			textBox_ME.Text = (ME * 100).ToString("0.00");
			textBox_Aire.Text = Aire.ToString("0.0000") + " +/- " + ME_Aire.ToString("0.0000");
		}

		private void Fonction3()
		{
			Y_Max = 12;
			double Nbr_Points = 0;
			for (int i = 1; i <= Total_Pts; ++i)
			{
				double rand_x = random.Next(Convert.ToInt32(X_Min * toDouble), Convert.ToInt32(X_Max * toDouble) + 1);
				rand_x = rand_x / toDouble;
				double rand_y = random.Next(Convert.ToInt32(Y_Min * toDouble), Convert.ToInt32(Y_Max * toDouble) + 1);
				rand_y = rand_y / toDouble;
				//-1/3(x-6)^2 + 12
				double formule_y = (double)-1 / (double)3 * Math.Pow(rand_x - (double)6, (double)2) + (double)12;

				if (rand_y <= formule_y) Nbr_Points++;
			}

			double p = Nbr_Points / Total_Pts;
			double ME = 1.96 * Math.Sqrt(p * (1 - p) / Total_Pts);
			double Aire = (X_Max - X_Min) * Y_Max * p;
			double ME_Aire = ME * Aire;

			textBox_Pi.Text = p.ToString("0.0000");
			textBox_IC.Text = (p * 100).ToString("0.00") + "% +/- " + (ME * 100).ToString("0.00") + "%";
			textBox_ME.Text = (ME * 100).ToString("0.00");
			textBox_Aire.Text = Aire.ToString("0.0000") + " +/- " + ME_Aire.ToString("0.0000");
		}

		private void Fonction4()
		{
			Y_Max = 10;
			double Nbr_Points = 0;
			for (int i = 1; i <= Total_Pts; ++i)
			{
				double rand_x = random.Next(Convert.ToInt32(X_Min * toDouble), Convert.ToInt32(X_Max * toDouble) + 1);
				rand_x = rand_x / toDouble;
				double rand_y = random.Next(Convert.ToInt32(Y_Min * toDouble), Convert.ToInt32(Y_Max * toDouble) + 1);
				rand_y = rand_y / toDouble;
				//x + sin(x)
				double formule_y = rand_x + Math.Sin(rand_x);

				if (rand_y <= formule_y) Nbr_Points++;
			}

			double p = Nbr_Points / Total_Pts;
			double ME = 1.96 * Math.Sqrt(p * (1 - p) / Total_Pts);
			double Aire = (X_Max - X_Min) * Y_Max * p;
			double ME_Aire = ME * Aire;

			textBox_Pi.Text = p.ToString("0.0000");
			textBox_IC.Text = (p * 100).ToString("0.00") + "% +/- " + (ME * 100).ToString("0.00") + "%";
			textBox_ME.Text = (ME * 100).ToString("0.00");
			textBox_Aire.Text = Aire.ToString("0.0000") + " +/- " + ME_Aire.ToString("0.0000");
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			numericUpDown_A.Value = numericUpDown_A.Minimum;
			numericUpDown_B.Value = numericUpDown_B.Minimum;
			comboBox_Fonction.SelectedIndex = 0;
			textBox_Pi.Text = "";
			textBox_IC.Text = "";
			textBox_ME.Text = "";
			textBox_Aire.Text = "";
		}

		private void Fonction5()
		{
			Y_Max = 4;
			double Nbr_Points = 0;
			for(int i = 1; i <= Total_Pts; ++i)
			{
				double rand_x = random.Next(Convert.ToInt32(X_Min * toDouble),Convert.ToInt32( X_Max * toDouble) + 1);
				rand_x = rand_x / toDouble;
				double rand_y = random.Next(Convert.ToInt32(Y_Min * toDouble), Convert.ToInt32(Y_Max * toDouble) + 1);
				rand_y = rand_y / toDouble;
				//cos(x) + 3
				double formule_y = Math.Cos(rand_x) + (double)3;

				if (rand_y <= formule_y) Nbr_Points++;
			}

			double p = Nbr_Points / Total_Pts;
			double ME = 1.96 * Math.Sqrt(p * (1 - p) / Total_Pts);
			double Aire = (X_Max - X_Min) * Y_Max * p;
			double ME_Aire = ME * Aire;

			textBox_Pi.Text = p.ToString("0.0000");
			textBox_IC.Text = (p * 100).ToString("0.00") + "% +/- " + (ME * 100).ToString("0.00") + "%";
			textBox_ME.Text = (ME * 100).ToString("0.00");	
			textBox_Aire.Text = Aire.ToString("0.0000") + " +/- " + ME_Aire.ToString("0.0000");
		}

		private void DotToComma(object sender, KeyPressEventArgs e) //Event qui change un point pour une virgule
		{
			if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
			{
				e.KeyChar = (System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
			}
		}

		//fonction qui surligne tout le texte d'un numericupdown lorsque l'utilisateur l'atteint avec TAB
		private void SelectAllTextWithTab(object sender, EventArgs e)
		{
			NumericUpDown curBox = sender as NumericUpDown;
			curBox.Select();
			curBox.Select(0, curBox.Text.Length);
		}

		//fonction qui surligne tout le texte d'un numericupdown lorsque l'utilisateur double clique sur le controle
		private void SelectAllTextWithMouse(object sender, EventArgs e)
		{
			NumericUpDown curBox = sender as NumericUpDown;
			curBox.Select(0, curBox.Text.Length);
		}


	}
}
