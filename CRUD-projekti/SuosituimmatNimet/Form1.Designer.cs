namespace SuosituimmatNimet
{
    partial class SuosituimmatNimet
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
            this.AnnaNimiLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnnaNimiLB
            // 
            this.AnnaNimiLB.AutoSize = true;
            this.AnnaNimiLB.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnnaNimiLB.Location = new System.Drawing.Point(168, 102);
            this.AnnaNimiLB.Name = "AnnaNimiLB";
            this.AnnaNimiLB.Size = new System.Drawing.Size(597, 25);
            this.AnnaNimiLB.TabIndex = 0;
            this.AnnaNimiLB.Text = "Anna etunimesi. Katsotaan löytyykö se 50 suosituimman nimen joukosta:  ";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(168, 151);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            // 
            // SyottoTB
            // 
            this.SyottoTB.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyottoTB.Location = new System.Drawing.Point(771, 99);
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(184, 32);
            this.SyottoTB.TabIndex = 2;
            this.SyottoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SyottoTB_KeyPress);
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TarkastaBT.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TarkastaBT.Location = new System.Drawing.Point(809, 147);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(98, 33);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = false;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(351, 26);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(407, 30);
            this.OtsikkoLB.TabIndex = 4;
            this.OtsikkoLB.Text = "Suosituimpien nimien haku";
            // 
            // SuosituimmatNimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1125, 296);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.SyottoTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.AnnaNimiLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SuosituimmatNimet";
            this.Text = "Suosituimmat etunimet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AnnaNimiLB;
        private Label VastausLB;
        private TextBox SyottoTB;
        private Button TarkastaBT;
        private Label OtsikkoLB;
    }
}