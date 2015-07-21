using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Fabrique des instances de IReservation
    /// </summary>
    internal static class FabriqueReservation
    {
        #region Operations

        /// <summary>
        /// Fabrique le IReservation de la QuidditchWebServices
        /// </summary>
        /// <param name="reservation">Reservation de la QuidditchBusinessLayer</param>
        /// <returns>Le reservation pour la QuidditchWebServices</returns>
        public static IReservation FabriquerReservation(QuidditchBusinessLayer.IReservation reservation)
        {
            return new Reservation(reservation.Identifiant, reservation.Prix, reservation.Place);
        }

        /// <summary>
        /// Fabrique le IReservation de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="reservation">Reservation de la QuidditchWebServices</param>
        /// <returns>Le reservation pour la QuidditchBusinessLayer</returns>
        public static QuidditchBusinessLayer.IReservation FabriquerReservation(IReservation reservation)
        {
            return new ReservationBusiness(reservation.Identifiant, reservation.Prix, reservation.Place);
        }

        #endregion
    }
}