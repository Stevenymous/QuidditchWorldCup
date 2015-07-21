using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour responsabilité de gérer et contenir les objets métier Reservation et de gérer la communications entre ces objets
    /// </summary>
    internal class ReservationManager
    {
        #region Fields

        /// <summary>
        /// Les reservations à gérer
        /// </summary>
        private IList<IReservation> _reservations;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture à la liste des reservations
        /// </summary>
        public IList<IReservation> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant un argument
        /// </summary>
        /// <param name="reservations">Les réservations à gérer</param>
        public ReservationManager(IList<IReservation> reservations)
        {
            Reservations = reservations;
        }

        #endregion
    }
}
