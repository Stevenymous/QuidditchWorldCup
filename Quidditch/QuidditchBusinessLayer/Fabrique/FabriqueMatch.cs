using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Fabrique des instances de Match 
    /// </summary>
    internal static class FabriqueMatch
    {
        #region Operations
        
        /// <summary>
        /// Fabrique le IMatch de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="match">Match de la QuidditchDataAccessLayer</param>
        /// <returns>Le match pour la QuidditchBusinessLayer</returns>
        public static IMatch FabriquerMatch(QuidditchDataAccessLayer.IMatch match)
        {
            return new Match(match.Identifiant, match.DateDuMatch, FabriqueArbitre.FabriquerArbitre(match.ArbitreDuMatch), 
                FabriqueStade.FabriquerStade(match.StadeDuMatch), null, FabriqueEquipe.FabriquerEquipe(match.EquipeDomicile), 
                FabriqueEquipe.FabriquerEquipe(match.EquipeVisiteur), match.ScoreEquipeDomicile, match.ScoreEquipeVisiteur);
        }

        /// <summary>
        /// Fabrique le IMatch de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="match">Match de la QuidditchDataAccessLayerBaseDeDonnees</param>
        /// <returns>Le match pour la QuidditchBusinessLayer</returns>
        public static IMatch FabriquerMatch(QuidditchDataAccessLayerBaseDeDonnees.IMatch match)
        {
            IList<IReservation> reservations = new List<IReservation>();
            match.ReservationsPourLeMatch.ToList().ForEach(reservation =>
            {
                reservations.Add(FabriqueReservation.FabriquerReservation(reservation));
            });
            return new Match(match.Identifiant, match.DateDuMatch, FabriqueArbitre.FabriquerArbitre(match.ArbitreDuMatch),
                FabriqueStade.FabriquerStade(match.StadeDuMatch), reservations, FabriqueEquipe.FabriquerEquipe(match.EquipeDomicile),
                FabriqueEquipe.FabriquerEquipe(match.EquipeVisiteur), match.ScoreEquipeDomicile, match.ScoreEquipeVisiteur);
        }

        /// <summary>
        /// Fabrique le IMatch de la QuidditchDataAccessLayerBaseDeDonnees
        /// </summary>
        /// <param name="match">Match de la QuidditchBusinessLayer</param>
        /// <returns>Le match pour la QuidditchDataAccessLayerBaseDeDonnees</returns>
        public static QuidditchDataAccessLayerBaseDeDonnees.IMatch FabriquerMatch(IMatch match)
        {
            IList<QuidditchDataAccessLayerBaseDeDonnees.IReservation> reservations = new List<QuidditchDataAccessLayerBaseDeDonnees.IReservation>();
            return new MatchDal(match.Identifiant, match.DateDuMatch, FabriqueArbitre.FabriquerArbitre(match.ArbitreDuMatch),
                FabriqueStade.FabriquerStade(match.StadeDuMatch), reservations, FabriqueEquipe.FabriquerEquipe(match.EquipeDomicile),
                FabriqueEquipe.FabriquerEquipe(match.EquipeVisiteur), match.ScoreEquipeDomicile, match.ScoreEquipeVisiteur);
        }
        #endregion
    }
}
