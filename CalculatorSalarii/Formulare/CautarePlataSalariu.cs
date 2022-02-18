using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class FrmCautarePlataSalariu : Form
    {
        public FrmCautarePlataSalariu()
        {
            InitializeComponent();
        }
        List<DatePlataSalarii> obDatePlataSalarii = new List<DatePlataSalarii>();
        private void btnCalculatorSalariu_Click(object sender, EventArgs e)
        {
            FrmCalculatorSalarii obcalculatorSalarii = new FrmCalculatorSalarii();
            this.Hide();
            obcalculatorSalarii.Show();
        }

        private void btnCautarePlataSalariu_Click(object sender, EventArgs e)
        {
            ProcesareDate obCautarePlata = new ProcesareDate();
            obDatePlataSalarii = obCautarePlata.CautarePlata(txtCautareNume.Text);

            try
            {
                if (obDatePlataSalarii.Count > 0)
                {
                    dataGridView1.DataSource = obDatePlataSalarii;

                }
                else
                {
                    MessageBox.Show("Nu au fost găsite înregistrări cu numele : " + txtCautareNume.Text, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare : " + ex.Message, "Error Message");
            }
        }

        private void FrmCautarePlataSalariu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorSalariiDataSet2.PlatiSalariu' table. You can move, or remove it, as needed.
            this.platiSalariuTableAdapter.Fill(this.calculatorSalariiDataSet2.PlatiSalariu);

        }
    }
}
