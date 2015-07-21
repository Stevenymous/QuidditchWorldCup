using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Interface permettant de définir le comportement à mettre en place pour accéder aux données
    /// Interface Bridge Implémentation du pattern Bridge
    /// </summary>
    internal interface IDataAccess
    {
        /// <summary>
        /// Permet de récupérer l'ensemble des joueurs
        /// </summary>
        /// <returns>Les joueurs sous forme d'enregistrement de base de données</returns>
        DataTable FindAllJoueur();

        /// <summary>
        /// Permet de récupérer l'ensemble des joueurs d'une équipe
        /// </summary>
        /// <param name="idEquipe">Identifiant de l'équipe</param>
        /// <returns>Les joueurs sous forme d'enregistrement de base de données</returns>
        DataTable FindAllJoueurFromEquipe(int idEquipe);

        /// <summary>
        /// Permet de récupérer l'ensemble des équipes
        /// </summary>
        /// <returns>Les équipes sous forme d'enregistrement de base de données</returns>
        DataTable FindAllEquipe();

        /// <summary>
        /// Permet de récupérer une equipe jouant à domicile pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le equipe sous forme d'enregistrement de base de données</returns>
        DataTable FindOneEquipeDomicileFromMatch(int idMatch);

        /// <summary>
        /// Permet de récupérer une equipe jouant en tant que visiteur pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le equipe sous forme d'enregistrement de base de données</returns>
        DataTable FindOneEquipeVisiteurFromMatch(int idMatch);

        /// <summary>
        /// Permet de récupérer l'ensemble des Stades
        /// </summary>
        /// <returns>Les stades sous forme d'enregistrement de base de données</returns>
        DataTable FindAllStade();

        /// <summary>
        /// Permet de récupérer un stade d'un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le stade sous forme d'enregistrement de base de données</returns>
        DataTable FindOneStadeFromMatch(int idMatch);

        /// <summary>
        /// Permet de récupérer l'ensemble des Coupes
        /// </summary>
        /// <returns>Les coupes sous forme d'enregistrement de base de données</returns>
        DataTable FindAllCoupe();

        /// <summary>
        /// Permet de récupérer l'ensemble des matches pour une coupe
        /// </summary>
        /// <param name="idMatch">Identifiant de la Coupe</param>
        /// <returns>Les lignes de Match</returns>
        DataTable FindAllMatchForOneCoupe(int idCoupe);

        /// <summary>
        /// Permet de récupérer l'ensemble des matches 
        /// </summary>
        /// <returns>Les matches sous forme d'enregistrement de base de données</returns>
        DataTable FindAllMatch();

        /// <summary>
        /// Permet de récupérer l'ensemble des spectateurs
        /// </summary>
        /// <returns>Les spectateurs sous forme d'enregistrement de base de données</returns>
        DataTable FindAllSpectateur();

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations
        /// </summary>
        /// <returns>Les réservations sous forme d'enregistrement de base de données</returns>
        DataTable FindAllReservation();

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Les lignes de Reservation</returns>
        DataTable FindAllReservationForOneMatch(int idMatch);

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un spectateur
        /// </summary>
        /// <param name="idMatch">Identifiant du specateur</param>
        /// <returns>Les lignes de Reservation</returns>
        DataTable FindAllReservationForOneSpectateur(int idSpectateur);

        /// <summary>
        /// Permet de récupérer l'ensemble des arbitres
        /// </summary>
        /// <returns>Les arbitres sous forme d'enregistrement de base de données</returns>
        DataTable FindAllArbitre();

        /// <summary>
        /// Permet de récupérer un arbitre d'un match
        /// </summary>
        /// <param name="idMatch">Identifiant du Match</param>
        /// <returns>Le arbitre sous forme d'enregistrement de base de données</returns>
        DataTable FindOneArbitreFromMatch(int idMatch);

        /// <summary>
        /// Permet de connaitre le nombre de places restantes pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le résultat de la requête</returns>
        DataTable FindNumberPlaceCanBeReservedForOnMatch(int idMatch);

        /// <summary>
        /// Permet d'insérer un match
        /// </summary>
        /// <param name="match">Match à insérer</param>
        /// <returns>Résultat de la requête</returns>
        int InsertMatch(IMatch match);

        /// <summary>
        /// Permet de supprimer un match
        /// </summary>
        /// <param name="match">Match à supprimer</param>
        /// <returns>Résultat de la requête</returns>
        int DeleteMatch(IMatch match); 

        /// <summary>
        /// Permet d'insérer une réservation en base de données
        /// </summary>
        /// <param name="reservation">La réservation à insérer</param>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Retourne un entier qui est le résultat de la requête</returns>
        int InsertReservation(IReservation reservation, int idMatch);
    }
}
