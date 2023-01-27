namespace CRUD_projekti
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
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(248, 9);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(89, 30);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Otsikko";
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VaihdaBT.Location = new System.Drawing.Point(205, 61);
            this.VaihdaBT.Margin = new System.Windows.Forms.Padding(2);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(182, 44);
            this.VaihdaBT.TabIndex = 1;
            this.VaihdaBT.Text = " Vaihda teksti";
            this.VaihdaBT.UseVisualStyleBackColor = true;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 507);
            this.Controls.Add(this.VaihdaBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Button VaihdaBT;
    }
}