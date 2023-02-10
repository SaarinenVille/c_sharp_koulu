using System.Diagnostics;

namespace Ajastin
{
    public partial class AjastinForm : Form
    {
        public AjastinForm()
        {
            InitializeComponent();
        }

        int kokonaisaika;
        private void AjastinForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; // Poistetaan StopBT k�yt�st�
            for (int i = 0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString()); //Lis�t��n minuutteihin 0-59
                SekunnitCB.Items.Add(i.ToString()); // Lis�t��n sekunteihin 0-59
            }
            MinuutitCB.SelectedIndex = 30; // M��ritet��n oletukseski 30
            SekunnitCB.SelectedIndex = 0; // M��ritet��n oletukseski 0
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // Poistetaan k�yt�st�
            StopBT.Enabled = true; // Otetaan k�ytt��n
            // Lasketaan kokonaisaika sekunteina
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString()); // Haetaan valitut minuutit
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString()); // Haetaan valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}