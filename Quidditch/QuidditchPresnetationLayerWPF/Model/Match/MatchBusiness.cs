using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Implémentation de IMatch provennant de la BusinessLayer permettant de transmettre l'objet
    /// </summary>
    internal class MatchBusiness : EntiteBusiness, QuidditchBusinessLayer.IMatch
    {
        #region Fields

        /// <summary>
        /// Date du match
        /// </summary>
        private DateTime _dateDuMatch;

        /// <summary>
        /// Arbitre du match
        /// </summary>
        private QuidditchBusinessLayer.IArbitre _arbitreDuMatch;

        /// <summary>
        /// Stade du match
        /// </summary>
        private QuidditchBusinessLayer.IStade _stadeDuMatch;
       
        /// <summary>
        /// Equipe jouant à domicile
        /// </summary>
        private QuidditchBusinessLayer.IEquipe _equipeDomicile;

        /// <summary>
        /// Equipe jouant à l'extérieur
        /// </summary>
        private QuidditchBusinessLayer.IEquipe _equipeVisiteur;

        /// <summary>
        /// Score de l'équipe à domicile
        /// </summary>
        private int scoreEquipeDomicile;

        /// <summary>
        /// Score de l'équipe à l'extérieur
        /// </summary>
        private int scoreEquipeVisiteur;

        /// <summary>
        /// Réservation pour le match
        /// </summary>
        private IList<QuidditchBusinessLayer.IReservation> _reservationsPourLeMatch;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'équipe domicile
        /// </summary>
        public QuidditchBusinessLayer.IEquipe EquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'équipe visiteur
        /// </summary>
        public QuidditchBusinessLayer.IEquipe EquipeVisiteur
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au score de l'équipe domicile
        /// </summary>
        public int ScoreEquipeDomicile
        {
            get { return scoreEquipeDomicile; }
            set { scoreEquipeDomicile = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au score de l'équipe visiteur
        /// </summary>
        public int ScoreEquipeVisiteur
        {
            get { return scoreEquipeVisiteur; }
            set { scoreEquipeVisiteur = value; }
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
        public QuidditchBusinessLayer.IArbitre ArbitreDuMatch
        {
            get { return _arbitreDuMatch; }
            set { _arbitreDuMatch = value; }
        }

        /// <summary>
        /// Stadu du match
        /// </summary>
        public QuidditchBusinessLayer.IStade StadeDuMatch
        {
            get { return _stadeDuMatch; }
            set { _stadeDuMatch = value; }
        }

        /// <summary>
        /// Réservations pour le match
        /// </summary>
        public IList<QuidditchBusinessLayer.IReservation> ReservationsPourLeMatch
        {
            get { return _reservationsPourLeMatch; }
            set { _reservationsPourLeMatch = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public MatchBusiness()
        { }


        /// <summary>
        /// Constructeur d'un match acceptant 9 arguments
        /// </summary>
        /// <param name="identifiant">Identifiant du match</param>
        /// <param name="dateDuMatch">Date du match</param>
        /// <param name="arbitreDuMatch">Arbitre du match</param>
        /// <param name="stadeDuMatch">Stade du match</param>
        /// <param name="equipeDomicile">Equipe domicile</param>
        /// <param name="equipeVisiteur">Equipe visiteur</param>
        /// <param name="scoreDomicile">Score de l'équipe à domicile</param>
        /// <param name="scoreVisiteur">Score de l'équipe visiteur</param>
        public MatchBusiness(int identifiant, DateTime dateDuMatch, QuidditchBusinessLayer.IArbitre arbitreDuMatch,
            QuidditchBusinessLayer.IStade stadeDuMatch, 
            QuidditchBusinessLayer.IEquipe equipeDomicile, QuidditchBusinessLayer.IEquipe equipeVisiteur, 
            int scoreDomicile, int scoreVisiteur )
            : base(identifiant)
        {
            DateDuMatch = dateDuMatch;
            ArbitreDuMatch = arbitreDuMatch;
            StadeDuMatch = stadeDuMatch;
            EquipeDomicile = equipeDomicile;
            EquipeVisiteur = equipeVisiteur;
            ScoreEquipeDomicile = scoreDomicile;
            ScoreEquipeVisiteur = scoreVisiteur;
        }

        /// <summary>
        /// Constructeur d'un Match par copie
        /// </summary>
        /// <param name="matchToCopy">L'instance de Match à copier</param>
        public MatchBusiness(QuidditchBusinessLayer.IMatch matchToCopy)
            : this(matchToCopy.Identifiant, matchToCopy.DateDuMatch, matchToCopy.ArbitreDuMatch,
            matchToCopy.StadeDuMatch, matchToCopy.EquipeDomicile,
            matchToCopy.EquipeVisiteur, matchToCopy.ScoreEquipeDomicile, matchToCopy.ScoreEquipeVisiteur)
        {

        }

        #endregion

        /// <summary>
        /// Rédéfinition de ToString
        /// </summary>
        /// <returns>La chaîne représentant l'objet Equipe</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Date du match : ");
            builder.Append(DateDuMatch.ToLongDateString());
            builder.Append(" stade : ");
            builder.Append(StadeDuMatch);
            builder.Append(" arbitre : ");
            builder.Append(ArbitreDuMatch);
            builder.AppendLine(" équipe domicile : ");
            builder.Append(EquipeDomicile.ToString());
            builder.AppendLine(" équipe visiteur : ");
            builder.Append(EquipeVisiteur.ToString());
            builder.AppendLine(" Score :");
            builder.Append("Domicile : ");
            builder.Append(ScoreEquipeDomicile);
            builder.Append(" - ");
            builder.Append(ScoreEquipeVisiteur);
            builder.Append(" : Visiteur");

            return builder.ToString();
        }

    }
}
