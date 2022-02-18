using System;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class FrmConvertor : Form
    {
        public FrmConvertor()
        {
            InitializeComponent();
        }

        private void btnConvertorCalculatorSalarii_Click(object sender, EventArgs e)
        {
            FrmCalculatorSalarii obcalculatorSalarii = new FrmCalculatorSalarii();
            this.Hide();
            obcalculatorSalarii.Show();
        }

        private void btnConvertor_Click(object sender, EventArgs e)
        {
            decimal ore, minute, OreZecimal = 0.00M;

            if (decimal.TryParse(txtOre.Text, out ore))
            {
                if (decimal.TryParse(txtMinute.Text, out minute))
                {
                    OreZecimal = ConvertTimpCatreZecimal(ore, minute);
                    txtNumarZecimal.Text = OreZecimal.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Vă rugăm, introduceți numere");
                    txtMinute.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm, introduceți numere");
                txtOre.Focus();
            }
        }

        private decimal ConvertTimpCatreZecimal(decimal ore, decimal minute)
        {
            return ore + (minute / 60);
        }
    }
}
