namespace CelsiusToFahrenheit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AsteetLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.VaihtoehdotGB = new System.Windows.Forms.GroupBox();
            this.FahrCelsiusRB = new System.Windows.Forms.RadioButton();
            this.CelsiusFahrRB = new System.Windows.Forms.RadioButton();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VaihtoehdotGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsteetLB
            // 
            this.AsteetLB.AutoSize = true;
            this.AsteetLB.Location = new System.Drawing.Point(72, 98);
            this.AsteetLB.Name = "AsteetLB";
            this.AsteetLB.Size = new System.Drawing.Size(129, 30);
            this.AsteetLB.TabIndex = 0;
            this.AsteetLB.Text = "Anna asteet:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(118, 168);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(83, 30);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(207, 98);
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(100, 35);
            this.SyottoTB.TabIndex = 3;
            // 
            // VaihtoehdotGB
            // 
            this.VaihtoehdotGB.Controls.Add(this.FahrCelsiusRB);
            this.VaihtoehdotGB.Controls.Add(this.CelsiusFahrRB);
            this.VaihtoehdotGB.Location = new System.Drawing.Point(391, 98);
            this.VaihtoehdotGB.Name = "VaihtoehdotGB";
            this.VaihtoehdotGB.Size = new System.Drawing.Size(221, 100);
            this.VaihtoehdotGB.TabIndex = 4;
            this.VaihtoehdotGB.TabStop = false;
            this.VaihtoehdotGB.Text = "Miten muunnat?";
            // 
            // FahrCelsiusRB
            // 
            this.FahrCelsiusRB.AutoSize = true;
            this.FahrCelsiusRB.Location = new System.Drawing.Point(16, 66);
            this.FahrCelsiusRB.Name = "FahrCelsiusRB";
            this.FahrCelsiusRB.Size = new System.Drawing.Size(154, 34);
            this.FahrCelsiusRB.TabIndex = 1;
            this.FahrCelsiusRB.TabStop = true;
            this.FahrCelsiusRB.Text = "Fahr - Celsius";
            this.FahrCelsiusRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusFahrRB
            // 
            this.CelsiusFahrRB.AutoSize = true;
            this.CelsiusFahrRB.Location = new System.Drawing.Point(16, 35);
            this.CelsiusFahrRB.Name = "CelsiusFahrRB";
            this.CelsiusFahrRB.Size = new System.Drawing.Size(154, 34);
            this.CelsiusFahrRB.TabIndex = 0;
            this.CelsiusFahrRB.TabStop = true;
            this.CelsiusFahrRB.Text = "Celsius - Fahr";
            this.CelsiusFahrRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MuunnaBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuunnaBT.Location = new System.Drawing.Point(439, 225);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(86, 35);
            this.MuunnaBT.TabIndex = 5;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = false;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Celsius To Fahrenheit Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.VaihtoehdotGB);
            this.Controls.Add(this.SyottoTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.AsteetLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Celsius to fahrenheit";
            this.VaihtoehdotGB.ResumeLayout(false);
            this.VaihtoehdotGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AsteetLB;
        private Label VastausLB;
        private TextBox SyottoTB;
        private GroupBox VaihtoehdotGB;
        private RadioButton FahrCelsiusRB;
        private RadioButton CelsiusFahrRB;
        private Button MuunnaBT;
        private Label label1;
    }
}