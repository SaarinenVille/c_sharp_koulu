namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Ville" && SalasanaTB.Text == "Vesi@Hiisi")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }

        private void NaytaCB_CheckedChanged(object sender, EventArgs e)
        {
            if(NaytaCB.Checked) 
            {
                SalasanaTB.PasswordChar = '\0';
            }
            else 
            {
                SalasanaTB.PasswordChar = '*';
            }
        }
    }
}