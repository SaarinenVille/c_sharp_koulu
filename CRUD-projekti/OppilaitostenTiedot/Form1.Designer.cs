namespace OppilaitostenTiedot
{
    partial class AvainhenkilotForm
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
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.VastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.OppilaitosLB = new System.Windows.Forms.Label();
            this.VastuuhenkilöLB = new System.Windows.Forms.Label();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.KatuosoiteLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PostinroLB = new System.Windows.Forms.Label();
            this.PuhNroLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SijaintiLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PhoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(82, 129);
            this.OppilaitosCB.Margin = new System.Windows.Forms.Padding(4);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(154, 29);
            this.OppilaitosCB.TabIndex = 0;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // VastuuhenkiloCB
            // 
            this.VastuuhenkiloCB.FormattingEnabled = true;
            this.VastuuhenkiloCB.Location = new System.Drawing.Point(339, 129);
            this.VastuuhenkiloCB.Margin = new System.Windows.Forms.Padding(4);
            this.VastuuhenkiloCB.Name = "VastuuhenkiloCB";
            this.VastuuhenkiloCB.Size = new System.Drawing.Size(154, 29);
            this.VastuuhenkiloCB.TabIndex = 1;
            this.VastuuhenkiloCB.TextChanged += new System.EventHandler(this.VastuuhenkiloCB_TextChanged);
            // 
            // OppilaitosLB
            // 
            this.OppilaitosLB.AutoSize = true;
            this.OppilaitosLB.Location = new System.Drawing.Point(82, 90);
            this.OppilaitosLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OppilaitosLB.Name = "OppilaitosLB";
            this.OppilaitosLB.Size = new System.Drawing.Size(130, 21);
            this.OppilaitosLB.TabIndex = 3;
            this.OppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // VastuuhenkilöLB
            // 
            this.VastuuhenkilöLB.AutoSize = true;
            this.VastuuhenkilöLB.Location = new System.Drawing.Point(339, 91);
            this.VastuuhenkilöLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VastuuhenkilöLB.Name = "VastuuhenkilöLB";
            this.VastuuhenkilöLB.Size = new System.Drawing.Size(159, 21);
            this.VastuuhenkilöLB.TabIndex = 4;
            this.VastuuhenkilöLB.Text = "Valitse vastuuhenkilö:";
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(150, 25);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(275, 30);
            this.OtsikkoLB.TabIndex = 5;
            this.OtsikkoLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // KatuosoiteLB
            // 
            this.KatuosoiteLB.AutoSize = true;
            this.KatuosoiteLB.Location = new System.Drawing.Point(82, 188);
            this.KatuosoiteLB.Name = "KatuosoiteLB";
            this.KatuosoiteLB.Size = new System.Drawing.Size(83, 21);
            this.KatuosoiteLB.TabIndex = 6;
            this.KatuosoiteLB.Text = "Katuosoite";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(82, 264);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(124, 21);
            this.PostitoimipaikkaLB.TabIndex = 7;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PostinroLB
            // 
            this.PostinroLB.AutoSize = true;
            this.PostinroLB.Location = new System.Drawing.Point(82, 226);
            this.PostinroLB.Name = "PostinroLB";
            this.PostinroLB.Size = new System.Drawing.Size(67, 21);
            this.PostinroLB.TabIndex = 8;
            this.PostinroLB.Text = "Postinro";
            // 
            // PuhNroLB
            // 
            this.PuhNroLB.AutoSize = true;
            this.PuhNroLB.Location = new System.Drawing.Point(82, 309);
            this.PuhNroLB.Name = "PuhNroLB";
            this.PuhNroLB.Size = new System.Drawing.Size(67, 21);
            this.PuhNroLB.TabIndex = 9;
            this.PuhNroLB.Text = "Puh.Nro";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(339, 188);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(48, 21);
            this.TitteliLB.TabIndex = 10;
            this.TitteliLB.Text = "Titteli";
            // 
            // SijaintiLB
            // 
            this.SijaintiLB.AutoSize = true;
            this.SijaintiLB.Location = new System.Drawing.Point(339, 226);
            this.SijaintiLB.Name = "SijaintiLB";
            this.SijaintiLB.Size = new System.Drawing.Size(57, 21);
            this.SijaintiLB.TabIndex = 11;
            this.SijaintiLB.Text = "SIjainti";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(339, 264);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(48, 21);
            this.EmailLB.TabIndex = 12;
            this.EmailLB.Text = "Email";
            // 
            // PhoneLB
            // 
            this.PhoneLB.AutoSize = true;
            this.PhoneLB.Location = new System.Drawing.Point(339, 309);
            this.PhoneLB.Name = "PhoneLB";
            this.PhoneLB.Size = new System.Drawing.Size(67, 21);
            this.PhoneLB.TabIndex = 13;
            this.PhoneLB.Text = "Puh.Nro";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 568);
            this.Controls.Add(this.PhoneLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.SijaintiLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhNroLB);
            this.Controls.Add(this.PostinroLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.KatuosoiteLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.VastuuhenkilöLB);
            this.Controls.Add(this.OppilaitosLB);
            this.Controls.Add(this.VastuuhenkiloCB);
            this.Controls.Add(this.OppilaitosCB);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox OppilaitosCB;
        private ComboBox VastuuhenkiloCB;
        private Label OppilaitosLB;
        private Label VastuuhenkilöLB;
        private Label OtsikkoLB;
        private Label KatuosoiteLB;
        private Label PostitoimipaikkaLB;
        private Label PostinroLB;
        private Label PuhNroLB;
        private Label TitteliLB;
        private Label SijaintiLB;
        private Label EmailLB;
        private Label PhoneLB;
    }
}