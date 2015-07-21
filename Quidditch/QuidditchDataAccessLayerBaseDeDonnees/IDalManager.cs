using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Défini les opérations d'intérrogation sur les objets IDataAccess
    /// Interface Abstraction du pattern Bridge
    /// </summary>
    internal interface IDalManager
    {
        #region Properties

        /// <summary>
        /// Encapsulation permettant de faire le lien avec l'objet IDataAccess à l'aide d'une propriété
        /// </summary>
        IDataAccess DataAccess
        {
            get;
            set;
        }

        #endregion

        #region Operations

        /// <summary>
        /// Permet d'obtenir tous les matches
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllMatches();

        /// <summary>
        /// Permet de récupérer l'ensemble des matches pour une coupe
        /// </summary>
        /// <param name="idMatch">Identifiant de la Coupe</param>
        /// <returns>Les lignes de Match</returns>
        DataTable GetAllMatchForOneCoupe(int idCoupe);

        /// <summary>
        /// Permet d'obtenir tous les joueurs
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllJoueurs();

        /// <summary>
        /// Permet d'obtenir tous les joueurs provennant d'une équipe
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllJoueursFromOneEquipe(int idEquipe);

        /// <summary>
        /// Permet d'obtenir toutes les équipes
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllEquipes();

        /// <summary>
        /// Permet de récupérer une equipe jouant à domicile pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le equipe sous forme d'enregistrement de base de données</returns>
        DataTable GetOneEquipeDomicileFromMatch(int idMatch);

        /// <summary>
        /// Permet de récupérer une equipe jouant en tant que visiteur pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le equipe sous forme d'enregistrement de base de données</returns>
        DataTable GetOneEquipeVisiteurFromMatch(int idMatch);

        /// <summary>
        /// Permet d'obtenir toutes les coupes
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllCoupes();

        /// <summary>
        /// Permet d'obtenir tous les arbitres
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllArbitres();

        /// <summary>
        /// Permet d'obtenir tous les stades
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllStades();

        /// <summary>
        /// Permet de récupérer un stade d'un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le stade sous forme d'enregistrement de base de données</returns>
        DataTable GetOneStadeFromMatch(int idMatch);

        /// <summary>
        /// Permet d'obtenir toutes les réservations 
        /// </summary>
        /// <returns>Une instance de DataTable</returns>
        DataTable GetAllReservations();

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Les lignes de Reservation</returns>
        DataTable GetAllReservationForOneMatch(int idMatch);

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un spectateur
        /// </summary>
        /// <param name="idMatch">Identifiant du specateur</param>
        /// <returns>Les lignes de Reservation</returns>
        DataTable GetAllReservationForOneSpectateur(int idSpectateur);

        /// <summary>
        /// Permet de récupérer un arbitre d'un match 
        /// </summary>
        /// <param name="idArbitre">Identifiant du match</param>
        /// <returns>Le arbitre sous forme d'enregistrement de base de données</returns>
        DataTable GetOneArbitreFromMatch(int idMatch);

        /// <summary>
        /// Permet de récupérer l'ensemble des spectateurs
        /// </summary>
        /// <returns>Les specateurs sous forme d'enregistrement de base de données</returns>
        DataTable GetAllSpectateur();

        /// <summary>
        /// Permet d'ajouter un match en base
        /// </summary>
        /// <param name="match">Match à ajouter</param>
        /// <returns>Entier indiquant le résultat</returns>
        int AddMatch(IMatch match);

        /// <summary>
        /// Permet d'ajouter une réservation en base
        /// </summary>
        /// <param name="reservation">Reservation à ajouter</param>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Entier indiquant le résultat</returns>
        int AddReservation(IReservation reservation, int idMatch);

        /// <summary>
        /// Permet de supprimer un match en base
        /// </summary>
        /// <param name="match">Match à supprimer</param>
        /// <returns>Entier indiquant le résultat</returns>
        int DeleteMatch(IMatch match);

        #endregion
    }
}
