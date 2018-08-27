using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permet l'utilisation de recherche de fichier dans le system lors de l'apl de fonction List<FileInfo> Files { get; set; }

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
                var mGesCial = Classes.Menus.MenuGestionCommerciale();
                switch (mGesCial)
                {
                    case "1":
                        Classes.Menus.MenuGestionVoyages();
                        break;

                    case "2":
                        Classes.Menus.MenuGestionClients();
                        break;
                    case "q":
                    case "Q":
                        continuer = false;
                        break;
                    default:
                        Classes.Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                        continuer = false;
                        break;
                }

            }
            Console.ReadKey();
            Console.Clear();
         }
    }
}
