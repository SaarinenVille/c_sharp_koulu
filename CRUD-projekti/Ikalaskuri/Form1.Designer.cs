namespace Ikalaskuri
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
            this.SynttariDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuodetLB = new System.Windows.Forms.Label();
            this.KuukaudetLB = new System.Windows.Forms.Label();
            this.PaivatLB = new System.Windows.Forms.Label();
            this.TunnitLB = new System.Windows.Forms.Label();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SynttariDT
            // 
            this.SynttariDT.Location = new System.Drawing.Point(648, 75);
            this.SynttariDT.Margin = new System.Windows.Forms.Padding(5);
            this.SynttariDT.Name = "SynttariDT";
            this.SynttariDT.Size = new System.Drawing.Size(312, 33);
            this.SynttariDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(998, 70);
            this.LaskeBT.Margin = new System.Windows.Forms.Padding(5);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(118, 38);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske ikäsi";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuodetLB
            // 
            this.VuodetLB.AutoSize = true;
            this.VuodetLB.Location = new System.Drawing.Point(649, 150);
            this.VuodetLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VuodetLB.Name = "VuodetLB";
            this.VuodetLB.Size = new System.Drawing.Size(80, 25);
            this.VuodetLB.TabIndex = 2;
            this.VuodetLB.Text = "Vuosina";
            // 
            // KuukaudetLB
            // 
            this.KuukaudetLB.AutoSize = true;
            this.KuukaudetLB.Location = new System.Drawing.Point(649, 205);
            this.KuukaudetLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.KuukaudetLB.Name = "KuukaudetLB";
            this.KuukaudetLB.Size = new System.Drawing.Size(109, 25);
            this.KuukaudetLB.TabIndex = 3;
            this.KuukaudetLB.Text = "Kuukausina";
            // 
            // PaivatLB
            // 
            this.PaivatLB.AutoSize = true;
            this.PaivatLB.Location = new System.Drawing.Point(649, 259);
            this.PaivatLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PaivatLB.Name = "PaivatLB";
            this.PaivatLB.Size = new System.Drawing.Size(72, 25);
            this.PaivatLB.TabIndex = 4;
            this.PaivatLB.Text = "Päivinä";
            // 
            // TunnitLB
            // 
            this.TunnitLB.AutoSize = true;
            this.TunnitLB.Location = new System.Drawing.Point(943, 150);
            this.TunnitLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TunnitLB.Name = "TunnitLB";
            this.TunnitLB.Size = new System.Drawing.Size(86, 25);
            this.TunnitLB.TabIndex = 5;
            this.TunnitLB.Text = "Tunteina";
            this.TunnitLB.Click += new System.EventHandler(this.label4_Click);
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Location = new System.Drawing.Point(943, 205);
            this.MinuutitLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(115, 25);
            this.MinuutitLB.TabIndex = 6;
            this.MinuutitLB.Text = "Minuutteina";
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Location = new System.Drawing.Point(943, 259);
            this.SekunnitLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(105, 25);
            this.SekunnitLB.TabIndex = 7;
            this.SekunnitLB.Text = "Sekunteina";
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(703, 29);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(208, 25);
            this.OtsikkoLB.TabIndex = 8;
            this.OtsikkoLB.Text = "Valitse syntymäpäiväsi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1317);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.TunnitLB);
            this.Controls.Add(this.PaivatLB);
            this.Controls.Add(this.KuukaudetLB);
            this.Controls.Add(this.VuodetLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.SynttariDT);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker SynttariDT;
        private Button LaskeBT;
        private Label VuodetLB;
        private Label KuukaudetLB;
        private Label PaivatLB;
        private Label TunnitLB;
        private Label MinuutitLB;
        private Label SekunnitLB;
        private Label OtsikkoLB;
    }
}