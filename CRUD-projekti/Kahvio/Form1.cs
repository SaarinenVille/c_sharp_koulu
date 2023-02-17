namespace Kahvio
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            MeistaPL.Visible = true;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            MeistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin \n";
            MeistaLB.Text += "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            MeistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia \n";
            MeistaLB.Text += "Tervetuloa tutustumaan!";
            MeistaLB.Font = new Font("Arial", 14);
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = true;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = true;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = false;
            MeistaPL.Visible = false;
            JuomatPL.Visible = true;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = false;
            MeistaPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = true;
            KoriPL.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            RuoatPL.Visible = false;
            MeistaPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = true;
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}