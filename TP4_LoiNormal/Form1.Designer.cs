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
			this.textBox_Min = new System.Windows.Forms.TextBox();
			this.textBox_Moy = new System.Windows.Forms.TextBox();
			this.textBox_Max = new System.Windows.Forms.TextBox();
			this.textBox_ET = new System.Windows.Forms.TextBox();
			this.textBox_Prob = new System.Windows.Forms.TextBox();
			this.checkBox_Min = new System.Windows.Forms.CheckBox();
			this.checkBox_Max = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_Calculer
			// 
			resources.ApplyResources(this.button_Calculer, "button_Calculer");
			this.button_Calculer.Name = "button_Calculer";
			this.button_Calculer.UseVisualStyleBackColor = true;
			// 
			// button_Réinitialiser
			// 
			resources.ApplyResources(this.button_Réinitialiser, "button_Réinitialiser");
			this.button_Réinitialiser.Name = "button_Réinitialiser";
			this.button_Réinitialiser.UseVisualStyleBackColor = true;
			this.button_Réinitialiser.Click += new System.EventHandler(this.button_Réinitialiser_Click);
			// 
			// textBox_Min
			// 
			this.textBox_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.textBox_Min, "textBox_Min");
			this.textBox_Min.Name = "textBox_Min";
			// 
			// textBox_Moy
			// 
			this.textBox_Moy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.textBox_Moy, "textBox_Moy");
			this.textBox_Moy.Name = "textBox_Moy";
			// 
			// textBox_Max
			// 
			this.textBox_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.textBox_Max, "textBox_Max");
			this.textBox_Max.Name = "textBox_Max";
			// 
			// textBox_ET
			// 
			this.textBox_ET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.textBox_ET, "textBox_ET");
			this.textBox_ET.Name = "textBox_ET";
			// 
			// textBox_Prob
			// 
			this.textBox_Prob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.textBox_Prob, "textBox_Prob");
			this.textBox_Prob.Name = "textBox_Prob";
			// 
			// checkBox_Min
			// 
			resources.ApplyResources(this.checkBox_Min, "checkBox_Min");
			this.checkBox_Min.BackColor = System.Drawing.Color.Transparent;
			this.checkBox_Min.ForeColor = System.Drawing.Color.White;
			this.checkBox_Min.Name = "checkBox_Min";
			this.checkBox_Min.UseVisualStyleBackColor = false;
			// 
			// checkBox_Max
			// 
			resources.ApplyResources(this.checkBox_Max, "checkBox_Max");
			this.checkBox_Max.BackColor = System.Drawing.Color.Transparent;
			this.checkBox_Max.ForeColor = System.Drawing.Color.White;
			this.checkBox_Max.Name = "checkBox_Max";
			this.checkBox_Max.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Name = "label5";
			// 
			// Form_Main
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TP4_LoiNormal.Properties.Resources.relativity_00447991;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox_Max);
			this.Controls.Add(this.checkBox_Min);
			this.Controls.Add(this.textBox_Prob);
			this.Controls.Add(this.textBox_ET);
			this.Controls.Add(this.textBox_Max);
			this.Controls.Add(this.textBox_Moy);
			this.Controls.Add(this.textBox_Min);
			this.Controls.Add(this.button_Réinitialiser);
			this.Controls.Add(this.button_Calculer);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form_Main";
			this.Load += new System.EventHandler(this.Form_Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Calculer;
        private System.Windows.Forms.Button button_Réinitialiser;
        private System.Windows.Forms.TextBox textBox_Min;
        private System.Windows.Forms.TextBox textBox_Moy;
        private System.Windows.Forms.TextBox textBox_Max;
        private System.Windows.Forms.TextBox textBox_ET;
        private System.Windows.Forms.TextBox textBox_Prob;
        private System.Windows.Forms.CheckBox checkBox_Min;
        private System.Windows.Forms.CheckBox checkBox_Max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

