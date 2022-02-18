using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorSalarii
{

    public partial class FrmCalculatorSalarii : Form
    {

        //Declarare variabile pentru ore contractuale
        double contrOS1, contrOS2, contrOS3, contrOS4;
        //Declarare variabile pentru ore suplimentare
        double suplOS1, suplOS2, suplOS3, suplOS4;

        //Declarare variabile total ore lucrate
        public static double totalOreLucrate;
        public static double totalOreSuplimentare;
        public static double totalOreContractuale;
        public static double TotalOre;

        //Declarare variabile pentru Castig Salarial
        double contrSumaS1, contrSumaS2, contrSumaS3, contrSumaS4;
        double SuplSumaS1, SuplSumaS2, SuplSumaS3, SuplSumaS4;

        //Declarare variabile pentru total castiguri
        double totalCastig;
        double totalCastigSuplimentar;
        double totalCastigContractual;

        //Declarare variabile for deduceri
        double impozit, cas, cass, deducerePersonala;

        double totalDeduceri;

        //Declarare variabile pentru tarif orar
        double OreContractuale, OreSuplimentare;


        //Declarare variabila pentru tarif Orar ore suplimentare
        double tarifOrarSupl;

        //Declare variable pentru Salariul Net
        double castigNet;

        FrmPontajOre obTarifOrar = new FrmPontajOre();

        List<DateAngajati> obCautaAngajat = new List<DateAngajati>();

        private void btnPrinteaza_Click(object sender, EventArgs e)
        {
           
        }
        private void dgvCalculatorSalarii_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnSalveaza.Enabled = false;
            btnCalculeaza.Enabled = false;

            decimal castigContractual, castigOreSuplimentare, totalSalariu, impozit, cas, cass, deducerePersonala,
                    totalDeduceri, salariuNet;

            try
            {
                DataGridViewCellCollection celula = dgvCalculatorSalarii.CurrentRow.Cells;
                txtSalariiAngajatID.Text = celula[1].Value.ToString();
                txtSalariiNume.Text = celula[2].Value.ToString();
                txtSalariiPrenume.Text = celula[3].Value.ToString();
                txtSalariiCNP.Text = celula[4].Value.ToString();
                dtpDataCurenta.Text = celula[5].Value.ToString();
                listPerioadaDePlata.Text = celula[6].Value.ToString();
                cmbLunaDePlata.Text = celula[7].Value.ToString();
                txtTarifOreSuplimentare.Text = celula[9].Value.ToString();
                txtOreContractuale.Text = celula[10].Value.ToString();
                txtOreSuplimentare.Text = celula[11].Value.ToString();
                txtTotalOre.Text = celula[12].Value.ToString();
                castigContractual = (decimal)celula[13].Value;
                txtCastigContractual.Text = String.Format("{0:f2}", castigContractual);
                castigOreSuplimentare = (decimal)celula[14].Value;
                txtCastigOreSuplimentare.Text = String.Format("{0:f2}", castigOreSuplimentare);
                totalSalariu = (decimal)celula[15].Value;
                txtTotalSalariu.Text = String.Format("{0:f2}", totalSalariu);
                impozit = (decimal)celula[16].Value;
                txtImpozit.Text = String.Format("{0:f2}", impozit);
                cas = (decimal)celula[17].Value;
                txtCAS.Text = String.Format("{0:f2}", cas);
                cass = (decimal)celula[18].Value;
                txtSanatate.Text = String.Format("{0:f2}", cass);
                deducerePersonala = (decimal)celula[19].Value;
                txtDeducerePersonala.Text = String.Format("{0:f2}", deducerePersonala);
                totalDeduceri = (decimal)celula[20].Value;
                txtTotalDeduceri.Text = String.Format("{0:f2}", totalDeduceri);
                salariuNet = (decimal)celula[21].Value;
                txtSalariuNet.Text = String.Format("{0:f2}", salariuNet);
            }
            catch (Exception)
            {

            }
        }

        private void btnCalcSalariiTablouBord_Click(object sender, EventArgs e)
        {
            frmTablouPrincipal obTablouBord = new frmTablouPrincipal();
            this.Hide();
            obTablouBord.Show();
        }

        private void btnCautarePlataSalariu_Click(object sender, EventArgs e)
        {
            FrmCautarePlataSalariu obCautarePlataSalariu = new FrmCautarePlataSalariu();
            this.Hide();
            obCautarePlataSalariu.Show();
        }

        private void btnConvertor_Click(object sender, EventArgs e)
        {
            FrmConvertor obConvertor = new FrmConvertor();
            this.Hide();
            obConvertor.Show();
        }

        public FrmCalculatorSalarii()
        {
            InitializeComponent();
            btnSalveaza.Enabled = false;
            btnCalculeaza.Enabled = false;
        }

        private void btnPontajOre_Click(object sender, EventArgs e)
        {
            FrmPontajOre obPontajOre = new FrmPontajOre();
            obPontajOre.Show();
        }

        private void btnCautareAngajat_Click(object sender, EventArgs e)
        {

            try
            {
                ProcesareDate obAngajatBD = new ProcesareDate();
                obCautaAngajat = obAngajatBD.CautareAngajat(Convert.ToInt32(txtSalariiAngajatID.Text));

                if (obCautaAngajat.Count > 0)
                {
                    foreach (var dateAngajat in obCautaAngajat)
                    {
                        txtSalariiNume.Text = dateAngajat.Nume;
                        txtSalariiPrenume.Text = dateAngajat.Prenume;
                        txtSalariiCNP.Text = dateAngajat.CNP;
                    }
                }
                else
                {
                    MessageBox.Show("Nu au fost găsite înregistrări cu ID: " + txtSalariiAngajatID.Text, "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error Message");
            }
        }



        private void Lunile()
        {
            //Implementare Tablou
            //string[] lunile = { "Selecteaza Luna....",  "Ianuarie ", "Februarie ", "Martie", "Aprilie", "Mai ", "Iunie ", "Iulie", "August", "Septembrie",  "Octombrie", "Noiembrie", "Decembrie"};

            //string[] lunile = new string[13];
            //months[0] = "Selecteaza Luna";
            //months[1] = "Ianuarie";
            //months[2] = "Februarie";
            //months[3] = "Martie";
            //months[4] = "Aprilie";
            //months[5] = "Mai";
            //months[6] = "Iunie";
            //months[7] = "Iulie";
            //months[8] = "August";
            //months[9] = "Septembrie";
            //months[10] = "Octombrie";
            //months[11] = "Novembrie";
            //months[12] = "Decembrie";

            //Implementare Lista
            List<string> lunile = new List<string>();
            lunile.Add("Selecteaza Luna....");
            lunile.Add("Ianuarie");
            lunile.Add("Februarie");
            lunile.Add("Martie");
            lunile.Add("Aprilie");
            lunile.Add("Mai");
            lunile.Add("Iunie");
            lunile.Add("Iulie");
            lunile.Add("August");
            lunile.Add("Septembrie");
            lunile.Add("Octobrie");
            lunile.Add("Noiembrie");
            lunile.Add("Decembrie");

            lunile.ForEach(i => cmbLunaDePlata.Items.Add(i));
            lunile.ElementAt(cmbLunaDePlata.SelectedIndex = 0);
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            if (esteValid())
            {

                //Tarif orar ptr. ore suplimentare
                tarifOrarSupl = FrmPontajOre.tarifOrar * 1.5;

                #region ------- Calculare Saptamana 1 ---------
                //Ore contractuale lucrate si castigul aferent sapt 1
                if (FrmPontajOre.totalOreSapt1 <= 40)
                {
                    contrOS1 = FrmPontajOre.totalOreSapt1;  //Ore Contractuale Saptaman 1
                    contrSumaS1 = FrmPontajOre.tarifOrar * contrOS1; //Castig contractual Sapt. 1
                    suplOS1 = 0; //Ore Suplimentare Sapt 1
                    SuplSumaS1 = 0; //Castig suplimentar Sapt 1
                }
                //Ore suplimentare lucrate si castigul aferent sapt 1
                else if (FrmPontajOre.totalOreSapt1 > 40)
                {
                    contrOS1 = 40;
                    contrSumaS1 = FrmPontajOre.tarifOrar * contrOS1; //Castig contractual Sapt. 1
                    suplOS1 = FrmPontajOre.totalOreSapt1 - contrOS1;
                    SuplSumaS1 = suplOS1 * tarifOrarSupl;

                }
                #endregion
                #region ------- Calculare Saptamana 2 ---------
                //Ore contractuale lucrate si castigul aferent sapt 2
                if (FrmPontajOre.totalOreSapt2 <= 40)
                {
                    contrOS2 = FrmPontajOre.totalOreSapt2;  //Ore Contractuale Saptaman 2
                    contrSumaS2 = FrmPontajOre.tarifOrar * contrOS2; //Castig contractual Sapt. 2
                    suplOS2 = 0; //Ore Suplimentare Sapt 2
                    SuplSumaS2 = 0; //Castig suplimentar Sapt 2
                }
                //Ore suplimentare lucrate si castigul aferent sapt 2
                else if (FrmPontajOre.totalOreSapt2 > 40)
                {
                    contrOS2 = 40;
                    contrSumaS2 = FrmPontajOre.tarifOrar * contrOS2; //Castig contractual Sapt. 2
                    suplOS2 = FrmPontajOre.totalOreSapt2 - contrOS2;
                    SuplSumaS2 = suplOS2 * tarifOrarSupl;

                }
                #endregion
                #region ------- Calculare Saptamana 3 ---------
                //Ore contractuale lucrate si castigul aferent sapt 3
                if (FrmPontajOre.totalOreSapt3 <= 40)
                {
                    contrOS3 = FrmPontajOre.totalOreSapt3;  //Ore Contractuale Saptamana 3
                    contrSumaS3 = FrmPontajOre.tarifOrar * contrOS3; //Castig contractual Sapt. 3
                    suplOS3 = 0; //Ore Suplimentare Sapt 3
                    SuplSumaS3 = 0; //Castig suplimentar Sapt 3
                }
                //Ore suplimentare lucrate si castigul aferent sapt 3
                else if (FrmPontajOre.totalOreSapt3 > 40)
                {
                    contrOS3 = 40;
                    contrSumaS3 = FrmPontajOre.tarifOrar * contrOS3; //Castig contractual Sapt. 3
                    suplOS3 = FrmPontajOre.totalOreSapt3 - contrOS3;
                    SuplSumaS3 = suplOS3 * tarifOrarSupl;

                }
                #endregion
                #region ------- Calculare Saptamana 4 ---------
                //Ore contractuale lucrate si castigul aferent sapt 4
                if (FrmPontajOre.totalOreSapt4 <= 40)
                {
                    contrOS4 = FrmPontajOre.totalOreSapt4;  //Ore Contractuale Saptamana 4
                    contrSumaS4 = FrmPontajOre.tarifOrar * contrOS4; //Castig contractual Sapt. 4
                    suplOS4 = 0; //Ore Suplimentare Sapt 4
                    SuplSumaS4 = 0; //Castig suplimentar Sapt 4
                }
                //Ore suplimentare lucrate si castigul aferent sapt 4
                else if (FrmPontajOre.totalOreSapt4 > 40)
                {
                    contrOS4 = 40;
                    contrSumaS4 = FrmPontajOre.tarifOrar * contrOS4; //Castig contractual Sapt. 4
                    suplOS4 = FrmPontajOre.totalOreSapt4 - contrOS4;
                    SuplSumaS4 = suplOS4 * tarifOrarSupl;

                }
                #endregion

                //Calculare total ore si sumele aferente
                totalOreContractuale = contrOS1 + contrOS2 + contrOS3 + contrOS4;
                totalOreSuplimentare = suplOS1 + suplOS2 + suplOS3 + suplOS4;
                totalCastigContractual = contrSumaS1 + contrSumaS2 + contrSumaS3 + contrSumaS4;
                totalCastigSuplimentar = SuplSumaS1 + SuplSumaS2 + SuplSumaS3 + SuplSumaS4;
                totalOreLucrate = totalOreContractuale + totalOreSuplimentare;
                totalCastig = totalCastigContractual + totalCastigSuplimentar;


                //Calculare deduceri
                #region------- Calculare deduceri -------

                if (totalCastig <= 2300)
                {
                    cas = totalCastig * .25;
                    cass = totalCastig * .10;
                    deducerePersonala = DeduceriPersonaleVenit();
                    totalDeduceri = cas + cass + deducerePersonala;
                    impozit = (totalCastig - totalDeduceri) * .10;
                    castigNet = totalCastig - cas - cass - impozit;

                }
                else if (totalCastig > 2300 && totalCastig <= 3600)
                {
                    cas = totalCastig * .25;
                    cass = totalCastig * .10;
                    deducerePersonala = DeduceriPersonaleVenit();
                    totalDeduceri = cas + cass + deducerePersonala;
                    impozit = (totalCastig - totalDeduceri) * .10;
                    castigNet = totalCastig - cas - cass - impozit;
                }
                else if (totalCastig > 3600)
                {
                    cas = totalCastig * .25;
                    cass = totalCastig * .10;
                    deducerePersonala = 0;
                    totalDeduceri = cas + cass + deducerePersonala;
                    impozit = (totalCastig - totalDeduceri) * .10;
                    castigNet = totalCastig - cas - cass - impozit;
                }
                #endregion


                //Afiseaza informatiile salariale in cutiile de text
                txtOreContractuale.Text = totalOreContractuale.ToString("f2");
                txtOreSuplimentare.Text = totalOreSuplimentare.ToString("f2");
                txtTotalOre.Text = totalOreLucrate.ToString("f2");
                txtCastigContractual.Text = totalCastigContractual.ToString("f2");
                txtCastigOreSuplimentare.Text = totalCastigSuplimentar.ToString("f2");
                txtTotalSalariu.Text = totalCastig.ToString("f2");
                txtTarifOreSuplimentare.Text = tarifOrarSupl.ToString("f2");
                txtCAS.Text = cas.ToString("f2");
                txtSanatate.Text = cass.ToString("f2");
                txtDeducerePersonala.Text = deducerePersonala.ToString("f2");
                txtImpozit.Text = impozit.ToString("f2");
                txtTotalDeduceri.Text = totalDeduceri.ToString("f2");
                txtSalariuNet.Text = castigNet.ToString("f2");

            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {

            ProcesareDate inserareSalariu = new ProcesareDate();

            if (esteValid())
            {
                inserareSalariu.InserareSalariu(Convert.ToInt32(txtSalariiAngajatID.Text), txtSalariiNume.Text, txtSalariiPrenume.Text,
                txtSalariiCNP.Text, dtpDataCurenta.Value.ToString("MM/dd/yyyy"), listPerioadaDePlata.SelectedItem.ToString(), cmbLunaDePlata.SelectedItem.ToString(),
                FrmPontajOre.tarifOrar, tarifOrarSupl, OreContractuale, OreSuplimentare, TotalOre, txtCastigContractual.Text, txtCastigOreSuplimentare.Text,
                txtTotalSalariu.Text, txtImpozit.Text, txtCAS.Text, txtSanatate.Text, txtDeducerePersonala.Text, txtTotalDeduceri.Text, txtSalariuNet.Text);

                MessageBox.Show("Angajatul: " + txtSalariiNume.Text + " " + txtSalariiPrenume.Text + " cu ID " +
                txtSalariiAngajatID.Text + " a fost salvat în baza de date cu succes!");

                // TODO: This line of code loads data into the 'calculatorSalariiDataSet1.PlatiSalariu' table. You can move, or remove it, as needed.
                this.platiSalariuTableAdapter.Fill(this.calculatorSalariiDataSet1.PlatiSalariu);

            }

        }

        private bool esteValid()
        {
            if (String.IsNullOrEmpty(txtSalariiAngajatID.Text))
            {
                MessageBox.Show("Te rugăm să introduci ID-ul", "Eroare Date de Intrare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSalariiAngajatID.Focus();

                return false;
            }
            if (listPerioadaDePlata.SelectedIndex == -1)
            {
                MessageBox.Show("Vă rugăm selectați perioda de plată !", "Eroare Date de Intrare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listPerioadaDePlata.Focus();

                return false;
            }
            if (cmbLunaDePlata.SelectedIndex == 0)
            {
                MessageBox.Show("Vă rugăm selectați luna de plată !", "Eroare Date de Intrare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbLunaDePlata.Focus();

                return false;
            }
            return true;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            btnSalveaza.Enabled = true;
            btnCalculeaza.Enabled = true;
            txtSalariiAngajatID.Clear();
            txtSalariiNume.Clear();
            txtSalariiPrenume.Clear();
            txtSalariiCNP.Clear();
            txtOreContractuale.Clear();
            txtOreSuplimentare.Clear();
            txtCastigContractual.Clear();
            txtCastigOreSuplimentare.Clear();
            txtDeducerePersonala.Clear();
            txtImpozit.Clear();
            txtCAS.Clear();
            txtSanatate.Clear();
            txtTarifOreSuplimentare.Clear();
            txtTotalDeduceri.Clear();
            txtTotalOre.Clear();
            txtTotalSalariu.Clear();
            listPerioadaDePlata.SelectedIndex = 0;
            cmbLunaDePlata.SelectedIndex = 0;
            txtSalariuNet.Clear();
        }

   

        #region --------- Deduceri Personale Venit ---------
        public int DeduceriPersonaleVenit()
        {
            int deducerePersonalaVenit = 0;

            if (totalCastig >= 1 && totalCastig < 1950)
                deducerePersonalaVenit = 510;
            else if (totalCastig >= 1951 && totalCastig < 2000)
                deducerePersonalaVenit = 495;
            else if (totalCastig >= 2001 && totalCastig < 2050)
                deducerePersonalaVenit = 480;
            else if (totalCastig >= 2051 && totalCastig < 2100)
                deducerePersonalaVenit = 465;
            else if (totalCastig >= 2101 && totalCastig < 2150)
                deducerePersonalaVenit = 450;
            else if (totalCastig >= 2151 && totalCastig < 2200)
                deducerePersonalaVenit = 435;
            else if (totalCastig >= 2201 && totalCastig < 2250)
                deducerePersonalaVenit = 420;
            else if (totalCastig >= 2251 && totalCastig < 2300)
                deducerePersonalaVenit = 405;
            else if (totalCastig >= 2301 && totalCastig < 2350)
                deducerePersonalaVenit = 390;
            else if (totalCastig >= 2351 && totalCastig < 2400)
                deducerePersonalaVenit = 375;
            else if (totalCastig >= 2401 && totalCastig < 2450)
                deducerePersonalaVenit = 360;
            else if (totalCastig >= 2451 && totalCastig < 2500)
                deducerePersonalaVenit = 345;
            else if (totalCastig >= 2501 && totalCastig < 2550)
                deducerePersonalaVenit = 330;
            else if (totalCastig >= 2551 && totalCastig < 2600)
                deducerePersonalaVenit = 315;
            else if (totalCastig >= 2601 && totalCastig < 2650)
                deducerePersonalaVenit = 300;
            else if (totalCastig >= 2651 && totalCastig < 2700)
                deducerePersonalaVenit = 285;
            else if (totalCastig >= 2701 && totalCastig < 2750)
                deducerePersonalaVenit = 270;
            else if (totalCastig >= 2751 && totalCastig < 2800)
                deducerePersonalaVenit = 255;
            else if (totalCastig >= 2801 && totalCastig < 2850)
                deducerePersonalaVenit = 240;
            else if (totalCastig >= 2851 && totalCastig < 2900)
                deducerePersonalaVenit = 225;
            else if (totalCastig >= 2901 && totalCastig < 2950)
                deducerePersonalaVenit = 210;
            else if (totalCastig >= 2951 && totalCastig < 3000)
                deducerePersonalaVenit = 195;
            else if (totalCastig >= 3001 && totalCastig < 3050)
                deducerePersonalaVenit = 180;
            else if (totalCastig >= 3051 && totalCastig < 3100)
                deducerePersonalaVenit = 165;
            else if (totalCastig >= 3101 && totalCastig < 3150)
                deducerePersonalaVenit = 150;
            else if (totalCastig >= 3151 && totalCastig < 3200)
                deducerePersonalaVenit = 135;
            else if (totalCastig >= 3201 && totalCastig < 3250)
                deducerePersonalaVenit = 120;
            else if (totalCastig >= 3251 && totalCastig < 3300)
                deducerePersonalaVenit = 105;
            else if (totalCastig >= 3301 && totalCastig < 3350)
                deducerePersonalaVenit = 90;
            else if (totalCastig >= 3351 && totalCastig < 3400)
                deducerePersonalaVenit = 75;
            else if (totalCastig >= 3401 && totalCastig < 3450)
                deducerePersonalaVenit = 60;
            else if (totalCastig >= 3451 && totalCastig < 3500)
                deducerePersonalaVenit = 45;
            else if (totalCastig >= 3501 && totalCastig < 3550)
                deducerePersonalaVenit = 30;
            else if (totalCastig >= 3551 && totalCastig < 3600)
                deducerePersonalaVenit = 15;

            return deducerePersonalaVenit;
        }
        #endregion
    }
}
