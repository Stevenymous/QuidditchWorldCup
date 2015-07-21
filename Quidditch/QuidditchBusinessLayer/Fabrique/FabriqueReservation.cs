using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Fabrique des instances de Reservation 
    /// </summary>
    internal static class FabriqueReservation
    {
        #region Operations

        /// <summary>
        /// Fabrique le IReservation de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="reservation">Reservation de la QuidditchDataAccessLayer</param>
        /// <returns>Le reservation pour la QuidditchBusinessLayer</returns>
        public static IReservation FabriquerReservation(QuidditchDataAccessLayer.IReservation reservation)
        {
            return new Reservation(reservation.Identifiant, reservation.Prix, reservation.Place);
        }

        /// <summary>
        /// Fabrique le IReservation de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="reservation">Reservation de la QuidditchDataAccessLayerBaseDeDonnees</param>
        /// <returns>Le reservation pour la QuidditchBusinessLayer</returns>
        public static IReservation FabriquerReservation(QuidditchDataAccessLayerBaseDeDonnees.IReservation reservation)
        {
            return new Reservation(reservation.Identifiant, reservation.Prix, reservation.Place);
        }

        /// <summary>
        /// Fabrique le IReservation de la QuidditchDataAccessLayerBaseDeDonnees
        /// </summary>
        /// <param name="reservation">Reservation de la QuidditchBusinessLayer</param>
        /// <returns>Le reservation pour la QuidditchDataAccessLayerBaseDeDonnees</returns>
        public static QuidditchDataAccessLayerBaseDeDonnees.IReservation FabriquerReservation(IReservation reservation)
        {
            return new ReservationDal(reservation.Identifiant, reservation.Prix, reservation.Place);
        }

        #endregion
    }
}
