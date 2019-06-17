using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class Participant
    {
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public Adresse AdresseParticipant { get; set; } // n'arrivant pas à l'utiliser, nous n'utilisons pas ce type
        public int NumeroVoie { get; set; }
        public string NomVoie { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Email { get; set; }
    }
}
