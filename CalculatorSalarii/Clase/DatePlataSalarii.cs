using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSalarii
{
    public class DatePlataSalarii
    {
        public int PlataSalariuID { get; set; }
        public int AngajatID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string DataPlatii { get; set; }
        public string PerioadaPlata { get; set; }
        public string LunaPlata { get; set; }
        public double TarifOrar { get; set; }
        public double TarifOreSuplimentare { get; set; }
        public double OreContract { get; set; }
        public double OreSuplimentare { get; set; }
        public double TotalOre { get; set; }
        public string SalariuOreContract { get; set; }
        public string SalariuOreSuplimentare { get; set; }
        public string SalariuBrut { get; set; }
        public string ImpozitVenit { get; set; }
        public string CAS { get; set; }
        public string CASS { get; set; }
        public string DeducerePersonala { get; set; }
        public string TotalDeducere { get; set; }
        public string SalariuNet { get; set; }

    }
}