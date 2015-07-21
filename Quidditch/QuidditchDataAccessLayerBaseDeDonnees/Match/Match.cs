using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Implémentation de IMatch définissant un mathc durant une coupe
    /// </summary>
    internal class Match : Entite, IMatch
    {
        #region Fields

        /// <summary>
        /// Date du match
        /// </summary>
        private DateTime _dateDuMatch;

        /// <summary>
        /// Arbitre du match
        /// </summary>
        private IArbitre _arbitreDuMatch;

        /// <summary>
        /// Stade du match
        /// </summary>
        private IStade _stadeDuMatch;
       
        /// <summary>
        /// Réservation pour le match
        /// </summary>
        private IList<IReservation> _reservationsPourLeMatch;

        /// <summary>
        /// Equipe jouant à domicile
        /// </summary>
        private IEquipe _equipeDomicile;

        /// <summary>
        /// Equipe jouant à l'extérieur
        /// </summary>
        private IEquipe _equipeVisiteur;

        /// <summary>
        /// Score de l'équipe à domicile
        /// </summary>
        private int _scoreEquipeDomicile;

        /// <summary>
        /// Score de l'équipe à l'extérieur
        /// </summary>
        private int _scoreEquipeVisiteur;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'équipe domicile
        /// </summary>
        public IEquipe EquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'équipe visiteur
        /// </summary>
        public IEquipe EquipeVisiteur
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au score de l'équipe domicile
        /// </summary>
        public int ScoreEquipeDomicile
        {
            get { return _scoreEquipeDomicile; }
            set { _scoreEquipeDomicile = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au score de l'équipe visiteur
        /// </summary>
        public int ScoreEquipeVisiteur
        {
            get { return _scoreEquipeVisiteur; }
            set { _scoreEquipeVisiteur = value; }
        }
        
        /// <summary>
        /// Propriété d'accès en lecture/écriture à la Date du match
        /// </summary>
        public DateTime DateDuMatch
        {
            get { return _dateDuMatch; }
            set { _dateDuMatch = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'arbitre du match
        /// </summary>
        public IArbitre ArbitreDuMatch
        {
            get { return _arbitreDuMatch; }
            set { _arbitreDuMatch = value; }
        }

        /// <summary>
        /// Stadu du match
        /// </summary>
        public IStade StadeDuMatch
        {
            get { return _stadeDuMatch; }
            set { _stadeDuMatch = value; }
        }

        /// <summary>
        /// Réservations pour le match
        /// </summary>
        public IList<IReservation> ReservationsPourLeMatch
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
        { }


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
        public Match(int identifiant, DateTime dateDuMatch, IArbitre arbitreDuMatch, IStade stadeDuMatch, 
            IList<IReservation> reservationsPourLeMatch, IEquipe equipeDomicile, IEquipe equipeVisiteur, 
            int scoreDomicile, int scoreVisiteur )
            : base(identifiant)
        {
            DateDuMatch = dateDuMatch;
            ArbitreDuMatch = arbitreDuMatch;
            StadeDuMatch = stadeDuMatch;
            ReservationsPourLeMatch = reservationsPourLeMatch;
            EquipeDomicile = equipeDomicile;
            EquipeVisiteur = equipeVisiteur;
            ScoreEquipeDomicile = scoreDomicile;
            ScoreEquipeVisiteur = scoreVisiteur;
        }

        /// <summary>
        /// Constructeur d'un Match par copie
        /// </summary>
        /// <param name="matchToCopy">L'instance de Match à copier</param>
        public Match(IMatch matchToCopy)
            : this(matchToCopy.Identifiant, matchToCopy.DateDuMatch, matchToCopy.ArbitreDuMatch,
            matchToCopy.StadeDuMatch, matchToCopy.ReservationsPourLeMatch, matchToCopy.EquipeDomicile,
            matchToCopy.EquipeVisiteur, matchToCopy.ScoreEquipeDomicile, matchToCopy.ScoreEquipeVisiteur)
        {

        }

        #endregion
    }
}
