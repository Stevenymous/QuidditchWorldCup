using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Implémentation d'une réservation
    /// </summary>
    internal class Reservation : Entite, IReservation
    {
        #region Fields

        /// <summary>
        /// Prix de la réservation
        /// </summary>
        private float _prix;

        /// <summary>
        /// Places correspondant à la réservation
        /// </summary>
        private int _place;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture et en écriture au Prix de la réservation
        /// </summary>
        public float Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture et en écriture à la place de la réservation
        /// </summary>
        public int Place
        {
            get { return _place; }
            set { _place = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Reservation()
        { }

        /// <summary>
        /// Constructeur d'une réservation avec son identifiant, son prix et sa place
        /// </summary>
        /// <param name="identifiant">Identifiant de la réservation</param>
        /// <param name="prix">Prix de la réservation</param>
        /// <param name="place">Place correspondant à l réservation</param>
        public Reservation(int identifiant, float prix, int place)
            : base(identifiant)
        {
            Prix = prix;
            Place = place;
        }

        /// <summary>
        /// Constructeur par copie d'une réservation
        /// </summary>
        /// <param name="reservationToCopy">Instance de Réservation à copier</param>
        public Reservation(IReservation reservationToCopy)
            : this(reservationToCopy.Identifiant, reservationToCopy.Prix, reservationToCopy.Place)
        {

        }

        #endregion
    }
}
