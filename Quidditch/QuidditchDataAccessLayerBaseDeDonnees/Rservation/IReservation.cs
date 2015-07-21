using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
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
        /// Nombre de place affiliée à la réservation
        /// </summary>
        int Place
        {
            get;
            set;
        }

        #endregion
    }
}
