namespace PFI3
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown_A = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_B = new System.Windows.Forms.NumericUpDown();
			this.comboBox_Fonction = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonCalculer = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.textBox_Pi = new System.Windows.Forms.TextBox();
			this.textBox_IC = new System.Windows.Forms.TextBox();
			this.textBox_Aire = new System.Windows.Forms.TextBox();
			this.textBox_ME = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "a";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown_A
			// 
			this.numericUpDown_A.DecimalPlaces = 2;
			this.numericUpDown_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_A.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_A.Location = new System.Drawing.Point(116, 12);
			this.numericUpDown_A.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.numericUpDown_A.Name = "numericUpDown_A";
			this.numericUpDown_A.Size = new System.Drawing.Size(197, 26);
			this.numericUpDown_A.TabIndex = 1;
			this.numericUpDown_A.DoubleClick += new System.EventHandler(this.SelectAllTextWithMouse);
			this.numericUpDown_A.Enter += new System.EventHandler(this.SelectAllTextWithTab);
			this.numericUpDown_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DotToComma);
			// 
			// numericUpDown_B
			// 
			this.numericUpDown_B.DecimalPlaces = 2;
			this.numericUpDown_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_B.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_B.Location = new System.Drawing.Point(116, 45);
			this.numericUpDown_B.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.numericUpDown_B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_B.Name = "numericUpDown_B";
			this.numericUpDown_B.Size = new System.Drawing.Size(197, 26);
			this.numericUpDown_B.TabIndex = 2;
			this.numericUpDown_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_B.DoubleClick += new System.EventHandler(this.SelectAllTextWithMouse);
			this.numericUpDown_B.Enter += new System.EventHandler(this.SelectAllTextWithTab);
			this.numericUpDown_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DotToComma);
			// 
			// comboBox_Fonction
			// 
			this.comboBox_Fonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Fonction.DropDownWidth = 197;
			this.comboBox_Fonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_Fonction.FormattingEnabled = true;
			this.comboBox_Fonction.Items.AddRange(new object[] {
            "(x^2 - 16x + 63)^1/3 + 4",
            "3((x-7)/5)^5-5((x-7)/5)^3 + 3",
            "-1/3(x-6)^2 + 12",
            "x + sin(x)",
            "cos(x) + 3"});
			this.comboBox_Fonction.Location = new System.Drawing.Point(116, 76);
			this.comboBox_Fonction.Name = "comboBox_Fonction";
			this.comboBox_Fonction.Size = new System.Drawing.Size(197, 28);
			this.comboBox_Fonction.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "b";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Fonction";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "π";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "IC";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 211);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Probabilité";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonCalculer
			// 
			this.buttonCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCalculer.Location = new System.Drawing.Point(232, 244);
			this.buttonCalculer.Name = "buttonCalculer";
			this.buttonCalculer.Size = new System.Drawing.Size(86, 32);
			this.buttonCalculer.TabIndex = 4;
			this.buttonCalculer.Text = "Calculer";
			this.buttonCalculer.UseVisualStyleBackColor = true;
			this.buttonCalculer.Click += new System.EventHandler(this.buttonCalculer_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClear.Location = new System.Drawing.Point(17, 244);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(86, 32);
			this.buttonClear.TabIndex = 12;
			this.buttonClear.TabStop = false;
			this.buttonClear.Text = "Effacer";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// textBox_Pi
			// 
			this.textBox_Pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Pi.Location = new System.Drawing.Point(116, 110);
			this.textBox_Pi.Name = "textBox_Pi";
			this.textBox_Pi.ReadOnly = true;
			this.textBox_Pi.Size = new System.Drawing.Size(197, 26);
			this.textBox_Pi.TabIndex = 13;
			this.textBox_Pi.TabStop = false;
			// 
			// textBox_IC
			// 
			this.textBox_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_IC.Location = new System.Drawing.Point(116, 143);
			this.textBox_IC.Name = "textBox_IC";
			this.textBox_IC.ReadOnly = true;
			this.textBox_IC.Size = new System.Drawing.Size(197, 26);
			this.textBox_IC.TabIndex = 14;
			this.textBox_IC.TabStop = false;
			// 
			// textBox_Aire
			// 
			this.textBox_Aire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Aire.Location = new System.Drawing.Point(116, 209);
			this.textBox_Aire.Name = "textBox_Aire";
			this.textBox_Aire.ReadOnly = true;
			this.textBox_Aire.Size = new System.Drawing.Size(197, 26);
			this.textBox_Aire.TabIndex = 15;
			this.textBox_Aire.TabStop = false;
			// 
			// textBox_ME
			// 
			this.textBox_ME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_ME.Location = new System.Drawing.Point(116, 176);
			this.textBox_ME.Name = "textBox_ME";
			this.textBox_ME.ReadOnly = true;
			this.textBox_ME.Size = new System.Drawing.Size(197, 26);
			this.textBox_ME.TabIndex = 17;
			this.textBox_ME.TabStop = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "ME";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonCalculer;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 286);
			this.Controls.Add(this.textBox_ME);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_Aire);
			this.Controls.Add(this.textBox_IC);
			this.Controls.Add(this.textBox_Pi);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonCalculer);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox_Fonction);
			this.Controls.Add(this.numericUpDown_B);
			this.Controls.Add(this.numericUpDown_A);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inférence et Probabilités";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown_A;
		private System.Windows.Forms.NumericUpDown numericUpDown_B;
		private System.Windows.Forms.ComboBox comboBox_Fonction;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonCalculer;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TextBox textBox_Pi;
		private System.Windows.Forms.TextBox textBox_IC;
		private System.Windows.Forms.TextBox textBox_Aire;
		private System.Windows.Forms.TextBox textBox_ME;
		private System.Windows.Forms.Label label7;
	}
}

