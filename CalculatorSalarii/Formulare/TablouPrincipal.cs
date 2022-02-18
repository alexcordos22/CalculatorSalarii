using System;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class frmTablouPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public frmTablouPrincipal()
        {
            InitializeComponent();
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            frmDetaliiAngajati obDetaliiAngajati = new frmDetaliiAngajati();
            this.Hide();
            obDetaliiAngajati.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalarii_Click(object sender, EventArgs e)
        {
            FrmCalculatorSalarii obcalculatorSalarii = new FrmCalculatorSalarii();
            this.Hide();
            obcalculatorSalarii.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmInregistrareUtilizatori obUtilizatori = new FrmInregistrareUtilizatori();
            this.Hide();
            obUtilizatori.Show();
        }

        private void btnRapoarte_Click(object sender, EventArgs e)
        {
            FrmRapoarte obRapoarte = new FrmRapoarte();
            this.Hide();
            obRapoarte.Show();
        }

        private void angajațiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetaliiAngajati obDetaliiAngajati = new frmDetaliiAngajati();
            this.Hide();
            obDetaliiAngajati.Show();
        }

        private void salariiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculatorSalarii obcalculatorSalarii = new FrmCalculatorSalarii();
            this.Hide();
            obcalculatorSalarii.Show();
        }

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapoarte obRapoarte = new FrmRapoarte();
            this.Hide();
            obRapoarte.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInregistrareUtilizatori obUtilizatori = new FrmInregistrareUtilizatori();
            this.Hide();
            obUtilizatori.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
