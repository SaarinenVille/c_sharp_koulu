namespace RoomalaisetNumerot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";

            if (SyottoTB.Text.Length > 3) // Syötetty luku on tuhatluku
            {
                luku1 = Convert.ToInt32(SyottoTB.Text.Substring(0, 1)); // Tuhannet
                luku2 = Convert.ToInt32(SyottoTB.Text.Substring(1, 1)); // Sadat
                luku3 = Convert.ToInt32(SyottoTB.Text.Substring(2, 1)); // Kymmenet
                luku4 = Convert.ToInt32(SyottoTB.Text.Substring(3, 1)); // Ykköset
                if (luku1 % 3 == 0)
                {
                    vastaus = "MMM";
                }
                else if (luku1 % 2 == 0)
                {
                    vastaus = "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus = "M";
                }
                else
                {
                    vastaus = "";
                }
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if (SyottoTB.Text.Length > 2) // Syötetty luku on sataluku
            {
                luku2 = Convert.ToInt32(SyottoTB.Text.Substring(0, 1)); // Sataset
                luku3 = Convert.ToInt32(SyottoTB.Text.Substring(1, 1)); // Kymmenet
                luku4 = Convert.ToInt32(SyottoTB.Text.Substring(2, 1)); // Ykköset
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if (SyottoTB.Text.Length > 1) // Syötetty luku on kymmenluku
            {
                luku3 = Convert.ToInt32(SyottoTB.Text.Substring(0, 1)); // Kymmenet
                luku4 = Convert.ToInt32(SyottoTB.Text.Substring(1, 1)); // Ykköset
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if (SyottoTB.Text.Length > 0) // Syötetty luku on alle kymmenen
            {
                luku4 = Convert.ToInt32(SyottoTB.Text.Substring(0, 1)); // Ykköset
                vastaus += ykkoset(luku4, vastaus);
            }
            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }

        private string sataset(int luku2, string vastaus) // Käydään läpi syötetyt sataset
        {
            switch (luku2)
            {
                case 9:
                    return "CM";
                    break;
                case 8:
                    return "DCCC";
                    break;
                case 7:
                    return "DCC";
                    break;                    
                case 6:
                    return "DC";
                    break;                    
                case 5:
                    return "D";
                    break;
                case 4:
                    return "CD";
                    break;
                case 3:
                    return "CCC";
                    break;
                case 2:
                    return "CC";
                    break;
                case 1:
                    return "C";
                    break;
                default:
                    return "";
                    break;
            }
        }

        private string kympit(int luku3, string vastaus)  // Käydään läpi syötetyt kympit
        {
            switch (luku3)
            {
                case 9:
                    return "XC";
                    break;
                case 8:
                    return "LCCC";
                    break;
                case 7:
                    return "LCC";
                    break;
                case 6:
                    return "LC";
                    break;
                case 5:
                    return "L";
                    break;
                case 4:
                    return "LX";
                    break;
                case 3:
                    return "XXX";
                    break;
                case 2:
                    return "XX";
                    break;
                case 1:
                    return "X";
                    break;
                default:
                    return "";
                    break;
            }
        }

        private string ykkoset(int luku4, string vastaus) // Käydään läpi syötetyt ykköset
        {
            switch (luku4)
            {
                case 9:
                    return "IX";
                    break;
                case 8:
                    return "VIII";
                    break;
                case 7:
                    return "VII";
                    break;
                case 6:
                    return "VI";
                    break;
                case 5:
                    return "V";
                    break;
                case 4:
                    return "IV";
                    break;
                case 3:
                    return "III";
                    break;
                case 2:
                    return "II";
                    break;
                case 1:
                    return "I";
                    break;
                default:
                    return "";
                    break;
            }
        }
    }
}