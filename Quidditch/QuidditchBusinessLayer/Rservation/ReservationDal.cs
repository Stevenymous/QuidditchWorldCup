using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Implémentation d'une réservation pour la couche QuidditchDataAccessLayerBaseDeDonnees
    /// </summary>
    internal class ReservationDal : EntiteDal, QuidditchDataAccessLayerBaseDeDonnees.IReservation
    {
        #region Fields

        /// <summary>
        /// Prix de la réservation
        /// </summary>
        private float _prix;

        /// <summary>
        /// Place correspondant à la réservation
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
        public ReservationDal()
        { }

        /// <summary>
        /// Constructeur d'une réservation avec son identifiant, son prix et sa place
        /// </summary>
        /// <param name="identifiant">Identifiant de la réservation</param>
        /// <param name="prix">Prix de la réservation</param>
        /// <param name="place">Place correspondant à l réservation</param>
        public ReservationDal(int identifiant, float prix, int place)
            : base(identifiant)
        {
            Prix = prix;
            Place = place;
        }

        /// <summary>
        /// Constructeur par copie d'une réservation
        /// </summary>
        /// <param name="reservationToCopy">Instance de Réservation à copier</param>
        public ReservationDal(QuidditchDataAccessLayerBaseDeDonnees.IReservation reservationToCopy)
            : this(reservationToCopy.Identifiant, reservationToCopy.Prix, reservationToCopy.Place)
        {

        }

        #endregion

        #region Operations

        /// <summary>
        /// Rédéfinition de ToString
        /// </summary>
        /// <returns>La chaîne représentant l'objet Reservation</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Place : ");
            builder.Append(Place);
            builder.Append(" prix : ");
            builder.Append(Prix);
            return builder.ToString();
        }

        #endregion
    }
}
