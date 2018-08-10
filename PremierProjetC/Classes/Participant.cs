using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public abstract class Participant
    {
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public Adresse AdresseParticipant { get; set; }

    }
}
