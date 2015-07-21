using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayer
{
    /// <summary>
    /// Implémentation de MenuManager avec la console
    /// </summary>
    internal class ConsoleMenuManager : IMenuManager
    {
        #region Fields

        /// <summary>
        /// Impélmentation de IPresentationManager utilisée
        /// </summary>
        private IPresentationManager _presentationManager;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur de ConsoleMenuManager, avec injection de l'implémentation de IPresentationManager
        /// </summary>
        /// <param name="presentationManager">Injection de la dépendance sur l'implémentation de IPresentationManager</param>
        public ConsoleMenuManager(IPresentationManager presentationManager)
        {
            this._presentationManager = presentationManager;
        }

        #endregion

        #region Operations

        /// <summary>
        /// Permet d'afficher le menu dans la console
        /// </summary>
        private void DisplayMenu()
        {
            Console.WriteLine("Bienvenue dans l'application de gestion de Quidditch");
            Console.WriteLine("Que voulez-vous faire ? (Saisissez un chiffre et appuyer sur entrée");
            Console.WriteLine("1: Afficher toutes les coupes");
            Console.WriteLine("2: Afficher les matches prévus par date de début");
            Console.WriteLine("3: Afficher les stades pour lesquels au moins un match est programmé");
            Console.WriteLine("4: Afficher les joueurs jouant au poste d'attrapeur ayant joués à domicile");
            Console.WriteLine("5: Afficher les joueurs jouant au poste de gardien ayant moins de 17 ans");
            Console.WriteLine("0: Quitter");
        }

        /// <summary>
        /// Permet de récupérer le choix de l'utilisateur
        /// </summary>
        public void GetChoiceFromUser()
        {
            string dataWritten;
            bool isDisplayMenu = true;
            do
            {
                DisplayMenu();
                dataWritten = Console.ReadLine();
                isDisplayMenu = DoActionFromChoice(dataWritten );
            } while (isDisplayMenu);
        }

        /// <summary>
        /// Permet d'effectuer les actions avec le choix de l'utilisateur
        /// </summary>
        /// <param name="dataWritten">Caractère saisi par l'utilisateur</param>
        /// <returns>Vrai si le menu doit être réafficher, faux si non</returns>
        private bool DoActionFromChoice(string dataWritten)
        {
            switch (dataWritten)
            {
                case "1":
                    _presentationManager.DisplayAllCoupes();
                    break;
                case "2":
                    _presentationManager.DisplayMatchesExpectedOrderByDate();
                    break;
                case "3":
                    _presentationManager.DisplayStadesWhereOneOrMoreMatchIsExpected();
                    break;
                case "4":
                    _presentationManager.DisplayPlayersWhoIsAttrapeurAndTheyPlayedAtHome();
                    break;
                case "5":
                    _presentationManager.DisplayPlayerWhoIsGardienAndTheyAreYoungerThanSeventeen();
                    break;
                case "0":
                    return false;
                default:
                    break;
            }
            return true;
        }

        #endregion
    }
}
