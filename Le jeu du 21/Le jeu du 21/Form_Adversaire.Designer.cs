﻿namespace Le_jeu_du_21
{
	partial class Form_Adversaire
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Adversaire));
            this.button_ContreAI = new System.Windows.Forms.Button();
            this.button_ContreHuman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ContreAI
            // 
            this.button_ContreAI.BackColor = System.Drawing.SystemColors.Control;
            this.button_ContreAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ContreAI.Location = new System.Drawing.Point(671, 125);
            this.button_ContreAI.Name = "button_ContreAI";
            this.button_ContreAI.Size = new System.Drawing.Size(270, 65);
            this.button_ContreAI.TabIndex = 0;
            this.button_ContreAI.Text = "IA VS IA";
            this.button_ContreAI.UseVisualStyleBackColor = false;
            this.button_ContreAI.Click += new System.EventHandler(this.button_ContreAI_Click);
            // 
            // button_ContreHuman
            // 
            this.button_ContreHuman.BackColor = System.Drawing.SystemColors.Control;
            this.button_ContreHuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ContreHuman.Location = new System.Drawing.Point(395, 125);
            this.button_ContreHuman.Name = "button_ContreHuman";
            this.button_ContreHuman.Size = new System.Drawing.Size(270, 65);
            this.button_ContreHuman.TabIndex = 1;
            this.button_ContreHuman.Text = "Humain VS IA";
            this.button_ContreHuman.UseVisualStyleBackColor = false;
            this.button_ContreHuman.Click += new System.EventHandler(this.button_ContreHuman_Click);
            // 
            // Form_Adversaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Le_jeu_du_21.Properties.Resources.wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.button_ContreHuman);
            this.Controls.Add(this.button_ContreAI);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Adversaire";
            this.Text = "Black Jack";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button button_ContreAI;
        private System.Windows.Forms.Button button_ContreHuman;
    }
}

