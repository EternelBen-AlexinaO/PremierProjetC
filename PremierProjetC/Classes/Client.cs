using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public sealed class Client:Participant
    {
    public Client(string civilite, string nom, string prenom, DateTime dateNaissance, int numeroVoie, string nomVoie, string ville, string pays )
        {
            Civilite = civilite;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            NumeroVoie = numeroVoie;
            NomVoie = nomVoie;
            Ville = ville;
            Pays = pays;
        }
    public List<DossierReservation> DossierReservations { get; set; }
    public List<Accompagnant> Accompagnants { get; set; }
    }
}
