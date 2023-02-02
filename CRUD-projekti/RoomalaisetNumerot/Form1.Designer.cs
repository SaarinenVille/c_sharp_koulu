namespace RoomalaisetNumerot
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.OhjleLB = new System.Windows.Forms.Label();
            this.AlaotsikkoLB = new System.Windows.Forms.Label();
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(535, 98);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(480, 65);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Roomalaiset numerot";
            this.OtsikkoLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OhjleLB
            // 
            this.OhjleLB.AutoSize = true;
            this.OhjleLB.Location = new System.Drawing.Point(502, 245);
            this.OhjleLB.Name = "OhjleLB";
            this.OhjleLB.Size = new System.Drawing.Size(281, 32);
            this.OhjleLB.TabIndex = 1;
            this.OhjleLB.Text = "Syötä luku väliltä 1-3999:";
            // 
            // AlaotsikkoLB
            // 
            this.AlaotsikkoLB.AutoSize = true;
            this.AlaotsikkoLB.Location = new System.Drawing.Point(502, 188);
            this.AlaotsikkoLB.Name = "AlaotsikkoLB";
            this.AlaotsikkoLB.Size = new System.Drawing.Size(537, 32);
            this.AlaotsikkoLB.TabIndex = 2;
            this.AlaotsikkoLB.Text = "Ohjelma muuttaa luvun roomalaiseksi numeroksi";
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(789, 242);
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(109, 39);
            this.SyottoTB.TabIndex = 3;
            // 
            // MuutaBT
            // 
            this.MuutaBT.Location = new System.Drawing.Point(933, 242);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(106, 39);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(733, 329);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(93, 32);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 960);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.SyottoTB);
            this.Controls.Add(this.AlaotsikkoLB);
            this.Controls.Add(this.OhjleLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Roomalaiset numerot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Label OhjleLB;
        private Label AlaotsikkoLB;
        private TextBox SyottoTB;
        private Button MuutaBT;
        private Label VastausLB;
    }
}