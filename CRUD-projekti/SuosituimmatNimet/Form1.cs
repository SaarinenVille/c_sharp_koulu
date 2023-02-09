using System.IO;

namespace SuosituimmatNimet
{
    public partial class SuosituimmatNimet : Form
    {
        public SuosituimmatNimet()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            string[] pojat = File.ReadAllLines("E:/Koulu/Ohjelmistokehittäjä/Graafinen käyttöliittymä/Nimet/pojat.txt");
            string[] tytot = File.ReadAllLines("E:/Koulu/Ohjelmistokehittäjä/Graafinen käyttöliittymä/Nimet/tytot.txt");
            string syotto = SyottoTB.Text;
            int laskuriPojat = 1;
            int laskuriTytot = 1;

            VastausLB.Text = "";
            VastausLB.Visible = false;

            foreach (string poika in pojat) 
            {
                if (syotto == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskuriPojat + ". suosituin pojan nimi vuonna 2020.";
                    VastausLB.Visible = true;
                }
                laskuriPojat++;
            }
            foreach (string tytto in tytot) 
            {
                if (syotto == tytto) 
                {
                    VastausLB.Text = "Nimesi on " + laskuriTytot + ". suosituin tytönnimi vuonna 2020.";
                    VastausLB.Visible = true;
                }
                laskuriTytot++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei ole 50 suosituimman nimen joukossa.";
                VastausLB.Visible = true;
            }
        }

        private void SyottoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TarkastaBT_Click(sender, e);
        }
    }
}