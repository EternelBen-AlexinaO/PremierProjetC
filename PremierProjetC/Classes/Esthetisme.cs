using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class Esthetisme
    {
    //Methode pour mettre le texte de la couleur voulue et centrer ou non le texte
    public static void MiseEnFormeTexte(string message, ConsoleColor couleur=ConsoleColor.Gray, bool centre=false)
        {
            Console.ForegroundColor = couleur;
            if (centre)
            {
                int nbEspaces = (Console.WindowWidth - message.Length) / 2;
                Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            }
            Console.WriteLine(message);
            Console.ResetColor();
        }



    }
}
