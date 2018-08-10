using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC
{
    public sealed class Voyage
    {
        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public double PrixAgence { get; set; }
        public int NbPlacesDisponibles { get; set; }
        public Destination Destination { get; set; }

    }
}
