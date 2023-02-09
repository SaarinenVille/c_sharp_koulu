using System.IO;

namespace Muistio
{
    public partial class Muistio : Form
    {
        public Muistio()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("E:/Koulu/Ohjelmistokehittäjä/Graafinen käyttöliittymä/Muistio/demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("E:/Koulu/Ohjelmistokehittäjä/Graafinen käyttöliittymä/Muistio/demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
          
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaBT_Click(sender, e);
        }
    }
}