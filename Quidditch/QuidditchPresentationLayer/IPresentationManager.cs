using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayer
{
    /// <summary>
    /// Définition de la présentationManager
    /// </summary>
    public interface IPresentationManager
    {
        /// <summary>
        /// Permet d'afficher toutes les coupes
        /// </summary>
        void DisplayAllCoupes();

        /// <summary>
        /// Permet d'afficher tous les matches prévus ordonné par ordre croissant sur les dates
        /// </summary>
        void DisplayMatchesExpectedOrderByDate();

        /// <summary>
        /// Affiche tous les stades dont au moins un match s'est joué ou se jouera
        /// </summary>
        void DisplayStadesWhereOneOrMoreMatchIsExpected();

        /// <summary>
        /// Affiche tous les joueurs qui sont des attrapeurs et qui ont joués à domicile
        /// </summary>
        void DisplayPlayersWhoIsAttrapeurAndTheyPlayedAtHome();

        /// <summary>
        /// Affiche les joueurs qui sont gardien et qui sont plus jeune que 17 ans
        /// </summary>
        void DisplayPlayerWhoIsGardienAndTheyAreYoungerThanSeventeen();
    }
}
