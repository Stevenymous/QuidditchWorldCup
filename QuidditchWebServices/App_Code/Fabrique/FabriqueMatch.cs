using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuidditchWebServices;
using QuidditchBusinessLayer;

namespace QuidditchWebServices
{
    /// <summary>
    /// Permet de fabriquer des QuidditchWebServices.IMatch à partir de QuidditchBusinessLayer.IMatch
    /// </summary>
    public static class FabriqueMatch
    {
        /// <summary>
        /// Permet de créer un QuidditchWebServices.IMatch à partir d'un QuidditchBusinessLayer.IMatch
        /// </summary>
        /// <param name="match">QuidditchBusinessLayer.IMatch permettant de fabriquer l'objet demandé</param>
        /// <returns>QuidditchWebServices créé</returns>
	    public static QuidditchWebServices.IMatch FabriquerMatch(QuidditchBusinessLayer.IMatch match)
	    {
            List<string> reservations = new List<string>();
            match.ReservationsPourLeMatch.ToList().ForEach(reservation =>
            {
                reservations.Add(reservation.ToString());
            });
            return new Match(match.Identifiant, match.DateDuMatch, match.ArbitreDuMatch.Prenom + " " + match.ArbitreDuMatch.Nom,
                match.StadeDuMatch.Nom, reservations, 
                match.EquipeDomicile.Nom, 
                match.EquipeVisiteur.Nom,
                match.ScoreEquipeDomicile, match.ScoreEquipeVisiteur);
    	}
    }
}
