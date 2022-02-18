
using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class FrmRapoarte : Form
    {
        public FrmRapoarte()
        {
            InitializeComponent();
        }

        private void btninchide_Click(object sender, EventArgs e)
        {
            frmTablouPrincipal obTablouBord = new frmTablouPrincipal();
            this.Hide();
            obTablouBord.Show();
        }

        private void btnRapoarteExportExcel_Click(object sender, EventArgs e)
        {
           Microsoft.Office.Interop.Excel.Application ExcelExport;
            Workbook registruDeLucru;
            Worksheet foaieDeCalcul;

            try
            {
                ExcelExport = new Microsoft.Office.Interop.Excel.Application();
                registruDeLucru = ExcelExport.Workbooks.Add(Type.Missing);
                foaieDeCalcul = null;

                foaieDeCalcul = registruDeLucru.Sheets["Sheet1"];
                foaieDeCalcul = registruDeLucru.ActiveSheet;
                foaieDeCalcul.Name = "DatePlatiSalarii";
                ExcelExport.Visible = true;

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    foaieDeCalcul.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        foaieDeCalcul.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                ExcelExport.Columns.AutoFit();

            }
            catch (Exception)
            {

            }
            finally
            {

            }  
        }

        private void FrmRapoarte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorSalariiDataSet4.PlatiSalariu' table. You can move, or remove it, as needed.
            this.platiSalariuTableAdapter.Fill(this.calculatorSalariiDataSet4.PlatiSalariu);

        }
    }
}
