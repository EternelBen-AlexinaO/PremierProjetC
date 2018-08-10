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
            var userName=Console.ReadLine();
            Esthetisme.MiseEnFormeTexte("Mot de Passe: ", centre: false);
            Console.ReadLine();
            var userPassword = Console.ReadLine();
            var commercial = new Commercial(); 
            if (userName == commercial.UserName && userPassword==commercial.UserPassword)
            {
                MenuGestionCommerciale();
            }
            else
            {
                Esthetisme.MiseEnFormeTexte("MAUVAIS IDENTIFIANTS\n\n", ConsoleColor.Red, centre: false);
                Esthetisme.MiseEnFormeTexte("Vous n'avez pas accès. L'application va se fermer\n\n", ConsoleColor.Red, centre: false);

            }
        }

        public static string MenuGestionCommerciale()
        {
            Console.Clear();
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("Connexion réussie\n\n", ConsoleColor.Red, centre: false);
            Esthetisme.MiseEnFormeTexte("MENU\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Gestion des voyages", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Gestion des clients", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            return Console.ReadLine();
        }

        public static string MenuGestionVoyages()
        {
            Console.Clear();
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("GESTION DES VOYAGES\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Voir les dossiers en attente", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Voir les dossiers en cours", centre: false);
            Esthetisme.MiseEnFormeTexte("3. Voir les dossiers refusés", centre: false);
            Esthetisme.MiseEnFormeTexte("4. Voir les dossiers acceptés", centre: false);
            Esthetisme.MiseEnFormeTexte("5. Voir la liste des voyages", centre: false);
            Esthetisme.MiseEnFormeTexte("R. Revenir au menu précédent", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            return Console.ReadLine();
        }

        public static string MenuGestionClients()
        {
            Console.Clear();
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("GESTION DES CLIENTS\n",centre: false);
            Esthetisme.MiseEnFormeTexte("1. Voir la liste des clients", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Rechercher un client", centre: false);
            Esthetisme.MiseEnFormeTexte("3. Créer un client", centre: false);
            Esthetisme.MiseEnFormeTexte("4. Supprimer un client", centre: false);
            Esthetisme.MiseEnFormeTexte("R. Revenir au menu précédent", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            return Console.ReadLine();
        }



    }
}
