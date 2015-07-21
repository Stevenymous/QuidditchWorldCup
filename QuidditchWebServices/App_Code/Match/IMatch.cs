using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
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
        /// Nom de l'equipe jouant à domicile
        /// </summary>
        string NomEquipeDomicile
        {
            get;
            set;
        }

        /// <summary>
        /// Nom de l'equipe jouant à l'extérieur
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
        /// Score de l'équipe à l'extérieur
        /// </summary>
        int ScoreEquipeVisiteur
        {
            get;
            set;
        }

        /// <summary>
        /// Prénom et nom de l'arbitre du match
        /// </summary>
        string PrenomNomArbitreDuMatch
        {
            get;
            set;
        }

        /// <summary>
        /// Nom du stade du match
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
