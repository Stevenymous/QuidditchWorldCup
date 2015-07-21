﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace QuidditchWebSite
{
    /// <summary>
    /// Implémentation de IMatch dans la BusinessLayer définissant un match durant une coupe
    /// </summary>
    public class Match : Entite, IMatch
    {
        #region Fields

        /// <summary>
        /// Date du match
        /// </summary>
        private DateTime _dateDuMatch;

        /// <summary>
        /// Arbitre du match
        /// </summary>
        private string _arbitreDuMatch;

        /// <summary>
        /// Stade du match
        /// </summary>
        private string _stadeDuMatch;
       
        /// <summary>
        /// Réservation pour le match
        /// </summary>
        private List<string> _reservationsPourLeMatch;

        /// <summary>
        /// Equipe jouant à domicile
        /// </summary>
        private string _equipeDomicile;

        /// <summary>
        /// Equipe jouant à l'extérieur
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
        /// Propriété d'accès en lecture/écriture à l'équipe domicile
        /// </summary>
        public string NomEquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'équipe visiteur
        /// </summary>
        public string NomEquipeVisiteur
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
        public string PrenomNomArbitreDuMatch
        {
            get { return _arbitreDuMatch; }
            set { _arbitreDuMatch = value; }
        }

        /// <summary>
        /// Stadu du match
        /// </summary>
        public string NomStadeDuMatch
        {
            get { return _stadeDuMatch; }
            set { _stadeDuMatch = value; }
        }

        /// <summary>
        /// Réservations pour le match
        /// </summary>
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

        #region Operations

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(NomEquipeDomicile);
            builder.Append(" ");
            builder.Append(ScoreEquipeDomicile);
            builder.Append(" - ");
            builder.Append(ScoreEquipeVisiteur);
            builder.Append(" ");
            builder.Append(NomEquipeVisiteur);
            builder.Append(" ");
            builder.Append(DateDuMatch.ToLongDateString());
            builder.Append(" ");
            builder.Append(NomStadeDuMatch);
            builder.Append(" ");
            builder.Append(PrenomNomArbitreDuMatch);
            return builder.ToString();
        }


        #endregion
    }
}