using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Medicament
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUMEMedicament = 1;
        private const int CANTITATE = 2;

        public string numeMedicament;
        public int cantitate;
        public int idMedicament; //identificator unic medicament

        //Constructor cu parametrii
        public Medicament(int idMedicament, string numeMedicament, int cantitate)
        {
            this.idMedicament = idMedicament;
            this.numeMedicament = numeMedicament;
            this.cantitate = cantitate;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Medicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idMedicament = Convert.ToInt32(dateFisier[ID]);
            numeMedicament = dateFisier[NUMEMedicament];
            cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectMedicamentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idMedicament.ToString(),
                (numeMedicament ?? " NECUNOSCUT "),
                cantitate.ToString());

            return obiectMedicamentPentruFisier;
        }
        public int GetIdMedicament()
        {
            return idMedicament;
        }

        public string GetNumeMedicament()
        {
            return numeMedicament;
        }

        public int GetCantitate()
        {
            return cantitate;

        }
    }
}