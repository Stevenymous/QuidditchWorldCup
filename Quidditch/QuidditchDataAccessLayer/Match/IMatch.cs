using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition des caractéristiques d'un Match
    /// </summary>
    public interface IMatch : IEntite
    {
        #region Properties

        /// <summary>
        /// Date du match
        /// </summary>
        DateTime DateDuMatch
        {
            get;
            set;
        }

        /// <summary>
        /// Equipe jouant à domicile
        /// </summary>
        IEquipe EquipeDomicile
        {
            get;
            set;
        }

        /// <summary>
        /// Equipe jouant à l'extérieur
        /// </summary>
        IEquipe EquipeVisiteur
        {
            get;
            set;
        }

        /// <summary>
        /// Score de l'équipe à domicile
        /// </summary>
        int ScoreEquipeDomicile
        {
            get;
            set;
        }

        /// <summary>
        /// Score de l'équipe à l'extérieur
        /// </summary>
        int ScoreEquipeVisiteur
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitre du match
        /// </summary>
        IArbitre ArbitreDuMatch
        {
            get;
            set;
        }

        /// <summary>
        /// Stade du match
        /// </summary>
        IStade StadeDuMatch
        {
            get;
            set;
        }

        /// <summary>
        /// Liste de réservation pour le match
        /// </summary>
        IList<IReservation> ReservationsPourLeMatch
        {
            get;
            set;
        }

        #endregion
    }
}
