using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using QuidditchWebServices;
using QuidditchBusinessLayer;

/// <summary>
/// Implémentation des Web Services IServiceMatch et IServiceReservation
/// </summary>
public class ServiceImplementation : IServiceMatch, IServiceReservation
{
	/// <summary>
    /// Permet d'obtenir tous les matches
    /// </summary>
    /// <returns>La liste de tous les matches</returns>
    public IList<QuidditchWebServices.Match> GetAllMatches()
    {
        IList<QuidditchWebServices.Match> matches = new List<QuidditchWebServices.Match>();
        IBusinessManager businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
        IList<QuidditchBusinessLayer.IMatch> matchesFromBusiness = businessManager.GetAllMatches();
    
        matchesFromBusiness.ToList().ForEach(match =>
        {
            matches.Add((Match) FabriqueMatch.FabriquerMatch(match));
        });
        return matches.ToArray();           
    }

    /// <summary>
    /// Operation permettant de retourner toutes les réservations
    /// </summary>
    /// <param name="idMatch">Identifiant du match</param>
    /// <returns>La liste des réservations</returns>
    public IList<QuidditchWebServices.Reservation> GetReservationForOneMatch(int idMatch)
    {
        IList<QuidditchWebServices.Reservation> reservations = new List<QuidditchWebServices.Reservation>();
        IBusinessManager businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
        IList<QuidditchBusinessLayer.IReservation> reservationsFromBusiness = businessManager.GetReservationForOneMatch(idMatch);
        reservationsFromBusiness.ToList().ForEach(reservation =>
        {
            reservations.Add((Reservation) FabriqueReservation.FabriquerReservation(reservation));
        });
        return reservations;
    }

    /// <summary>
    /// Operation permettant d'ajouter une réservation
    /// </summary>
    /// <param name="reservation">Réservation à ajouter</param>
    /// <param name="idMatch">Identifiant du match</param>
    /// <returns>0 si tout s'est bien passé, 1 si non</returns>
    public int AddReservation(QuidditchWebServices.Reservation reservation, int idMatch)
    {
        IBusinessManager businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
        try
        {
            businessManager.AddReservation(FabriqueReservation.FabriquerReservation(reservation), idMatch);
        }
        catch (QuidditchBusinessLayer.MatchOverbookException mobe)
        {
            return -1;
        }
        return 0;
    }
}
