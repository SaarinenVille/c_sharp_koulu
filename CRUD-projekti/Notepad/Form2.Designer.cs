namespace Notepad
{
    partial class Tietoa
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
            this.TiedotLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TiedotLB
            // 
            this.TiedotLB.AutoSize = true;
            this.TiedotLB.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TiedotLB.Location = new System.Drawing.Point(28, 25);
            this.TiedotLB.Name = "TiedotLB";
            this.TiedotLB.Size = new System.Drawing.Size(534, 64);
            this.TiedotLB.TabIndex = 0;
            this.TiedotLB.Text = "Made by: Ville Saarinen";
            // 
            // Tietoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 120);
            this.Controls.Add(this.TiedotLB);
            this.Name = "Tietoa";
            this.Text = "Tietoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TiedotLB;
    }
}