using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC
{
    public sealed class Destination
    {
        public string Continent { get; set; }
        public string Pays { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }

        public List<Voyage>Voyages { get; set; }
    }
}
