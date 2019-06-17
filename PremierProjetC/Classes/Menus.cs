using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetC.Classes
{
    public class Menus
    {
        public static void PageAccueil()
        {
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER - BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("Cette application permet de gérer les voyages et les clients de BoVoyage\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("Page intranet dédié à la gestion de notre clientele.\nLa manipulation de vos dossiers client et ainsi que la gestion de vos dossiers voyages sera facilité.\n\nEn cas de difficultée, veuillez prendre contact avec notre service d'administration réseau.\n\nSite intranet fournit par AxT@Tech.com\n\n", ConsoleColor.DarkGray, centre: false);
            Esthetisme.MiseEnFormeTexte("Veuillez commencer par vous identifier\n",ConsoleColor.White, centre: true);

            Esthetisme.MiseEnFormeTexte("Votre nom Utilisateur :",ConsoleColor.Yellow, centre: false);
            var userConnexionName = Console.ReadLine();

            Esthetisme.MiseEnFormeTexte("Ainsi que votre Mot de Passe: ", ConsoleColor.Yellow, centre: false);
            var userConnexionPassword = Console.ReadLine();

            //var UserConnexionName = Listes<Commercial> Commercial.UserName();
            bool connexionEntries = Convert.ToBoolean(userConnexionName + userConnexionPassword);

            //var connexion = List<Commercial> Commercial { set userName ;};
            //var connexion == Commercial.UserName && Commercial.UserPassword;

            if (connexionEntries) //creer une methode connexionEntries avec username and userpassword comme paramètre de retour afin de verifier ensuite l'égalité via un boolean ensuite
            {
                MenuGestionCommerciale();
            }
            else
            {
                Esthetisme.MiseEnFormeTexte("MAUVAIS IDENTIFIANTS\n\n", ConsoleColor.Red, centre: false);
                Esthetisme.MiseEnFormeTexte("Vous n'avez pas accès. L'application va se fermer\n\n", ConsoleColor.Red, centre: false);
            }
            Console.Clear();
        }

        public static string MenuGestionCommerciale()
        {
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("Connexion réussie\n\n", ConsoleColor.Red, centre: false);

            Esthetisme.MiseEnFormeTexte("MENU\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Gestion des voyages", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Gestion des clients", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            var gesCommerciale = Console.ReadLine();

            switch (gesCommerciale)
            {
                case "1":
                    MenuGestionVoyages();
                    break;

                case "2":
                    MenuGestionClients();
                    break;

                case "q":
                case "Q":
                    break;
                default:
                    Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                    break;
            }
            return gesCommerciale;
        }

        public static string MenuGestionVoyages()
        {
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

            var gesVoyage = Console.ReadLine();

            switch (gesVoyage)
            {//En attente de création de commande pour recuperer les listes
                case "1":
                    ListeDossierEnAttente();
                    break;

                case "2":
                    ListeDossiersEnCours();
                    break;

                case "3":
                    ListeDossiersRefusé();
                    break;

                case "4":
                    ListeDossiersAcceptés();
                    break;

                case "5":
                    ListeDesVoyages();
                    break;

                case "r":
                case "R":
                    MenuGestionCommerciale();
                    break;

                case "q":
                case "Q":
                    break;
                default:
                    Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                    break;
            }
            return Console.ReadLine();
        }

        public static string MenuGestionClients()
        {
            Esthetisme.MiseEnFormeTexte("APPLICATION METIER DE BO VOYAGE\n\n", ConsoleColor.DarkCyan, centre: true);
            Esthetisme.MiseEnFormeTexte("GESTION DES CLIENTS\n", centre: false);
            Esthetisme.MiseEnFormeTexte("1. Voir la liste des clients", centre: false);
            Esthetisme.MiseEnFormeTexte("2. Rechercher un client", centre: false);
            Esthetisme.MiseEnFormeTexte("3. Créer un client", centre: false);
            Esthetisme.MiseEnFormeTexte("4. Supprimer un client", centre: false);
            Esthetisme.MiseEnFormeTexte("R. Revenir au menu gestion commerciale", centre: false);
            Esthetisme.MiseEnFormeTexte("Q. Quitter\n\n", centre: false);
            Esthetisme.MiseEnFormeTexte("Faites votre choix:", centre: false);

            var gesDesClients = Console.ReadLine();

            switch (gesDesClients)
            {// En attente de la commande qui recuperera les donnees dans la liste
                case "1":
                    VoirListeDesClients();
                    break;

                case "2":
                    RechercherUnClient();
                    break;

                case "3":
                    CreerUnClient();
                    break;

                case "4":
                    SupprimerClient();
                    break;

                case "r":
                case "R":
                    MenuGestionCommerciale();
                    break;

                case "q":
                case "Q":
                    break;
                default:
                    Esthetisme.MiseEnFormeTexte("Choix invalide, l'application va fermer", ConsoleColor.Red, centre: false);
                    break;
            }
            return Console.ReadLine();
        }
    }
}