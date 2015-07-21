using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition de la DalManager de Reservations
    /// </summary>
    public interface IDalManagerReservation
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir toutes les réservations
        /// </summary>
        /// <returns>Liste des réservations</returns>
        IList<IReservation> ObtenirReservations();

        #endregion
    }
}
