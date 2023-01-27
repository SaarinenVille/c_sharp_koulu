namespace Ikalaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SynttariDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuodetLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KuukaudetLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            PaivatLB.Text = (erotus + " p‰iv‰‰");
            TunnitLB.Text = (erotus * 24 + " tuntia");
            MinuutitLB.Text = (erotus * 24 * 60 + " minuuttia");
            SekunnitLB.Text = (erotus * 24 * 3600 + "sekuntia");

        }
    }
}