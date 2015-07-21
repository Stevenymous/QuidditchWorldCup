using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

[ServiceContract]
public interface IServiceReservation
{
	/// <summary>
    /// Operation permettant de récupérer toutes les réservations
    /// </summary>
    /// <param name="idMatch">Identifiant du match</param>
    /// <returns>La liste des réservations</returns>
	[OperationContract]
    IList<QuidditchWebServices.Reservation> GetReservationForOneMatch(int idMatch);

    /// <summary>
    /// Operation permettant d'ajouter une réservation
    /// </summary>
    /// <param name="reservation">Réservation à ajouter</param>
    /// <param name="idMatch">Identifiant du match</param>
    /// <returns>0 si l'ajout s'est bien passé -1 si non</returns>
    [OperationContract]
    int AddReservation(QuidditchWebServices.Reservation reservation, int idMatch);
}