using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebSite
{
    /// <summary>
    /// Définition des caractéristiques d'un match 
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
        string NomEquipeDomicile
        {
            get;
            set;
        }

        /// <summary>
        /// Equipe jouant à l'extérieur
        /// </summary>
        string NomEquipeVisiteur
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
        /// Score de l'équipe à l'éxtérieur
        /// </summary>
        int ScoreEquipeVisiteur
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitre du match
        /// </summary>
        string PrenomNomArbitreDuMatch
        {
            get;
            set;
        }

        /// <summary>
        /// Stade du match
        /// </summary>
        string NomStadeDuMatch
        {
            get;
            set;
        }

        /// <summary>
        /// Liste de réservation pour le match
        /// </summary>
        List<string> StringReservationsPourLeMatch
        {
            get;
            set;
        }

        #endregion
    }
}