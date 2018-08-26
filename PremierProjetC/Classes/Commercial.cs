using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class Commercial
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public override string ToString()
        {
            // return $"{Nom} {Prenom} {UserName} {UserPassword} ";
            /// Notre liste de commerciaux, ne contient pour le moment que des userName et des UserPassword
            return $"{UserName} {UserPassword} ";

        }

        public List<Voyage>Voyages { get; set; }
        public List<Participant> Participants { get; set; }
        public List<DossierReservation>Dossiers { get; set; }
        
        
    }
}
