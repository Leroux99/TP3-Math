namespace Le_jeu_du_21
{
    partial class Form_Risque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Risque));
			this.groupBox_Joueur1 = new System.Windows.Forms.GroupBox();
			this.radioButton3_Prudent = new System.Windows.Forms.RadioButton();
			this.radioButton2_Moyen = new System.Windows.Forms.RadioButton();
			this.radioButton1_Courageux = new System.Windows.Forms.RadioButton();
			this.radioButton1_2_Courageux = new System.Windows.Forms.RadioButton();
			this.radioButton2_2_Moyen = new System.Windows.Forms.RadioButton();
			this.radioButton3_3_Prudent = new System.Windows.Forms.RadioButton();
			this.groupBox_Joueur2 = new System.Windows.Forms.GroupBox();
			this.button_Annuler = new System.Windows.Forms.Button();
			this.button_Commencer = new System.Windows.Forms.Button();
			this.checkBox_Comptage = new System.Windows.Forms.CheckBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox_Option = new System.Windows.Forms.GroupBox();
			this.groupBox_Joueur1.SuspendLayout();
			this.groupBox_Joueur2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox_Option.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_Joueur1
			// 
			this.groupBox_Joueur1.BackColor = System.Drawing.Color.FloralWhite;
			this.groupBox_Joueur1.Controls.Add(this.radioButton3_Prudent);
			this.groupBox_Joueur1.Controls.Add(this.radioButton2_Moyen);
			this.groupBox_Joueur1.Controls.Add(this.radioButton1_Courageux);
			this.groupBox_Joueur1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox_Joueur1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Joueur1.Location = new System.Drawing.Point(12, 12);
			this.groupBox_Joueur1.Name = "groupBox_Joueur1";
			this.groupBox_Joueur1.Size = new System.Drawing.Size(217, 141);
			this.groupBox_Joueur1.TabIndex = 0;
			this.groupBox_Joueur1.TabStop = false;
			this.groupBox_Joueur1.Text = "Joueur 1";
			// 
			// radioButton3_Prudent
			// 
			this.radioButton3_Prudent.AutoSize = true;
			this.radioButton3_Prudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3_Prudent.Location = new System.Drawing.Point(50, 80);
			this.radioButton3_Prudent.Name = "radioButton3_Prudent";
			this.radioButton3_Prudent.Size = new System.Drawing.Size(90, 25);
			this.radioButton3_Prudent.TabIndex = 2;
			this.radioButton3_Prudent.Tag = "80";
			this.radioButton3_Prudent.Text = "Prudent";
			this.radioButton3_Prudent.UseVisualStyleBackColor = true;
			this.radioButton3_Prudent.CheckedChanged += new System.EventHandler(this.Joueur1_Check_Changed);
			// 
			// radioButton2_Moyen
			// 
			this.radioButton2_Moyen.AutoSize = true;
			this.radioButton2_Moyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2_Moyen.Location = new System.Drawing.Point(50, 57);
			this.radioButton2_Moyen.Name = "radioButton2_Moyen";
			this.radioButton2_Moyen.Size = new System.Drawing.Size(81, 25);
			this.radioButton2_Moyen.TabIndex = 1;
			this.radioButton2_Moyen.Tag = "70";
			this.radioButton2_Moyen.Text = "Moyen";
			this.radioButton2_Moyen.UseVisualStyleBackColor = true;
			this.radioButton2_Moyen.CheckedChanged += new System.EventHandler(this.Joueur1_Check_Changed);
			// 
			// radioButton1_Courageux
			// 
			this.radioButton1_Courageux.AutoSize = true;
			this.radioButton1_Courageux.Checked = true;
			this.radioButton1_Courageux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1_Courageux.Location = new System.Drawing.Point(50, 34);
			this.radioButton1_Courageux.Name = "radioButton1_Courageux";
			this.radioButton1_Courageux.Size = new System.Drawing.Size(112, 25);
			this.radioButton1_Courageux.TabIndex = 0;
			this.radioButton1_Courageux.TabStop = true;
			this.radioButton1_Courageux.Tag = "50";
			this.radioButton1_Courageux.Text = "Courageux";
			this.radioButton1_Courageux.UseVisualStyleBackColor = true;
			this.radioButton1_Courageux.CheckedChanged += new System.EventHandler(this.Joueur1_Check_Changed);
			// 
			// radioButton1_2_Courageux
			// 
			this.radioButton1_2_Courageux.AutoSize = true;
			this.radioButton1_2_Courageux.Checked = true;
			this.radioButton1_2_Courageux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1_2_Courageux.Location = new System.Drawing.Point(36, 34);
			this.radioButton1_2_Courageux.Name = "radioButton1_2_Courageux";
			this.radioButton1_2_Courageux.Size = new System.Drawing.Size(112, 25);
			this.radioButton1_2_Courageux.TabIndex = 3;
			this.radioButton1_2_Courageux.TabStop = true;
			this.radioButton1_2_Courageux.Tag = "50";
			this.radioButton1_2_Courageux.Text = "Courageux";
			this.radioButton1_2_Courageux.UseVisualStyleBackColor = true;
			this.radioButton1_2_Courageux.CheckedChanged += new System.EventHandler(this.Joueur2_Check_Changed);
			// 
			// radioButton2_2_Moyen
			// 
			this.radioButton2_2_Moyen.AutoSize = true;
			this.radioButton2_2_Moyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2_2_Moyen.Location = new System.Drawing.Point(36, 57);
			this.radioButton2_2_Moyen.Name = "radioButton2_2_Moyen";
			this.radioButton2_2_Moyen.Size = new System.Drawing.Size(81, 25);
			this.radioButton2_2_Moyen.TabIndex = 4;
			this.radioButton2_2_Moyen.Tag = "70";
			this.radioButton2_2_Moyen.Text = "Moyen";
			this.radioButton2_2_Moyen.UseVisualStyleBackColor = true;
			this.radioButton2_2_Moyen.CheckedChanged += new System.EventHandler(this.Joueur2_Check_Changed);
			// 
			// radioButton3_3_Prudent
			// 
			this.radioButton3_3_Prudent.AutoSize = true;
			this.radioButton3_3_Prudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3_3_Prudent.Location = new System.Drawing.Point(36, 80);
			this.radioButton3_3_Prudent.Name = "radioButton3_3_Prudent";
			this.radioButton3_3_Prudent.Size = new System.Drawing.Size(90, 25);
			this.radioButton3_3_Prudent.TabIndex = 5;
			this.radioButton3_3_Prudent.Tag = "80";
			this.radioButton3_3_Prudent.Text = "Prudent";
			this.radioButton3_3_Prudent.UseVisualStyleBackColor = true;
			this.radioButton3_3_Prudent.CheckedChanged += new System.EventHandler(this.Joueur2_Check_Changed);
			// 
			// groupBox_Joueur2
			// 
			this.groupBox_Joueur2.BackColor = System.Drawing.Color.FloralWhite;
			this.groupBox_Joueur2.Controls.Add(this.radioButton1_2_Courageux);
			this.groupBox_Joueur2.Controls.Add(this.radioButton2_2_Moyen);
			this.groupBox_Joueur2.Controls.Add(this.radioButton3_3_Prudent);
			this.groupBox_Joueur2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox_Joueur2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Joueur2.Location = new System.Drawing.Point(338, 12);
			this.groupBox_Joueur2.Name = "groupBox_Joueur2";
			this.groupBox_Joueur2.Size = new System.Drawing.Size(220, 141);
			this.groupBox_Joueur2.TabIndex = 1;
			this.groupBox_Joueur2.TabStop = false;
			this.groupBox_Joueur2.Text = "Joueur 2";
			// 
			// button_Annuler
			// 
			this.button_Annuler.BackColor = System.Drawing.SystemColors.Control;
			this.button_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Annuler.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Annuler.ForeColor = System.Drawing.Color.Black;
			this.button_Annuler.Location = new System.Drawing.Point(431, 281);
			this.button_Annuler.Name = "button_Annuler";
			this.button_Annuler.Size = new System.Drawing.Size(127, 45);
			this.button_Annuler.TabIndex = 4;
			this.button_Annuler.Text = "Annuler";
			this.button_Annuler.UseVisualStyleBackColor = false;
			this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
			// 
			// button_Commencer
			// 
			this.button_Commencer.BackColor = System.Drawing.SystemColors.Control;
			this.button_Commencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Commencer.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Commencer.ForeColor = System.Drawing.Color.Black;
			this.button_Commencer.Location = new System.Drawing.Point(298, 281);
			this.button_Commencer.Name = "button_Commencer";
			this.button_Commencer.Size = new System.Drawing.Size(127, 45);
			this.button_Commencer.TabIndex = 3;
			this.button_Commencer.Text = "Commencer";
			this.button_Commencer.UseVisualStyleBackColor = false;
			this.button_Commencer.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// checkBox_Comptage
			// 
			this.checkBox_Comptage.AutoSize = true;
			this.checkBox_Comptage.BackColor = System.Drawing.Color.Transparent;
			this.checkBox_Comptage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox_Comptage.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Comptage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.checkBox_Comptage.Location = new System.Drawing.Point(6, 49);
			this.checkBox_Comptage.Name = "checkBox_Comptage";
			this.checkBox_Comptage.Size = new System.Drawing.Size(181, 25);
			this.checkBox_Comptage.TabIndex = 2;
			this.checkBox_Comptage.Text = "Comptage de cartes";
			this.checkBox_Comptage.UseVisualStyleBackColor = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.SystemColors.Control;
			this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.numericUpDown1.Location = new System.Drawing.Point(3, 95);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(128, 29);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox_Option
			// 
			this.groupBox_Option.BackColor = System.Drawing.Color.FloralWhite;
			this.groupBox_Option.Controls.Add(this.checkBox_Comptage);
			this.groupBox_Option.Controls.Add(this.numericUpDown1);
			this.groupBox_Option.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Option.Location = new System.Drawing.Point(12, 185);
			this.groupBox_Option.Name = "groupBox_Option";
			this.groupBox_Option.Size = new System.Drawing.Size(217, 141);
			this.groupBox_Option.TabIndex = 2;
			this.groupBox_Option.TabStop = false;
			this.groupBox_Option.Text = "Comptage && Partie Lancé";
			// 
			// Form_Risque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::Le_jeu_du_21.Properties.Resources.wall;
			this.ClientSize = new System.Drawing.Size(570, 337);
			this.Controls.Add(this.groupBox_Option);
			this.Controls.Add(this.button_Commencer);
			this.Controls.Add(this.button_Annuler);
			this.Controls.Add(this.groupBox_Joueur2);
			this.Controls.Add(this.groupBox_Joueur1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form_Risque";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Niveau de Risque";
			this.groupBox_Joueur1.ResumeLayout(false);
			this.groupBox_Joueur1.PerformLayout();
			this.groupBox_Joueur2.ResumeLayout(false);
			this.groupBox_Joueur2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox_Option.ResumeLayout(false);
			this.groupBox_Option.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Joueur1;
        private System.Windows.Forms.RadioButton radioButton3_Prudent;
        private System.Windows.Forms.RadioButton radioButton2_Moyen;
        private System.Windows.Forms.RadioButton radioButton1_Courageux;
        private System.Windows.Forms.RadioButton radioButton1_2_Courageux;
        private System.Windows.Forms.RadioButton radioButton2_2_Moyen;
        private System.Windows.Forms.RadioButton radioButton3_3_Prudent;
        public System.Windows.Forms.GroupBox groupBox_Joueur2;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.Button button_Commencer;
        private System.Windows.Forms.CheckBox checkBox_Comptage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox_Option;
    }
}