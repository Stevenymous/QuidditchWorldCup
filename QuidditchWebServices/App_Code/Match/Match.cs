using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Implémentation de IMatch dans la QuidditchWebServices définissant un match 
    /// </summary>
    [DataContract]
    public class Match : Entite, IMatch
    {
        #region Fields

        /// <summary>
        /// Date du match
        /// </summary>
        private DateTime _dateDuMatch;

        /// <summary>
        /// Nom de l'arbitre du match
        /// </summary>
        private string _arbitreDuMatch;

        /// <summary>
        /// Nom du stade du match
        /// </summary>
        private string _stadeDuMatch;
       
        /// <summary>
        /// Réservation pour le match
        /// </summary>
        private List<string> _reservationsPourLeMatch;

        /// <summary>
        /// Nom de l'équipe jouant à domicile
        /// </summary>
        private string _equipeDomicile;

        /// <summary>
        /// Nom de l'équipe jouant à l'extérieur
        /// </summary>
        private string _equipeVisiteur;

        /// <summary>
        /// Score de l'équipe à domicile
        /// </summary>
        private int scoreEquipeDomicile;

        /// <summary>
        /// Score de l'équipe à l'extérieur
        /// </summary>
        private int scoreEquipeVisiteur;

        #endregion

        #region Properties
        
        /// <summary>
        /// Propriété d'accès en lecture/écriture au nom de l'équipe domicile
        /// </summary>
        [DataMember]
        public string NomEquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au nom de l'équipe visiteur
        /// </summary>
        [DataMember]
        public string NomEquipeVisiteur
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au score de l'équipe domicile
        /// </summary>
        [DataMember]
        public int ScoreEquipeDomicile
        {
            get { return scoreEquipeDomicile; }
            set { scoreEquipeDomicile = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au score de l'équipe visiteur
        /// </summary>
        [DataMember]
        public int ScoreEquipeVisiteur
        {
            get { return scoreEquipeVisiteur; }
            set { scoreEquipeVisiteur = value; }
        }
        
        /// <summary>
        /// Propriété d'accès en lecture/écriture à la date du match
        /// </summary>
        [DataMember]
        public DateTime DateDuMatch
        {
            get { return _dateDuMatch; }
            set { _dateDuMatch = value; }
        }
        
        /// <summary>
        /// Propriété d'accès en lecture/écriture au prénom et nom de l'arbitre du match
        /// </summary>
        [DataMember]
        public string PrenomNomArbitreDuMatch
        {
            get { return _arbitreDuMatch; }
            set { _arbitreDuMatch = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au nom du stade du match
        /// </summary>
        [DataMember]
        public string NomStadeDuMatch
        {
            get { return _stadeDuMatch; }
            set { _stadeDuMatch = value; }
        }

        /// <summary>
        /// Réservations pour le match
        /// </summary>
        [DataMember]
        public List<string> StringReservationsPourLeMatch
        {
            get { return _reservationsPourLeMatch; }
            set { _reservationsPourLeMatch = value; }
        }

        #endregion

        #region Constructors
        
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Match()
        {
        }

        /// <summary>
        /// Constructeur d'un match acceptant 9 arguments
        /// </summary>
        /// <param name="identifiant">Identifiant du match</param>
        /// <param name="dateDuMatch">Date du match</param>
        /// <param name="arbitreDuMatch">Arbitre du match</param>
        /// <param name="stadeDuMatch">Stade du match</param>
        /// <param name="reservationsPourLeMatch">Réservations des places pour assiter au match</param>
        /// <param name="equipeDomicile">Equipe domicile</param>
        /// <param name="equipeVisiteur">Equipe visiteur</param>
        /// <param name="scoreDomicile">Score de l'équipe à domicile</param>
        /// <param name="scoreVisiteur">Score de l'équipe visiteur</param>
        public Match(int identifiant, DateTime dateDuMatch, string arbitreDuMatch, string stadeDuMatch, 
            List<string> reservationsPourLeMatch, string equipeDomicile, string equipeVisiteur, 
            int scoreDomicile, int scoreVisiteur )
            : base(identifiant)
        {
            DateDuMatch = dateDuMatch;
            PrenomNomArbitreDuMatch = arbitreDuMatch;
            NomStadeDuMatch = stadeDuMatch;
            StringReservationsPourLeMatch = reservationsPourLeMatch;
            NomEquipeDomicile = equipeDomicile;
            NomEquipeVisiteur = equipeVisiteur;
            ScoreEquipeDomicile = scoreDomicile;
            ScoreEquipeVisiteur = scoreVisiteur;
        }

        /// <summary>
        /// Constructeur d'un Match par copie
        /// </summary>
        /// <param name="matchToCopy">L'instance de Match à copier</param>
        public Match(IMatch matchToCopy)
            : this(matchToCopy.Identifiant, matchToCopy.DateDuMatch, matchToCopy.PrenomNomArbitreDuMatch,
            matchToCopy.NomStadeDuMatch, matchToCopy.StringReservationsPourLeMatch, matchToCopy.NomEquipeDomicile,
            matchToCopy.NomEquipeVisiteur, matchToCopy.ScoreEquipeDomicile, matchToCopy.ScoreEquipeVisiteur)
        {

        }
        
        #endregion
    }
}
