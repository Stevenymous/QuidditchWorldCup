using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
   /// <summary>
    /// Interface définissant les caractéristiques d'un Spectateur
    /// </summary>
    public interface ISpectateur : IPersonne
    {
        #region Properties

        /// <summary>
        /// Adresse du spectateur 
        /// </summary>
        string Adresse
        {
            get;
            set;
        }

        /// <summary>
        /// Email du spectateur 
        /// </summary>
        string Email
        {
            get;
            set;
        }
        /// <summary>
        /// Liste de réservation du spectateur
        /// </summary>
        IList<IReservation> Reservations
        {
            get;
            set;
        }

        #endregion
    }
}
