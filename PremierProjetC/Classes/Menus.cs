using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class Menus
    {
        //Methode pour page d'accueil/authentification
        public static void PageAccueil()
        {
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("Cette application permet de gérer les voyages et les clients de BoVoyage\n\n", ConsoleColor.DarkCyan, centre: false);
            Esthetisme.MiseEnFormeTexte("Veuillez vous identifier\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Nom Utilisateur:", centre: false);
            Console.ReadLine();
            Esthetisme.MiseEnFormeTexte("Mot de Passe: ", centre: false);
            Console.ReadLine();
        }
        
     }
}
