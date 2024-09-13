namespace Vonatjegy
{
    public partial class Form1 : Form
    {
        double fizetendo;
        private void szamolas()
        {
            fizetendo = 0;
            int km = 0;
            if (txkm.TextLength > 0)
            {
                fizetendo = Convert.ToInt32(txkm.Text) * 25;
                if (rbotven.Checked)
                {
                    fizetendo = fizetendo / 2;
                }
                if (rbkilencven.Checked)
                {
                    fizetendo = fizetendo * 0.1;
                }
                if (rbigen.Checked)
                {
                    fizetendo += 150;
                }
            }
            lbkiiras.Text = "A fizetendõ összeg: " + Convert.ToString(fizetendo);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btszamol_Click(object sender, EventArgs e)
        {
            szamolas();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rbteljes.Checked = true;
            rbnem.Checked = true;
            lbkiiras.Text = "";
        }

        private void rbteljes_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rbotven_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rbkilencven_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rbnem_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void rbigen_CheckedChanged(object sender, EventArgs e)
        {
            szamolas();
        }

        private void btkilepes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
