using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchBusinessLayer;
namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Fabrique des instances de IMatch
    /// </summary>
    internal static class FabriqueMatch
    {
        #region Operations
        
        /// <summary>
        /// Fabrique le IMatch de la presentationLayer
        /// </summary>
        /// <param name="match">Match de la businessLayer</param>
        /// <returns>Le match pour la présentation layer</returns>
        public static IMatch FabriquerMatch(QuidditchBusinessLayer.IMatch match)
        {
            return new Match(match.Identifiant, match.DateDuMatch, FabriqueArbitre.FabriquerArbitre(match.ArbitreDuMatch),
                FabriqueStade.FabriquerStade(match.StadeDuMatch), FabriqueEquipe.FabriquerEquipe(match.EquipeDomicile), 
                FabriqueEquipe.FabriquerEquipe(match.EquipeVisiteur),
                match.ScoreEquipeDomicile, match.ScoreEquipeVisiteur);
        }

        /// <summary>
        /// Fabrique le IMatch de la BusinessLayer
        /// </summary>
        /// <param name="match">Match de la PresentationLayerWPF</param>
        /// <returns>Le match pour la businessLayer</returns>
        public static QuidditchBusinessLayer.IMatch FabriquerMatch(IMatch match)
        {
            return new MatchBusiness(match.Identifiant, match.DateDuMatch, FabriqueArbitre.FabriquerArbitre(match.ArbitreDuMatch),
                FabriqueStade.FabriquerStade(match.StadeDuMatch), FabriqueEquipe.FabriquerEquipe(match.EquipeDomicile), 
                FabriqueEquipe.FabriquerEquipe(match.EquipeVisiteur),
                match.ScoreEquipeDomicile, match.ScoreEquipeVisiteur);
        }
        #endregion
    }
}
