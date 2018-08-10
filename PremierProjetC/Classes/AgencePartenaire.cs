using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class AgencePartenaire
    {
        public string NomAgence { get; set; }
        public string NumeroTelephone { get; set; }
        public string NumeroSiret { get; set; }
        public string Email { get; set; }

        public List<Voyage> Voyages { get; set }
    }
}
