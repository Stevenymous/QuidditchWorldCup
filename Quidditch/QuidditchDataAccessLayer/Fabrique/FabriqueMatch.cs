using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
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
        /// <returns>L'instance d'un match</returns>
        public static IMatch CreerMatch(int identifiant, string dateMatch, IArbitre arbitre, IStade stade, 
            IList<IReservation> reservations, IEquipe equipeDomicile, IEquipe equipeVisiteur, int scoreDomicile, int scoreVisiteur)
        {
            return new Match(identifiant, Convert.ToDateTime(dateMatch), arbitre, stade, reservations, equipeDomicile, equipeVisiteur,
                scoreDomicile, scoreVisiteur);
        }

        #endregion
    }
}
