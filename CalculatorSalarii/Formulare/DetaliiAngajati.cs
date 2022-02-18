using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public partial class frmDetaliiAngajati : Form
    {
        string numeFisier;
        bool EsteValid;
        public frmDetaliiAngajati()
        {

            InitializeComponent();
            btnSalvare.Enabled = false;
        }
        //Metoda care converteste imaginea catre formatul binar
        public byte[] ConversieBinara(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);

                return ms.ToArray();
            }

        }

        //AngajatID cerinte Regex:
        //Numere de la 0 la 9
        //Minimum 4, maximum 6 numere
        Regex obAngajatID = new Regex("^[0-9]{4,6}$");

        //Cerinte Regex pentru Nume:
        //Prima litera trebuie sa fie o litera mare de la A la Z
        //Urmatoarele litere pot sa fie mici sau mari de la A la Z
        Regex obNume = new Regex("^[A-Z][a-zA-Z]*$");

        //Cerintele Regex pentru prenume sunt la fel ca si pentru nume
        Regex obPrenume = new Regex("^[A-Z][a-zA-Z]*$");

        //Cerinte Regex pentru validare CNP       
        //Prima componenta reprezinta sexul de la 1 la 8
        //A doua componenta reprezinta anul nasterii formata din ultimele doua cifre
        //A treia componenta reprezinta luna nasterii cu valori intre 01 si 12
        //A patra componenta reprezinta ziua nasterii cu valori intre 01 si 28, 29, 30 sau 31
        //A cincea componenta reprezinta judetul sau sectorul in care s-a nascut persoana
        //A sasea componenta reprezinta un numar secvential cuprins intre 001 si 999
        //A saptea componenta reprezinta uo cifra de control pentru de pistarea erorilor            
        Regex obCNP = new Regex("^[1-8]{1}[0-9]{12}$");

        //Cerinte Regex pentru validare numar de telefon
        //Acesta este compus din 10 numere, fie fix sau mobil
        Regex obTelefon = new Regex("^[0-9]{10}$");

        //Metoda care valideaza datele de intrare
        private bool esteValid()
        {
            //Validare AngajatID
            if (Convert.ToInt32(txtAngajatID.Text.Length) < 1)
            {
                MessageBox.Show("Te rugăm să introduci ID-ul personal !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAngajatID.Focus();
                txtAngajatID.BackColor = Color.Orange;

                return false;
            }
            else if (!obAngajatID.IsMatch(txtAngajatID.Text))
            {
                MessageBox.Show("Atenție, ID-ul personal trebuie să aibă între 4 și 6 numere !",
                    "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAngajatID.Focus();
                txtAngajatID.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtAngajatID.BackColor = Color.White;
            }

            //Validare CNP
            if (string.IsNullOrEmpty(txtCNP.Text))
            {
                MessageBox.Show("Te rugăm să introduci CNP-ul !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCNP.Focus();
                txtCNP.BackColor = Color.Orange;

                return false;
            }
            else if (!obCNP.IsMatch(txtCNP.Text))
            {
                MessageBox.Show("Atenție, CNP-ul trebuie să cuprindă 13 cifre !",
                    "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCNP.Focus();
                txtCNP.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtCNP.BackColor = Color.White;
            }

            //Validare Nume
            if (String.IsNullOrEmpty(txtNume.Text))
            {
                MessageBox.Show("Te rugăm să introduci numele !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Focus();
                txtNume.BackColor = Color.Orange;

                return false;
            }
            else if (!obNume.IsMatch(txtNume.Text))
            {
                MessageBox.Show("Atenție, numele trebuie să înceapă cu literă mare !",
                    "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Focus();
                txtNume.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtNume.BackColor = Color.White;
            }

            //Validare Prenume
            if (String.IsNullOrEmpty(txtPrenume.Text))
            {
                MessageBox.Show("Te rugăm să introduci prenumele !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrenume.Focus();
                txtPrenume.BackColor = Color.Orange;

                return false;
            }
            else if (!obPrenume.IsMatch(txtPrenume.Text))
            {
                MessageBox.Show("Atenție, prenumele trebuie să înceapă cu literă mare !",
                    "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrenume.Focus();
                txtPrenume.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtPrenume.BackColor = Color.White;
            }

            //Validare gen
            if (cmbGen.SelectedIndex == -1)
            {
                MessageBox.Show("Atenție, selectează Masculin sau Feminin !",
                    "Eroare de validare !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGen.Focus();

                return false;
            }

            //Validare Adresa
            if (String.IsNullOrEmpty(txtAdresa.Text))
            {
                MessageBox.Show("Te rugam să introduci adresa !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdresa.Focus();
                txtAdresa.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtAdresa.BackColor = Color.White;
            }

            //Validare Localitate
            if (String.IsNullOrEmpty(txtLocalitatea.Text))
            {
                MessageBox.Show("Te rugam să introduci localitatea !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocalitatea.Focus();
                txtLocalitatea.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtLocalitatea.BackColor = Color.White;
            }

            //Validare Cod Postal
            if (String.IsNullOrEmpty(txtCodPostal.Text))
            {
                MessageBox.Show("Te rugam să introduci codul poștal !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodPostal.Focus();
                txtCodPostal.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtCodPostal.BackColor = Color.White;
            }

            //Validare Judet
            if (String.IsNullOrEmpty(txtJudet.Text))
            {
                MessageBox.Show("Te rugam să introduci județul !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJudet.Focus();
                txtJudet.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtJudet.BackColor = Color.White;
            }

            //Validare Telefon
            if (String.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Te rugam să introduci numărul de telefon !", "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus();
                txtTelefon.BackColor = Color.Orange;

                return false;
            }
            else if (!obTelefon.IsMatch(txtTelefon.Text))
            {
                MessageBox.Show("Atenție, numărul de telefon trebuie să cuprindă 10 cifre !",
                    "Eroare de validare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus();
                txtTelefon.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtTelefon.BackColor = Color.White;
            }

            //Validare Adresa de Email
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Te rugăm să introduci email-ul !", "Eroare de vlidare !",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.BackColor = Color.Orange;

                return false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }

            if (txtEmail.Text.Length >= 1)
            {
                try
                {
                    MailAddress obAdresaEmail = new MailAddress(txtEmail.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Eroare Date Intrare", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtEmail.Focus();
                    txtEmail.BackColor = Color.Orange;

                    return false;
                }
            }

            return true;
        }

        private void btnPoza_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog obPoza = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (obPoza.ShowDialog() == DialogResult.OK)
                {
                    numeFisier = obPoza.FileName;
                    picPoza.Image = Image.FromFile(numeFisier);

                }
               
                numeFisier = lblNumeFisier.Text;
            }
        }

        private void btnStergePoza_Click(object sender, EventArgs e)
        {
            picPoza.Image = null;
        }

        private void btnTablouBord_Click(object sender, EventArgs e)
        {
            frmTablouPrincipal obTablouBord = new frmTablouPrincipal();
            this.Hide();
            obTablouBord.Show();
        }

     

        //Validare eveniment KeyPress
        //Numere si stergere(backspace) vor fi permise
        private void txtAngajatID_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsteValid = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                EsteValid = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        //Validare eveniment KeyPress
        //Numere si stergere(backspace) vor fi permise
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsteValid = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                EsteValid = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Validare eveniment KeyPress
        //Numere si stergere(backspace) vor fi permise
        private void txtCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsteValid = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                EsteValid = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Validare eveniment KeyPress
        //Numere si stergere(backspace) vor fi permise
        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            EsteValid = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                EsteValid = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            if (esteValid())
            {


                 ProcesareDate dbInserare = new ProcesareDate();

                 byte[] bc = ConversieBinara(picPoza.Image);

                 dbInserare.InserareAngajati(Convert.ToInt32(txtAngajatID.Text), txtCNP.Text, txtNume.Text,
                     txtPrenume.Text, dtpDataNasterii.Value.ToString("MM/dd/yy"), cmbGen.SelectedItem.ToString(),
                      txtAdresa.Text, txtLocalitatea.Text, txtJudet.Text, txtCodPostal.Text, txtTelefon.Text,
                      txtEmail.Text, numeFisier, bc);

                // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Angajati' table. You can move, or remove it, as needed.
                this.angajatiTableAdapter.Fill(this.calculatorSalariiDataSet.Angajati);

                MessageBox.Show("Angajatul: " + txtNume.Text + " " + txtPrenume.Text + " cu ID " +
                txtAngajatID.Text + " a fost inserat cu succes!");

               

                 btnSalvare.Enabled = false;
                 btnActualizare.Enabled = true;
                 btnStergeAngajat.Enabled = true;
                 btnAdauga.Enabled = true;
             }
         }

         private void CurataControale()
         {
             txtAngajatID.Clear();
             txtCNP.Clear();
             txtNume.Clear();
             txtPrenume.Clear();
             txtAdresa.Clear();
             txtLocalitatea.Clear();
             txtJudet.Clear();
             txtCodPostal.Clear();
             txtTelefon.Clear();
             txtEmail.Clear();
             dtpDataNasterii.Value = DateTime.Now;
             cmbGen.SelectedIndex = -1;
             picPoza.Image = null;
            }

        private void frmDetaliiAngajati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.calculatorSalariiDataSet.Angajati);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            CurataControale();
            btnSalvare.Enabled = true;
            btnActualizare.Enabled = false;
            btnStergeAngajat.Enabled = false;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            ProcesareDate dbActualizare = new ProcesareDate();

            numeFisier = lblNumeFisier.Text;

            byte[] bc = ConversieBinara(picPoza.Image);

            dbActualizare.ActualizareAngajat(Convert.ToInt32(txtAngajatID.Text), txtCNP.Text,
                txtNume.Text, txtPrenume.Text, dtpDataNasterii.Value.ToString("MM/dd/yy"),
                cmbGen.SelectedItem.ToString(), txtAdresa.Text, txtLocalitatea.Text, txtJudet.Text,
                txtCodPostal.Text, txtTelefon.Text, txtEmail.Text, numeFisier, bc);

            MessageBox.Show("Angajatul: " + txtNume.Text + " " + txtPrenume.Text + " cu ID " +
                txtAngajatID.Text + " a fost actualizat cu succes!");

            // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.calculatorSalariiDataSet.Angajati);

            btnSalvare.Enabled = false;
        }

        private void btnStergeAngajat_Click(object sender, EventArgs e)
        {
            ProcesareDate dbStergere = new ProcesareDate();

            dbStergere.StergereAngajat(Convert.ToInt32(txtAngajatID.Text));

            MessageBox.Show("Angajatul: " + txtNume.Text + " " + txtPrenume.Text + " cu ID " +
               txtAngajatID.Text + " a fost șters cu succes!");

            // TODO: This line of code loads data into the 'calculatorSalariiDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.calculatorSalariiDataSet.Angajati);

            btnSalvare.Enabled = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection celule = dataGridView1.CurrentRow.Cells;
                txtAngajatID.Text = celule[0].Value.ToString();
                txtNume.Text = celule[1].Value.ToString();
                txtPrenume.Text = celule[2].Value.ToString();
                cmbGen.Text = celule[3].Value.ToString();
                txtCNP.Text = celule[4].Value.ToString();
                dtpDataNasterii.Text = celule[5].Value.ToString();
                txtAdresa.Text = celule[6].Value.ToString();
                txtLocalitatea.Text = celule[7].Value.ToString();
                txtCodPostal.Text = celule[8].Value.ToString();
                txtJudet.Text = celule[9].Value.ToString();
                txtTelefon.Text = celule[10].Value.ToString();
                txtEmail.Text = celule[11].Value.ToString();
                lblNumeFisier.Text = celule[12].Value.ToString();
                picPoza.Image = Image.FromFile(celule[12].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
    }
    }
