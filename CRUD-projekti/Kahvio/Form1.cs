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
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 v�lituntisin \n";
            MeistaLB.Text += "9:00 - 14:30 joka p�iv� maanantaista torstaihin ja perjantaisin \n";
            MeistaLB.Text += "9:00 - 12:30. \n\nKeudan oppilaskunnan kahvilasta saa l�mpimien \n";
            MeistaLB.Text += "juomien lis�ksi virvokkeita sek� pient� purtavaa sek� makeisia \n";
            MeistaLB.Text += "Tervetuloa tutustumaan!";
            MeistaLB.Font = new Font("Arial", 14);
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = true;
            MeistaBT.BackColor = Color.Green;
            RuoatPL.Visible = false;
            RuoatBT.BackColor = Color.FromArgb(62, 172, 64);
            JuomatPL.Visible = false;
            JuomatBT.BackColor = Color.FromArgb(62, 172, 64);
            HerkutPL.Visible = false;
            HerkutBT.BackColor = Color.FromArgb(62, 172, 64);
            KoriPL.Visible = false;
            KoriBT.BackColor = Color.FromArgb(62, 172, 64);
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            MeistaBT.BackColor = Color.FromArgb(62,172,64);
            RuoatPL.Visible = true;
            RuoatBT.BackColor = Color.Green;
            JuomatPL.Visible = false;
            JuomatBT.BackColor = Color.FromArgb(62, 172, 64);
            HerkutPL.Visible = false;
            HerkutBT.BackColor = Color.FromArgb(62, 172, 64);
            KoriPL.Visible = false;
            KoriBT.BackColor = Color.FromArgb(62, 172, 64);
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            MeistaBT.BackColor = Color.FromArgb(62, 172, 64);
            RuoatPL.Visible = false;
            RuoatBT.BackColor = Color.FromArgb(62, 172, 64);            
            JuomatPL.Visible = true;
            JuomatBT.BackColor = Color.Green;
            HerkutPL.Visible = false;
            HerkutBT.BackColor = Color.FromArgb(62, 172, 64);
            KoriPL.Visible = false;
            KoriBT.BackColor = Color.FromArgb(62, 172, 64);
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            MeistaBT.BackColor = Color.FromArgb(62, 172, 64);
            RuoatPL.Visible = false;
            RuoatBT.BackColor = Color.FromArgb(62, 172, 64);
            JuomatPL.Visible = false;
            JuomatBT.BackColor = Color.FromArgb(62, 172, 64);
            HerkutPL.Visible = true;
            HerkutBT.BackColor = Color.Green;
            KoriPL.Visible = false;
            KoriBT.BackColor = Color.FromArgb(62, 172, 64);
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            MeistaBT.BackColor = Color.FromArgb(62, 172, 64);
            RuoatPL.Visible = false;
            RuoatBT.BackColor = Color.FromArgb(62, 172, 64);            
            JuomatPL.Visible = false;
            JuomatBT.BackColor = Color.FromArgb(62, 172, 64);
            HerkutPL.Visible = false;
            HerkutBT.BackColor = Color.FromArgb(62, 172, 64);
            KoriPL.Visible = true;
            KoriBT.BackColor = Color.Green;
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}