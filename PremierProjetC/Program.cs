using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //permet l'utilisation de recherche de fichier dans le system lors de l'apl de fonction List<FileInfo> Files { get; set; }

namespace PremierProjetC //renommer le nom du Proj suivant le projet donné
{
    class Program // renommer la classe Program par le nom de la classe principal qui identifira le nom du programme à creer et qui servira de point d'entrée via le Main. 
    {
        static void Main(string[] args)
        {
            Classes.Menus.PageAccueil();

            Console.ReadKey();
        }
    }
}
