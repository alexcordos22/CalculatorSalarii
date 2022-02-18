using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorSalarii
{
    public class ProcesareDate
    {
        public void InserareAngajati(int id, string cnp, string nume, string prenume, string DataN,
            string gen, string adresa, string localitatea, string judet, string codpostal, string telefon,
            string email, string numefisier, byte[] imagine)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection
                (Conectare.ConSir("AngajatiDB")))
            {
                List<DateAngajati> obAngajati = new List<DateAngajati>();

                obAngajati.Add(new DateAngajati
                {
                    AngajatID = id,
                    CNP = cnp,
                    Nume = nume,
                    Prenume = prenume,
                    DataNasterii = DataN,
                    Gen = gen,
                    Adresa = adresa,
                    Localitatea = localitatea,
                    Judet = judet,
                    CodPostal = codpostal,
                    Telefon = telefon,
                    Email = email,
                    NumeFisier = numefisier,
                    Imagine = imagine
                });

                conectare.Execute("AdaugareAngajati @AngajatID, @Nume, @Prenume, @Gen, @CNP, @DataNasterii, " +
                    "@Adresa, @Localitatea, @CodPostal, @Judet, @Telefon, @Email, @NumeFisier, @Imagine",
                     obAngajati);

                conectare.Close();
            }
        }

        public void ActualizareAngajat(int id, string cnp, string nume, string prenume, string DataN,
            string gen, string adresa, string localitatea, string judet, string codpostal, string telefon,
            string email, string numefisier, byte[] imagine)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection(Conectare.ConSir
                ("AngajatiDB")))
            {
                List<DateAngajati> obAngajati = new List<DateAngajati>();

                obAngajati.Add(new DateAngajati
                {
                    AngajatID = id,
                    CNP = cnp,
                    Nume = nume,
                    Prenume = prenume,
                    DataNasterii = DataN,
                    Gen = gen,
                    Adresa = adresa,
                    Localitatea = localitatea,
                    Judet = judet,
                    CodPostal = codpostal,
                    Telefon = telefon,
                    Email = email,
                    NumeFisier = numefisier,
                    Imagine = imagine
                });

                conectare.Execute("ActualizareAngajat @AngajatID, @Nume, @Prenume, @Gen, @CNP, @DataNasterii, " +
                    "@Adresa, @Localitatea, @CodPostal, @Judet, @Telefon, @Email, @NumeFisier, @Imagine",
                    obAngajati);
                conectare.Close();
            }
        }

        public void StergereAngajat(int id)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection
                (Conectare.ConSir("AngajatiDB")))
            {
                DateAngajati StergereAngajat = new DateAngajati { AngajatID = id };

                conectare.Execute("StergereAngajat @AngajatID", StergereAngajat);
                conectare.Close();
            }
        }

        public List<DateAngajati> CautareAngajat(int angajatID)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection
                (Conectare.ConSir("AngajatiDB")))
            {
                if (conectare.State == ConnectionState.Closed)
                    conectare.Open();
                var output = conectare.Query<DateAngajati>("CautareAngajat @AngajatID",
                    new { AngajatID = angajatID }).ToList();

                conectare.Close();

                return output;
            }
        }

        public void InserareSalariu(int angajatID, string nume, string prenume, string cnp, string dataplatii,
            string perioadaPlata, string lunaPlata, double tarifOrar, double tarifOreSuplimentare, double oreContract, double oreSuplimentare, double totalOre,
            string salariuOreContract, string salariuOreSuplimentare, string salariuBrut, string impozitVenit, string cas, string cass,
            string deducerePersonala, string totalDeducere, string salariuNet)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection
                (Conectare.ConSir("AngajatiDB")))
            {
                List<DatePlataSalarii> obPlataSalarii = new List<DatePlataSalarii>();

                try
                {
                    obPlataSalarii.Add(new DatePlataSalarii
                    {
                        AngajatID = angajatID,
                        Nume = nume,
                        Prenume = prenume,
                        CNP = cnp,
                        DataPlatii = dataplatii,
                        PerioadaPlata = perioadaPlata,
                        LunaPlata = lunaPlata,
                        TarifOrar = tarifOrar,
                        TarifOreSuplimentare = tarifOreSuplimentare,
                        OreContract = oreContract,
                        OreSuplimentare = oreSuplimentare,
                        TotalOre = totalOre,
                        SalariuOreContract = salariuOreContract,
                        SalariuOreSuplimentare = salariuOreSuplimentare,
                        SalariuBrut = salariuBrut,
                        ImpozitVenit = impozitVenit,
                        CAS = cas,
                        CASS = cass,
                        DeducerePersonala = deducerePersonala,
                        TotalDeducere = totalDeducere,
                        SalariuNet = salariuNet

                    });

                    conectare.Execute("AdaugarePlataSalariu @AngajatID, @Nume, @Prenume, @CNP, @DataPlatii, @PerioadaPlata," +
                        " @LunaPlata, @TarifOrar, @TarifOreSuplimentare, @OreContract, @OreSuplimentare, @TotalOre, @SalariuOreContract, " +
                        "@SalariuOreSuplimentare, @SalariuBrut, @ImpozitVenit, @CAS, @CASS, @DeducerePersonala, @TotalDeducere, @SalariuNet", obPlataSalarii);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare" + ex.Message);
                }
                finally
                {
                    conectare.Close();
                }

            }
        }

        public List<DatePlataSalarii> CautarePlata(string nume)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection
                (Conectare.ConSir("AngajatiDB")))
            {
                if (conectare.State == ConnectionState.Closed)
                    conectare.Open();
                var output = conectare.Query<DatePlataSalarii>("CautarePlataSalariu @Nume",
                    new { Nume = nume }).ToList();

                conectare.Close();

                return output;
            }
        }

    }
}
