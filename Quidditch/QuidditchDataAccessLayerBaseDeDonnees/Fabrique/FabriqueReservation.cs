using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Fabrique d'instances de IReservation
    /// </summary>
    internal static class FabriqueReservation
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IReservation
        /// </summary>
        /// <param name="identifiant">Identifiant de la reservation sous forme de chaîne de caractères</param>
        /// <param name="prix">Prix de la place sous forme de chaîne de caractère</param>
        /// <param name="place">Nom de la place</param>
        /// <returns>L'instance d'un reservation</returns>
        public static IReservation CreerReservation(string identifiant, string prix, string place)
        {
            return new Reservation(Convert.ToInt32(identifiant), (float) Convert.ToDouble(prix), Convert.ToInt32(place));
        }

        #endregion
    }
}
