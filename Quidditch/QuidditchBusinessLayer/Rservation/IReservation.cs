using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
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
        /// Place afiliée à la réservation
        /// </summary>
        int Place
        {
            get;
            set;
        }

        #endregion
    }
}
