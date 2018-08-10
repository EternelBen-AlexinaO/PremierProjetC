using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class Adresse
    {
        public int NumeroVoie { get; set; }
        public string NomVoie { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }

        //Methode pour retourner l'adresse (en attente)
        //public static string EcrireAdresse(int numeroVoie, string nomVoie, int codePostal, string ville, string pays)
        //{

        //}
    }
}
