namespace PainoIndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0;
            double pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double vastaus = Math.Round(paino / ((pituus / 100) * (pituus / 100)), 2);

            if (vastaus < 18.5) 
            {
                VastausLB.Text = "Painoindeksisi on: " + vastaus;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (vastaus < 25)
            {
                VastausLB.Text = "Painoindeksisi on: " + vastaus;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaali paino";
                KuvausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (vastaus < 40)
            {
                VastausLB.Text = "Painoindeksisi on: " + vastaus;
                VastausLB.ForeColor = Color.OrangeRed;
                KuvausLB.Text = "Lievä ylipaino";
                KuvausLB.ForeColor= Color.OrangeRed;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksisi on: " + vastaus;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Merkittävä ylipaino";
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
        }
    }
}