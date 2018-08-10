using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PremierProjetC.Classes
{
    class GestionDonnees
    {
        public static List<Participant>LireFichier()
        {
            const string CheminFichierParticipants = "Participants.txt";
            const char SeparateurChamps = ';';

            var participants = new List<Participant>();
            if (File.Exists(CheminFichierParticipants))
            {
                var lignes = File.ReadAllLines(CheminFichierParticipants);
                foreach (var ligne in lignes)
                {
                    var champs = ligne.Split(SeparateurChamps);
                    var participant = new Participant();
                    participant.Civilite = champs[0];
                    participant.Nom = champs[1];
                    participant.Prenom = champs[2];
                    participant.DateNaissance = DateTime.Parse(champs[3]);
                    participant.NumeroVoie = int.Parse(champs[4]);
                    participant.NomVoie = champs[5];
                    participant.Ville = champs[6];
                    participant.Pays = champs[7];

                    participants.Add(participant);
                }
            }
            return participants;
        }


    }
}
