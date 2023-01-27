namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                double luku1 = double.Parse(LukuYksiTB.Text); // Parse-komennolla muunnetaan teksti luvuksi
                double luku2 = double.Parse(LukuKaksiTB.Text);
            double vastaus = 0;
                string merkki = LaskutoimitusCB.Text;

                switch(merkki)
                {
                    case "+":
                        vastaus = luku1 + luku2;
                        break;
                    case "-":
                        vastaus = luku1 - luku2;
                        break;
                    case "*":
                        vastaus = luku1 * luku2;
                        break;
                    case "/":
                        vastaus = luku1 / luku2;
                        break;
                    default:
                    VastausLB.Text = "Virheellinen syöttö";
                    break;

                }
                VastausLB.Text = vastaus.ToString();
                VastausLB.Visible = true;
        }
    }

}
    
