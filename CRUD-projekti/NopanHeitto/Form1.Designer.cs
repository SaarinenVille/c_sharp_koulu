namespace NopanHeitto
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
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.heitaBT = new System.Windows.Forms.Button();
            this.Noppa03PB = new System.Windows.Forms.PictureBox();
            this.Noppa04PB = new System.Windows.Forms.PictureBox();
            this.Noppa05PB = new System.Windows.Forms.PictureBox();
            this.AlustaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa03PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa04PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa05PB)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(558, 47);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(306, 57);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Nopan heitto";
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::NopanHeitto.Properties.Resources.rollingDice;
            this.Noppa01PB.Location = new System.Drawing.Point(137, 144);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(220, 164);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 1;
            this.Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::NopanHeitto.Properties.Resources.rollingDice;
            this.Noppa02PB.Location = new System.Drawing.Point(363, 144);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(220, 164);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 2;
            this.Noppa02PB.TabStop = false;
            // 
            // heitaBT
            // 
            this.heitaBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.heitaBT.Location = new System.Drawing.Point(558, 371);
            this.heitaBT.Name = "heitaBT";
            this.heitaBT.Size = new System.Drawing.Size(136, 46);
            this.heitaBT.TabIndex = 3;
            this.heitaBT.Text = "Heitä";
            this.heitaBT.UseVisualStyleBackColor = false;
            this.heitaBT.Click += new System.EventHandler(this.heitaBT_Click);
            // 
            // Noppa03PB
            // 
            this.Noppa03PB.Image = global::NopanHeitto.Properties.Resources.rollingDice;
            this.Noppa03PB.Location = new System.Drawing.Point(599, 144);
            this.Noppa03PB.Name = "Noppa03PB";
            this.Noppa03PB.Size = new System.Drawing.Size(220, 164);
            this.Noppa03PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa03PB.TabIndex = 4;
            this.Noppa03PB.TabStop = false;
            // 
            // Noppa04PB
            // 
            this.Noppa04PB.Image = global::NopanHeitto.Properties.Resources.rollingDice;
            this.Noppa04PB.Location = new System.Drawing.Point(825, 144);
            this.Noppa04PB.Name = "Noppa04PB";
            this.Noppa04PB.Size = new System.Drawing.Size(220, 164);
            this.Noppa04PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa04PB.TabIndex = 5;
            this.Noppa04PB.TabStop = false;
            // 
            // Noppa05PB
            // 
            this.Noppa05PB.Image = global::NopanHeitto.Properties.Resources.rollingDice;
            this.Noppa05PB.Location = new System.Drawing.Point(1051, 144);
            this.Noppa05PB.Name = "Noppa05PB";
            this.Noppa05PB.Size = new System.Drawing.Size(220, 164);
            this.Noppa05PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa05PB.TabIndex = 6;
            this.Noppa05PB.TabStop = false;
            // 
            // AlustaBT
            // 
            this.AlustaBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AlustaBT.Location = new System.Drawing.Point(728, 370);
            this.AlustaBT.Name = "AlustaBT";
            this.AlustaBT.Size = new System.Drawing.Size(136, 47);
            this.AlustaBT.TabIndex = 7;
            this.AlustaBT.Text = "Alusta";
            this.AlustaBT.UseVisualStyleBackColor = false;
            this.AlustaBT.Click += new System.EventHandler(this.AlustaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1512, 847);
            this.Controls.Add(this.AlustaBT);
            this.Controls.Add(this.Noppa05PB);
            this.Controls.Add(this.Noppa04PB);
            this.Controls.Add(this.Noppa03PB);
            this.Controls.Add(this.heitaBT);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa01PB);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa03PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa04PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa05PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
        private Button heitaBT;
        private PictureBox Noppa03PB;
        private PictureBox Noppa04PB;
        private PictureBox Noppa05PB;
        private Button AlustaBT;
    }
}