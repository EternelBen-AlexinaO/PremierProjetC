using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierProjetC.Classes; // permet l'utilisation des classes créées dans le projet ; cf la variable "var mGesCial"
//using System.IO; //classe system permetant le traitement de données en entrée et sortie lors de l'apl de fonction List<FileInfo> Files et accessible via get et nu set | { get; set; }

namespace PremierProjetC //renommer le nom du Proj suivant le projet donné
{
    class Program
    {
        static void Main(string[] args)
        {
          Classes.Menus.PageAccueil();

            bool continuer = true;
            while (continuer)
            {
                var mGesCial = MenuGestionCommerciale();
                switch (mGesCial)
                {
                    case "1":
                        MenuGestionVoyages();
                        break;

                    case "2":
                        MenuGestionClients();
                        break;

                    case "q":
                    case "Q":
                        continuer = false;
                        break;

                    default:
                        Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                        continuer = false;
                        break;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
