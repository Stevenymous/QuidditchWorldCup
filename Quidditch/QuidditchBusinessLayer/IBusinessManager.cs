using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Définition du comportement de IBusinessManager
    /// </summary>
    public interface IBusinessManager
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir toutes les coupes
        /// </summary>
        /// <returns>Toutes les instances de ICoupe sous forme de chaînes de caractères</returns>
        IList<string> GetAllCoupesString();

        /// <summary>
        /// Permet de retourner la liste des matches sous forme de chaines de caractères des matches prévu triés de manière croissante
        /// </summary>
        /// <returns>Une liste de chaine de caractères représentant les matches</returns>
        IList<string> GetMatchsExpectedOrderByDate();

        /// <summary>
        /// Permet d'obtenir tous les stades dont au moins un match est programmé 
        /// </summary>
        /// <returns>La liste des chaines de caractères représentant les stades</returns>
        IList<string> GetStadeWhereAtLeastOneMatchIsExpected();

        /// <summary>
        /// Permet de récupérer les chaines de caractères représentant tous les joueurs au poste d'attrapeur ayant joués à domicile
        /// </summary>
        /// <returns>Les joueurs sous forme de chaînes de caractères</returns>
        IList<string> GetJoueursWhoBeCatcherAndPlayedAtHome();

        /// <summary>
        /// Permet de récupérer tous les joueurs sous forme de chaînes de caractères qui sont gardien est dont l'age est inférieur à 17 ans
        /// </summary>
        /// <returns>Les joueurs sous forme de chaînes de caractères</returns>
        IList<string> GetJoueursWhoBeGardienAndBeYoungerThanSeventeen();

        /// <summary>
        /// Permet de récupérer tous les matches 
        /// </summary>
        /// <returns>La liste des matches</returns>
        IList<IMatch> GetAllMatches();

        /// <summary>
        /// Permet de récupérer toutes les équipes existantes
        /// </summary>
        /// <returns>La liste des équipes</returns>
        IList<IEquipe> GetAllEquipes();

        /// <summary>
        /// Permet de récupérer tous les stades existants
        /// </summary>
        /// <returns>La liste des stades</returns>
        IList<IStade> GetAllStades();

        /// <summary>
        /// Permet de récupérer toutes les coupes existantes
        /// </summary>
        /// <returns>La liste des coupes</returns>
        IList<ICoupe> GetAllCoupes();

        /// <summary>
        /// Permet de récupérer tous les arbitres existants
        /// </summary>
        /// <returns>La liste des arbitres</returns>
        IList<IArbitre> GetAllArbitres();

        /// <summary>
        /// Permet de récupérer toutes les réservations existanteZs
        /// </summary>
        /// <returns>La liste des réservations</returns>
        IList<IReservation> GetAllReservations();

        /// <summary>
        /// Permet d'ajouter un match
        /// </summary>
        /// <param name="match">Instance du match à ajouter</param>
        void AddMatch(IMatch match);

        /// <summary>
        /// Permet de supprimer un match
        /// </summary>
        /// <param name="match">Instance du match à supprimer</param>
        void DeleteMatch(IMatch match);
        
        /// <summary>
        /// Permet d'obtenir toutes les reservations associés à un match
        /// </summary>
        /// <param name="idMatch">Identifiant d'un match</param>
        /// <returns>Liste des réservations</returns>
        IList<IReservation> GetReservationForOneMatch(int idMatch);

        /// <summary>
        /// Permet d'ajouter une réservation
        /// </summary>
        /// <param name="reservation">Instance de la réservation à ajouter</param>
        /// <param name="idMatch">Identifiant du match pour la réservation</param>
        void AddReservation(IReservation reservation, int idMatch);

        #endregion
    }
}
