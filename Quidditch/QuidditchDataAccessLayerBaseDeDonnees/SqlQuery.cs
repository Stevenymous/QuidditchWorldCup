using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Classe permettant de définir les requêtes SQL à utiliser pour interroger la base de données SQLServeur
    /// </summary>
    internal static class SqlQuery
    {
        /// <summary>
        /// Requête permettant de récupérer tous les joueurs d'une équipe de la base de données
        /// </summary>
        public const string SELECT_ALL_JOUEURS_FROM_EQUIPE = "SELECT id, prenom, nom, dateNaissance, capitaine, " + 
            "nombreSelection, poste " +
            "FROM Joueur WHERE equipe_id_ref = ";

        /// <summary>
        /// Requête permettant de récupérer tous les joueurs de la base de données
        /// </summary>
        public const string SELECT_ALL_JOUEURS = "SELECT id, prenom, nom, dateNaissance, capitaine, nombreSelection, poste " +
            "FROM Joueur";

        /// <summary>
        /// Requête permettant de récupérer tous les matches de la base de données
        /// </summary>
       public const string SELECT_ALL_MATCHES = "SELECT M.id, dateMatch, scoreEquipeDomicile, scoreEquipeVisiteur, arbitre_id_ref, " +  
            "stade_id_ref, coupe_id_ref, equipeDomicile_id_ref, equipeVisiteur_id_ref " + 
            "FROM Match M, Coupe C " + 
            "WHERE C.id = M.coupe_id_ref" ;

        /// <summary>
        /// Requête permettant de récupérer tous les matches pour une coupe de la base de données
        /// </summary>
        public const string SELECT_ALL_MATCHES_FROM_ONE_COUPE = "SELECT M.id, dateMatch, scoreEquipeDomicile, scoreEquipeVisiteur " +
            "FROM Match M, Coupe C " +
            "WHERE C.id = M.coupe_id_ref AND C.id = ";

        /// <summary>
        /// Requête permettant de récupérer toutes les équipes de la base de données
        /// </summary>
        public const string SELECT_ALL_EQUIPES = "SELECT id, nom, pays FROM Equipe";

        /// <summary>
        /// Requête permettant de récupérer une équipe jouant à domicile pour un match
        /// </summary>
        public const string SELECT_ONE_EQUIPE_DOMICILE_FROM_MATCH = "SELECT E.id, nom, pays FROM Equipe E, Match M " 
            + "WHERE E.id = M.equipeDomicile_id_ref AND M.id = ";

        /// <summary>
        /// Requête permettant de récupérer une équipe jouant en tant que visiteur pour un match
        /// </summary>
        public const string SELECT_ONE_EQUIPE_VISITEUR_FROM_MATCH = "SELECT E.id, nom, pays FROM Equipe E, Match M " 
            + "WHERE E.id = M.equipeVisiteur_id_ref AND M.id = ";

        /// <summary>
        /// Requête permettant de récupérer tous les stades de la base de données
        /// </summary>
        public const string SELECT_ALL_STADES = "SELECT id, nom, adresse, nombrePlace, commission FROM Stade";

        /// <summary>
        /// Requête permettant de récupérer un stade d'un match
        /// </summary>
        public const string SELECT_ONE_STADE_FROM_MATCH = "SELECT S.id, nom, adresse, nombrePlace, commission FROM Stade S, Match M " +
            "WHERE S.id = M.stade_id_ref AND M.id = ";

        /// <summary>
        /// Requête permettant de récupérer tous les arbitres de la base de données
        /// </summary>
        public const string SELECT_ALL_ARBITRES = "SELECT id, prenom, nom, dateNaissance, numeroAssuranceVie FROM Arbitre";

        /// <summary>
        /// Requête permettant de récupérer un arbitre depuis un match
        /// </summary>
        public const string SELECT_ONE_ARBITRE_FROM_MATCH = "SELECT A.id, prenom, nom, dateNaissance, numeroAssuranceVie " +
            "FROM Arbitre A, Match M WHERE A.id = M.arbitre_id_ref AND M.id = ";

        /// <summary>
        /// Requête permettant de récupérer toutes les coupes de la base de données
        /// </summary>
        public const string SELECT_ALL_COUPES = "SELECT id, dateCoupe FROM Coupe";

        /// <summary>
        /// Requête permettant de récupérer toutes les réservations de la base de données
        /// </summary>
        public const string SELECT_ALL_RESERVATIONS = "SELECT R.id, R.place, R.prix, M.dateMatch, S.nom " +
            "FROM Reservation R, Match M, Spectateur S " +
            "WHERE R.match_id_ref = M.id AND R.spectateur_id_ref = S.id";

        /// <summary>
        /// Requête permettant de récupérer toutes les réservations pour un match depuis la base de données
        /// </summary>
        public const string SELECT_ALL_RESERVATIONS_FROM_ONE_MATCH = "SELECT R.id, R.place, R.prix " +
            "FROM Reservation R, Match M, Spectateur S " +
            "WHERE R.match_id_ref = M.id AND R.spectateur_id_ref = S.id AND R.match_id_ref = ";

        /// <summary>
        /// Requête permettant de récupérer toutes les réservations pour un spectateur depuis la base de données
        /// </summary>
        public const string SELECT_ALL_RESERVATIONS_FROM_ONE_SPECTATEUR = "SELECT R.id, R.place, R.prix " +
            "FROM Reservation R, Match M, Spectateur S " +
            "WHERE R.match_id_ref = M.id AND R.spectateur_id_ref = S.id AND S.id = ";

        /// <summary>
        /// Requête permettant de récupérer tous les spectateurs de la base de données
        /// </summary>
        public const string SELECT_ALL_SPECTATEUR = "SELECT id, nom, prenom, dateNaissance, adresse, email FROM Spectateur";

        /// <summary>
        /// Requête permettant d'insérer un match en base de données
        /// </summary>
        public const string INSERT_MATCH = "INSERT INTO Match (dateMatch, scoreEquipeDomicile, scoreEquipeVisiteur, " +
            "arbitre_id_ref, stade_id_ref, coupe_id_ref, equipeDomicile_id_ref, equipeVisiteur_id_ref) " +
            "VALUES (@dateMatch, @scoreEquipeDomicile, @scoreEquipeVisiteur, " +
            "@arbitre_id_ref, @stade_id_ref, @coupe_id_ref, @equipeDomicile_id_ref, @equipeVisiteur_id_ref)";
        
        /// <summary>
        /// Requête permettant de supprimer un match en base de données
        /// </summary>
        public const string DELETE_MATCH = "DELETE FROM Match WHERE id = @id";

        /// <summary>
        /// Requête permettant d'insérer une réservation en base de données
        /// </summary>
        public const string INSERT_RESERVATION = "INSERT INTO Reservation (place, prix, match_id_ref, spectateur_id_ref) " +
            "VALUES (@place, @prix, @match_id_ref, @spectateur_id_ref)";

        /// <summary>
        /// Requête permettant de récupérer le nombre de place restante pour un match en base de données
        /// </summary>
        public const string SELECT_NUMBER_PLACE_FOR_ONE_MATCH = "SELECT (S.nombrePlace - SUM(R.place)) AS numbrePlaceRestante " +
            "FROM Match M, Reservation R, Stade S " +
            "WHERE M.id = R.match_id_ref AND M.stade_id_ref = S.id AND M.id = ";
    }
}
