using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebSite
{
    /// <summary>
    /// Permet de fabriquer des matches
    /// </summary>
    public static class FabriqueMatch
    {
        /// <summary>
        /// Permet de créer un QuidditchWebSite.IMatch à partir d'un QuidditchWebServices.IMatch
        /// </summary>
        /// <param name="match">QuidditchWebServices.IMatch permettant de fabriquer l'objet demandé</param>
        /// <returns>QuidditchWebServices.IMatch créé</returns>
	    public static QuidditchWebSite.IMatch FabriquerMatch(QuidditchWebServices.Match match)
	    {
            List<string> reservations = new List<string>();
            match.StringReservationsPourLeMatch.ToList().ForEach(reservation =>
            {
                reservations.Add(reservation);
            });
            return new Match(match.Identifiant, match.DateDuMatch, match.PrenomNomArbitreDuMatch,
                match.NomStadeDuMatch, reservations, 
                match.NomEquipeDomicile, 
                match.NomEquipeVisiteur,
                match.ScoreEquipeDomicile, match.ScoreEquipeVisiteur);
    	}
    }
}
