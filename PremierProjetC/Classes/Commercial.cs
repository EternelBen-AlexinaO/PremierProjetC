using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class Commercial
    {
        public Commercial()
        {
            Nom = "Nom Commercial";
            Prenom = "Prénom";
            UserName = "UserCom";
            UserPassword = "Password";

        }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public List<Voyage>Voyages { get; set; }
        public List<Participant> Participants { get; set; }
        public List<DossierReservation>Dossiers { get; set; }
        
        
    }
}
