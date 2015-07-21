using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Classe permettant de créer une instance des classes implémentant IMatch
    /// </summary>
    internal static class FabriqueMatch
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IMatch
        /// </summary>
        /// <param name="identifiant">Identifiant du match sous forme de chaîne de caractères</param>
        /// <param name="dateMatch">Date du match</param>
        /// <param name="arbitre">Arbitre du match</param>
        /// <param name="stade">Stade du match</param>
        /// <param name="reservations">Réservations faites pour le match</param>
        /// <param name="equipeDomicile">L'équipe jouant à domicile</param>
        /// <param name="equipeVisiteur">L'équipe jouant en tant que visiteur</param>
        /// <param name="scoreDomicile">Score de l'équipe à domicile</param>
        /// <param name="scoreVisiteur">Score de l'équipe visiteur</param>
        /// <returns>L'instance d'un match</returns>
        public static IMatch CreerMatch(string identifiant, string dateMatch, IArbitre arbitre, IStade stade, 
            IList<IReservation> reservations, IEquipe equipeDomicile, IEquipe equipeVisiteur, string scoreDomicile, string scoreVisiteur)
        {
            return new Match(Convert.ToInt32(identifiant), Convert.ToDateTime(dateMatch), arbitre, stade, 
                reservations, equipeDomicile, equipeVisiteur,
                Convert.ToInt32(scoreDomicile), Convert.ToInt32(scoreVisiteur));
        }

        #endregion
    }
}
