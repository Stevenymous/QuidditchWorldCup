using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchBusinessLayer;

namespace QuidditchPresentationLayer
{
    /// <summary>
    /// Implémentation du IPresentationManager permettant de gérer la console
    /// </summary>
    internal class ConsolePresentationManager : IPresentationManager
    {
        #region Fields

        /// <summary>
        /// Référence au business
        /// </summary>
        private IBusinessManager _businessManager;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur de la l'instance de ConsolePresentationManager
        /// </summary>
        public ConsolePresentationManager()
        {
            _businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
        }

        #endregion

        #region Operations

        /// <summary>
        /// Permet d'afficher toutes les coupes
        /// </summary>
        public void DisplayAllCoupes()
        {
            IList<string> coupesToDisplay = _businessManager.GetAllCoupesString();
            coupesToDisplay.ToList().ForEach(coupe => Console.WriteLine(coupe));
        }

        /// <summary>
        /// Permet d'afficher tous les matches prévu ordonné par ordre croissantn sur les dates
        /// </summary>
        public void DisplayMatchesExpectedOrderByDate()
        {
            IList<string> matchesToDisplay = _businessManager.GetMatchsExpectedOrderByDate();
            matchesToDisplay.ToList().ForEach(match => Console.WriteLine(match));
        }

        /// <summary>
        /// Affiche tous les stades dont au moins un match s'est joué ou se jouera
        /// </summary>
        public void DisplayStadesWhereOneOrMoreMatchIsExpected()
        {
            IList<string> stadesToDisplay = _businessManager.GetStadeWhereAtLeastOneMatchIsExpected();
            stadesToDisplay.ToList().ForEach(stade => Console.WriteLine(stade));
        }

        /// <summary>
        /// Affiche tous les joueurs qui sont des attrapeurs et qui ont joués à domicile
        /// </summary>
        public void DisplayPlayersWhoIsAttrapeurAndTheyPlayedAtHome()
        {
            IList<string> joueursToDisplay = _businessManager.GetJoueursWhoBeCatcherAndPlayedAtHome();
            joueursToDisplay.ToList().ForEach(joueur => Console.WriteLine(joueur));
        }

        /// <summary>
        /// Affiche les joueurs qui sont gardien et qui sont plus jeune que 17 ans
        /// </summary>
        public void DisplayPlayerWhoIsGardienAndTheyAreYoungerThanSeventeen()
        {
            IList<string> joueursToDisplay = _businessManager.GetJoueursWhoBeGardienAndBeYoungerThanSeventeen();
            joueursToDisplay.ToList().ForEach(joueur => Console.WriteLine(joueur));
        }

        #endregion
    }
}
