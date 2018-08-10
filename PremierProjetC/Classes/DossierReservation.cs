using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public sealed class DossierReservation
    {
        public int NumeroDossier { get; set; }
        public int NbParticipants { get; set; }

        public List<Commercial>Commeerciaux { get; set; }
        public List<Participant>Participants { get; set; }
        public List<Promotion>Promotions { get; set; }

        public double CalculerPrixTotal() //Methode qui devra calculer le prix total en prenant en compte les tarifs promotionnels suivant l'âge des participants
    }
}
