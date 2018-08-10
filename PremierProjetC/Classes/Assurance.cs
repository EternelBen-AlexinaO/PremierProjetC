using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public abstract class Assurance
    {
        public string NomCie { get; set; }

        public List<DossierReservation>DossierReservations { get; set; }
        
    }
}
