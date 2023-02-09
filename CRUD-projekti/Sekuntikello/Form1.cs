using System.Diagnostics;

namespace Sekuntikello
{
    public partial class SekuntiKello : Form
    {
        private Stopwatch stopWatch = new Stopwatch();
        public SekuntiKello()
        {            
        InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void SekuntiKello_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}