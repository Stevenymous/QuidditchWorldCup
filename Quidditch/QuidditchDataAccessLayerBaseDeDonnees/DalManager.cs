using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Abstraction de la connexion à la base de données
    /// Classe Abstraction du pattern Bridge
    /// </summary>
    internal class DalManager : IDalManager
    {
        #region Fields

        /// <summary>
        /// Définition de l'implémentation d'accès aux données
        /// </summary>
        private IDataAccess _dataAccess;

        #endregion

        #region Properties

        /// <summary>
        /// Implémentation de la propriété permettant d'accéder à l'implémentation de DataAccess
        /// </summary>
        public IDataAccess DataAccess
        {
            get
            {
                return _dataAccess;
            }
            set
            {
                _dataAccess = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut de DalManager initialisant le IDataAccess
        /// </summary>
        public DalManager()
        {
            DataAccess = new DataAccessSqlServer();
        }

        #endregion

        #region Operations

        /// <summary>
        /// Permet d'obtenir tous les matches
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllMatches()
        {
            return DataAccess.FindAllMatch();
        }

        /// <summary>
        /// Permet d'obtenir tous les joueurs
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllJoueurs()
        {
            return DataAccess.FindAllJoueur();
        }

        /// <summary>
        /// Permet d'obtenir tous les joueurs d'une équipe
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllJoueursFromOneEquipe(int idEquipe)
        {
            return DataAccess.FindAllJoueurFromEquipe(idEquipe);
        }

        /// <summary>
        /// Permet d'obtenir toutes les équipes
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllEquipes()
        {
            return DataAccess.FindAllEquipe();
        }

        /// <summary>
        /// Permet d'obtenir toutes les coupes
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllCoupes()
        {
            return DataAccess.FindAllCoupe();
        }

        /// <summary>
        /// Permet d'obtenir tous les arbitres
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllArbitres()
        {
            return DataAccess.FindAllArbitre();
        }

        /// <summary>
        /// Permet d'obtenir tous les stades
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllStades()
        {
            return DataAccess.FindAllStade();
        }

        /// <summary>
        /// Permet d'obtenir toutes les réservations 
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        public DataTable GetAllReservations()
        {
            return DataAccess.FindAllReservation();
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des matches pour une coupe
        /// </summary>
        /// <param name="idMatch">Identifiant de la Coupe</param>
        /// <returns>Les lignes de Match</returns>
        public DataTable GetAllMatchForOneCoupe(int idCoupe)
        {
            return DataAccess.FindAllMatchForOneCoupe(idCoupe);
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Les lignes de Reservation</returns>
        public DataTable GetAllReservationForOneMatch(int idMatch)
        {
            return DataAccess.FindAllReservationForOneMatch(idMatch);
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un spectateur
        /// </summary>
        /// <param name="idMatch">Identifiant du specateur</param>
        /// <returns>Les lignes de Reservation</returns>
        public DataTable GetAllReservationForOneSpectateur(int idSpectateur)
        {
            return DataAccess.FindAllReservationForOneSpectateur(idSpectateur);
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des spectateurs
        /// </summary>
        /// <returns>Les specateurs sous forme d'enregistrement de base de données</returns>
        public DataTable GetAllSpectateur()
        {
            return DataAccess.FindAllSpectateur();
        }

        /// <summary>
        /// Permet de récupérer une equipe jouant à domicile pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le equipe sous forme d'enregistrement de base de données</returns>
        public DataTable GetOneEquipeDomicileFromMatch(int idMatch)
        {
            return DataAccess.FindOneEquipeDomicileFromMatch(idMatch);
        }

        /// <summary>
        /// Permet de récupérer une equipe jouant en tant que visiteur pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le equipe sous forme d'enregistrement de base de données</returns>
        public DataTable GetOneEquipeVisiteurFromMatch(int idMatch)
        {
            return DataAccess.FindOneEquipeVisiteurFromMatch(idMatch);
        }

        /// <summary>
        /// Permet de récupérer un stade d'un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le stade sous forme d'enregistrement de base de données</returns>
        public DataTable GetOneStadeFromMatch(int idMatch)
        {
            return DataAccess.FindOneStadeFromMatch(idMatch);
        }

        /// <summary>
        /// Permet de récupérer un arbitre d'un match 
        /// </summary>
        /// <param name="idArbitre">Identifiant du match</param>
        /// <returns>Le arbitre sous forme d'enregistrement de base de données</returns>
        public DataTable GetOneArbitreFromMatch(int idMatch)
        {
            return DataAccess.FindOneArbitreFromMatch(idMatch);
        }

        /// <summary>
        /// Permet d'ajouter un match en base
        /// </summary>
        /// <param name="match">Match à ajouter</param>
        /// <returns>Entier indiquant le résultat</returns>
        public int AddMatch(IMatch match)
        {
            return DataAccess.InsertMatch(match);
        }

        /// <summary>
        /// Permet de supprimer un match en base
        /// </summary>
        /// <param name="match">Match à supprimer</param>
        /// <returns>Entier indiquant le résultat</returns>
        public int DeleteMatch(IMatch match)
        {
            return DataAccess.DeleteMatch(match);
        }

        /// <summary>
        /// Permet d'ajouter un match en base
        /// </summary>
        /// <param name="match">Match à ajouter</param>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Entier indiquant le résultat</returns>
        public int AddReservation(IReservation reservation, int idMatch)
        {
            DataTable numberPlace = DataAccess.FindNumberPlaceCanBeReservedForOnMatch(idMatch);
            if (numberPlace.Rows.Count > 0)
            {
                int numberPlaceRestant = (int) numberPlace.Rows[0]["numbrePlaceRestante"];
                if (numberPlaceRestant <= 0)
                {
                    return -1;
                }
            }
            return DataAccess.InsertReservation(reservation, idMatch);
        }

        #endregion
    }
}
