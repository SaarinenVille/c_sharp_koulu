namespace CelsiusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double syotto = Convert.ToDouble(SyottoTB.Text);

            if (CelsiusFahrRB.Checked) 
            {
                vastaus = syotto * 1.8 + 32;
                VastausLB.Text = syotto + " °C = " + vastaus + " °F";
                VastausLB.Visible= true;
            }
            else if (FahrCelsiusRB.Checked) 
            {
                vastaus = (syotto - 32) / 1.8;
                VastausLB.Text = syotto + " °F = " + vastaus + " °C";
                VastausLB.Visible= true;
            }
        }
    }
}