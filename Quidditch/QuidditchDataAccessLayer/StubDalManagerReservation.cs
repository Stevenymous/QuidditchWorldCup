using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation du manager de la data acces layer de Reservation
    /// </summary>
    internal class StubDalManagerReservation : IDalManagerReservation
    {
        /// <summary>
        /// Permet de retourner la liste de toutes les reservations existantes
        /// </summary>
        /// <returns>La liste des reservations existantes</returns>
        public IList<IReservation> ObtenirReservations()
        {
            IList<IReservation> reservations = new List<IReservation>();
            reservations.Add(FabriqueReservation.CreerReservation(0, 95.00f, 17));
            reservations.Add(FabriqueReservation.CreerReservation(1, 95.00f, 47));
            reservations.Add(FabriqueReservation.CreerReservation(2, 60.00f, 8));
            reservations.Add(FabriqueReservation.CreerReservation(3, 60.00f, 9));
            reservations.Add(FabriqueReservation.CreerReservation(4, 13.00f, 56));
            return reservations;
        }
    }
}
