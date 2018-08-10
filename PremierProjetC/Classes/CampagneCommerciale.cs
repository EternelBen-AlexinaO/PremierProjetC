using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public abstract class CampagneCommerciale
    {
        public string NomCampagne { get; set; }

        public List<Participant>Participants { get; set; }

    }
}
