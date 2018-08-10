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
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE", ConsoleColor.DarkBlue, centre: true);
            Esthetisme.MiseEnFormeTexte("Veuillez vous identifier", centre: false);
            
        }
        
     }
}
