﻿using System;
using System.Windows.Forms;

namespace Le_jeu_du_21
{
    static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form_Adversaire());
		}
	}
}
