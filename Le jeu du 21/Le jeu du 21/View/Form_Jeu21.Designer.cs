﻿namespace Le_jeu_du_21
{
    partial class Form_Jeu21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jeu21));
            this.button_Arrêter = new System.Windows.Forms.Button();
            this.button_NouvelleCarte = new System.Windows.Forms.Button();
            this.button_Passer = new System.Windows.Forms.Button();
            this.textBox_GameLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Rejouer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_IA2_Journal = new System.Windows.Forms.Button();
            this.BTN_IA1_Journal = new System.Windows.Forms.Button();
            this.leJeuDu21_UserControl2 = new Le_jeu_du_21.LeJeuDu21_UserControl();
            this.leJeuDu21_UserControl1 = new Le_jeu_du_21.LeJeuDu21_UserControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Arrêter
            // 
            this.button_Arrêter.BackColor = System.Drawing.SystemColors.Control;
            this.button_Arrêter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Arrêter.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Arrêter.ForeColor = System.Drawing.Color.Black;
            this.button_Arrêter.Location = new System.Drawing.Point(421, 460);
            this.button_Arrêter.Name = "button_Arrêter";
            this.button_Arrêter.Size = new System.Drawing.Size(172, 65);
            this.button_Arrêter.TabIndex = 3;
            this.button_Arrêter.Text = "Arrêter";
            this.button_Arrêter.UseVisualStyleBackColor = false;
            this.button_Arrêter.Click += new System.EventHandler(this.button_Arrêter_Click);
            // 
            // button_NouvelleCarte
            // 
            this.button_NouvelleCarte.BackColor = System.Drawing.SystemColors.Control;
            this.button_NouvelleCarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NouvelleCarte.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NouvelleCarte.ForeColor = System.Drawing.Color.Black;
            this.button_NouvelleCarte.Location = new System.Drawing.Point(12, 480);
            this.button_NouvelleCarte.Name = "button_NouvelleCarte";
            this.button_NouvelleCarte.Size = new System.Drawing.Size(172, 45);
            this.button_NouvelleCarte.TabIndex = 1;
            this.button_NouvelleCarte.Text = "Nouvelle Carte";
            this.button_NouvelleCarte.UseVisualStyleBackColor = false;
            this.button_NouvelleCarte.Click += new System.EventHandler(this.Jouer);
            // 
            // button_Passer
            // 
            this.button_Passer.BackColor = System.Drawing.SystemColors.Control;
            this.button_Passer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Passer.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Passer.ForeColor = System.Drawing.Color.Black;
            this.button_Passer.Location = new System.Drawing.Point(190, 480);
            this.button_Passer.Name = "button_Passer";
            this.button_Passer.Size = new System.Drawing.Size(172, 45);
            this.button_Passer.TabIndex = 2;
            this.button_Passer.Text = "Passer";
            this.button_Passer.UseVisualStyleBackColor = false;
            this.button_Passer.Click += new System.EventHandler(this.Passer);
            // 
            // textBox_GameLog
            // 
            this.textBox_GameLog.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox_GameLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_GameLog.Enabled = false;
            this.textBox_GameLog.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GameLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_GameLog.Location = new System.Drawing.Point(190, 27);
            this.textBox_GameLog.Name = "textBox_GameLog";
            this.textBox_GameLog.ReadOnly = true;
            this.textBox_GameLog.Size = new System.Drawing.Size(644, 29);
            this.textBox_GameLog.TabIndex = 8;
            this.textBox_GameLog.TextChanged += new System.EventHandler(this.ShowTextInTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(83, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joueur 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(831, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Joueur 2";
            // 
            // button_Rejouer
            // 
            this.button_Rejouer.BackColor = System.Drawing.SystemColors.Control;
            this.button_Rejouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rejouer.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rejouer.ForeColor = System.Drawing.Color.Black;
            this.button_Rejouer.Location = new System.Drawing.Point(824, 480);
            this.button_Rejouer.Name = "button_Rejouer";
            this.button_Rejouer.Size = new System.Drawing.Size(172, 45);
            this.button_Rejouer.TabIndex = 5;
            this.button_Rejouer.Text = "Rejouer";
            this.button_Rejouer.UseVisualStyleBackColor = false;
            this.button_Rejouer.Click += new System.EventHandler(this.button_Rejouer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // BTN_IA2_Journal
            // 
            this.BTN_IA2_Journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_IA2_Journal.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_IA2_Journal.Location = new System.Drawing.Point(646, 502);
            this.BTN_IA2_Journal.Name = "BTN_IA2_Journal";
            this.BTN_IA2_Journal.Size = new System.Drawing.Size(172, 23);
            this.BTN_IA2_Journal.TabIndex = 12;
            this.BTN_IA2_Journal.Text = "Journal AI 2";
            this.BTN_IA2_Journal.UseVisualStyleBackColor = true;
            this.BTN_IA2_Journal.Click += new System.EventHandler(this.BTN_IA2_Journal_Click);
            // 
            // BTN_IA1_Journal
            // 
            this.BTN_IA1_Journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_IA1_Journal.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_IA1_Journal.Location = new System.Drawing.Point(646, 480);
            this.BTN_IA1_Journal.Name = "BTN_IA1_Journal";
            this.BTN_IA1_Journal.Size = new System.Drawing.Size(172, 24);
            this.BTN_IA1_Journal.TabIndex = 6;
            this.BTN_IA1_Journal.Text = "Journal AI 1";
            this.BTN_IA1_Journal.UseVisualStyleBackColor = true;
            this.BTN_IA1_Journal.Click += new System.EventHandler(this.BTN_IA1_Journal_Click);
            // 
            // leJeuDu21_UserControl2
            // 
            this.leJeuDu21_UserControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leJeuDu21_UserControl2.BackgroundImage")));
            this.leJeuDu21_UserControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leJeuDu21_UserControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leJeuDu21_UserControl2.Location = new System.Drawing.Point(83, 301);
            this.leJeuDu21_UserControl2.Name = "leJeuDu21_UserControl2";
            this.leJeuDu21_UserControl2.Size = new System.Drawing.Size(828, 153);
            this.leJeuDu21_UserControl2.TabIndex = 10;
            // 
            // leJeuDu21_UserControl1
            // 
            this.leJeuDu21_UserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leJeuDu21_UserControl1.BackgroundImage")));
            this.leJeuDu21_UserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leJeuDu21_UserControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leJeuDu21_UserControl1.Location = new System.Drawing.Point(83, 62);
            this.leJeuDu21_UserControl1.Name = "leJeuDu21_UserControl1";
            this.leJeuDu21_UserControl1.Size = new System.Drawing.Size(828, 153);
            this.leJeuDu21_UserControl1.TabIndex = 9;
            // 
            // Form_Jeu21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Le_jeu_du_21.Properties.Resources.wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.BTN_IA1_Journal);
            this.Controls.Add(this.BTN_IA2_Journal);
            this.Controls.Add(this.leJeuDu21_UserControl2);
            this.Controls.Add(this.leJeuDu21_UserControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_GameLog);
            this.Controls.Add(this.button_Passer);
            this.Controls.Add(this.button_NouvelleCarte);
            this.Controls.Add(this.button_Rejouer);
            this.Controls.Add(this.button_Arrêter);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Jeu21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le jeu du 21 - Jeu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Arrêter;
        public System.Windows.Forms.Button button_NouvelleCarte;
        public System.Windows.Forms.Button button_Passer;
        private System.Windows.Forms.TextBox textBox_GameLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Rejouer;
        private LeJeuDu21_UserControl leJeuDu21_UserControl1;
        private LeJeuDu21_UserControl leJeuDu21_UserControl2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Button BTN_IA2_Journal;
        private System.Windows.Forms.Button BTN_IA1_Journal;
    }
}