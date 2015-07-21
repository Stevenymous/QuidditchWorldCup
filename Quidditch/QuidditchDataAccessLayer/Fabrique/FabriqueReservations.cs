using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Fabrique d'instances de IReservations
    /// </summary>
    internal static class FabriqueReservation
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IReservation
        /// </summary>
        /// <returns>L'instance d'une reservation</returns>
        public static IReservation CreerReservation(int identifiant, float prix, int place)
        {
            return new Reservation(identifiant, prix, place);
        }

        #endregion
    }
}
