using System.IO;

namespace Notepad
{
    public partial class Notepad : Form
    {
        string tiedostopolku = "";
        public Notepad()
        {
            InitializeComponent();
        }

        // Metodit Tiedosto- valikon toimintoihin

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TekstilaatikkoRTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                TekstilaatikkoRTB.Text = "";
            }
            else
            {
                TekstilaatikkoRTB.Text = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            {Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false})
            {
                if(atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader jonolukija = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        TekstilaatikkoRTB.Rtf = text.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostopolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                        {
                            jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter jonokirjoittaja = new StreamWriter(tiedostopolku))
                {
                    jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                }
            }

        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tässä voi käyttää tallenna-komentoa
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstilaatikkoRTB.Text, TekstilaatikkoRTB.Font, Brushes.Black, 12, 10);
        }

        // Metodit muokkaa- valikolle

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectAll();
        }

        private void TekstilaatikkoRTB_TextChanged(object sender, EventArgs e)
        {
            if(TekstilaatikkoRTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                TekstilaatikkoRTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                TekstilaatikkoRTB.WordWrap = true;
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectionBackColor = Color.LightBlue;
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tietoa tietoa = new Tietoa();
            tietoa.ShowDialog();
        }
    }
}