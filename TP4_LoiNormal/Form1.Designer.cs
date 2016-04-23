namespace TP4_LoiNormal
{
    partial class Form_Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
			this.button_Calculer = new System.Windows.Forms.Button();
			this.button_Réinitialiser = new System.Windows.Forms.Button();
			this.textBox_Prob = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.numericUpDown_A = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_B = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_Moyenne = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_ET = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Moyenne)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ET)).BeginInit();
			this.SuspendLayout();
			// 
			// button_Calculer
			// 
			resources.ApplyResources(this.button_Calculer, "button_Calculer");
			this.button_Calculer.Name = "button_Calculer";
			this.button_Calculer.UseVisualStyleBackColor = true;
			this.button_Calculer.Click += new System.EventHandler(this.button_Calculer_Click);
			// 
			// button_Réinitialiser
			// 
			this.button_Réinitialiser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.button_Réinitialiser, "button_Réinitialiser");
			this.button_Réinitialiser.Name = "button_Réinitialiser";
			this.button_Réinitialiser.TabStop = false;
			this.button_Réinitialiser.UseVisualStyleBackColor = true;
			this.button_Réinitialiser.Click += new System.EventHandler(this.button_Réinitialiser_Click);
			// 
			// textBox_Prob
			// 
			this.textBox_Prob.BackColor = System.Drawing.SystemColors.Window;
			this.textBox_Prob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.textBox_Prob, "textBox_Prob");
			this.textBox_Prob.Name = "textBox_Prob";
			this.textBox_Prob.ReadOnly = true;
			this.textBox_Prob.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_Prob_MouseDown);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Name = "label6";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
			resources.ApplyResources(this.comboBox1, "comboBox1");
			this.comboBox1.Name = "comboBox1";
			// 
			// numericUpDown_A
			// 
			this.numericUpDown_A.DecimalPlaces = 2;
			this.numericUpDown_A.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			resources.ApplyResources(this.numericUpDown_A, "numericUpDown_A");
			this.numericUpDown_A.Maximum = new decimal(new int[] {
            409,
            0,
            0,
            131072});
			this.numericUpDown_A.Minimum = new decimal(new int[] {
            409,
            0,
            0,
            -2147352576});
			this.numericUpDown_A.Name = "numericUpDown_A";
			this.numericUpDown_A.Enter += new System.EventHandler(this.SelectAllTextWithTab);
			this.numericUpDown_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DotToComma);
			this.numericUpDown_A.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectAllTextWithMouse);
			// 
			// numericUpDown_B
			// 
			this.numericUpDown_B.DecimalPlaces = 2;
			this.numericUpDown_B.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			resources.ApplyResources(this.numericUpDown_B, "numericUpDown_B");
			this.numericUpDown_B.Maximum = new decimal(new int[] {
            409,
            0,
            0,
            131072});
			this.numericUpDown_B.Minimum = new decimal(new int[] {
            409,
            0,
            0,
            -2147352576});
			this.numericUpDown_B.Name = "numericUpDown_B";
			this.numericUpDown_B.Enter += new System.EventHandler(this.SelectAllTextWithTab);
			this.numericUpDown_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DotToComma);
			this.numericUpDown_B.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectAllTextWithMouse);
			// 
			// numericUpDown_Moyenne
			// 
			this.numericUpDown_Moyenne.DecimalPlaces = 2;
			this.numericUpDown_Moyenne.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			resources.ApplyResources(this.numericUpDown_Moyenne, "numericUpDown_Moyenne");
			this.numericUpDown_Moyenne.Name = "numericUpDown_Moyenne";
			this.numericUpDown_Moyenne.Enter += new System.EventHandler(this.SelectAllTextWithTab);
			this.numericUpDown_Moyenne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DotToComma);
			this.numericUpDown_Moyenne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectAllTextWithMouse);
			// 
			// numericUpDown_ET
			// 
			this.numericUpDown_ET.DecimalPlaces = 2;
			this.numericUpDown_ET.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			resources.ApplyResources(this.numericUpDown_ET, "numericUpDown_ET");
			this.numericUpDown_ET.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_ET.Name = "numericUpDown_ET";
			this.numericUpDown_ET.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown_ET.Enter += new System.EventHandler(this.SelectAllTextWithTab);
			this.numericUpDown_ET.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DotToComma);
			this.numericUpDown_ET.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectAllTextWithMouse);
			// 
			// Form_Main
			// 
			this.AcceptButton = this.button_Calculer;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button_Réinitialiser;
			this.Controls.Add(this.numericUpDown_ET);
			this.Controls.Add(this.numericUpDown_Moyenne);
			this.Controls.Add(this.numericUpDown_B);
			this.Controls.Add(this.numericUpDown_A);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_Prob);
			this.Controls.Add(this.button_Réinitialiser);
			this.Controls.Add(this.button_Calculer);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form_Main";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Moyenne)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ET)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Calculer;
        private System.Windows.Forms.Button button_Réinitialiser;
        private System.Windows.Forms.TextBox textBox_Prob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown_A;
		private System.Windows.Forms.NumericUpDown numericUpDown_B;
		private System.Windows.Forms.NumericUpDown numericUpDown_Moyenne;
		private System.Windows.Forms.NumericUpDown numericUpDown_ET;
	}
}

