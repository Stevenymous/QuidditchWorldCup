using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Définition d'une réservation
    /// </summary>
    public interface IReservation : IEntite
    {
        #region Properties

        /// <summary>
        /// Prix de la place
        /// </summary>
        float Prix
        {
            get;
            set;
        }

        /// <summary>
        /// Nombre de place affilié à la réservation
        /// </summary>
        int Place
        {
            get;
            set;
        }

        #endregion
    }
}
