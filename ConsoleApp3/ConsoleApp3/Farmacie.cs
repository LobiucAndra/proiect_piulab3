using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Farmacie
    {
        public string numeFarmacie;
        public List<Medicament> medicamente = new List<Medicament>();

        public void AdaugMed(string numeMedicament,int cantitate,int idMedicament) 
        {
            Medicament new_medicament = new Medicament(idMedicament,numeMedicament,cantitate);

            medicamente.Add(new_medicament);

        }
        public void AdaugMed(Medicament medicament) 
        {
            medicamente.Add(medicament);

        }


        public void AfisareListaMed() 
        {
            for(int i=0;i<medicamente.Count;i++)
            {
                Console.WriteLine($"NUME: {medicamente[i].numeMedicament},CANTITATE: {medicamente[i].cantitate}");

            }
        }

        public void Afisare_Lista_Medicamente()
        {
            foreach( Medicament medicam in this.medicamente)
            {
                Console.WriteLine($"{medicam.idMedicament},{medicam.numeMedicament},{medicam.cantitate}");
            }
        }

        public void Cauta_Medicament_Dupa_Nume(string numeMedicament)
        {
            foreach (Medicament med in this.medicamente)
            {
                if (med.numeMedicament == numeMedicament)
                { 
                Console.WriteLine($"{med.idMedicament},{med.numeMedicament},{med.cantitate}");
                    return;
                }
            }
            Console.WriteLine("Nu s-a gasit acest medicament!");
            
        }

        public void Cauta_Medicament_Cantitate(int cantitate)
        {
            foreach (Medicament med in this.medicamente)
            {
                if (med.cantitate == cantitate)
                {
                    Console.WriteLine($"{med.idMedicament},{med.numeMedicament},{med.cantitate}");
                    return;
                }
            }
            Console.WriteLine("Nu s-a gasit acest medicament!");

        }
    }
}
