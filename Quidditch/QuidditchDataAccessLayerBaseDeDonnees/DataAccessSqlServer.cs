using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;


namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Implémentation de l'accès aux données en SQL sur une base de données SQL Serveur
    /// Classe Bridge implémentation du pattern Bridge
    /// </summary>
    internal class DataAccessSqlServer : IDataAccess
    {
        #region Constantes

        /// <summary>
        /// Constante portant sur la chaîne de caractère permettant la connexion à la base de données
        /// </summary>
        private const string _connectionString =
            @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Stephen\Travail\DotNet\Quidditch\QuidditchDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        #endregion

        #region Operations

        /// <summary>
        /// Permet de récupérer l'ensemble des joueurs
        /// </summary>
        /// <returns>Les joueurs sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllJoueur()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_JOUEURS, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des joueurs d'une équipe
        /// </summary>
        /// <param name="idEquipe">Identifiant de l'équipe</param>
        /// <returns>Les joueurs sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllJoueurFromEquipe(int idEquipe)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_JOUEURS_FROM_EQUIPE + idEquipe, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des équipes
        /// </summary>
        /// <returns>Les équipes sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllEquipe()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_EQUIPES, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des Stades
        /// </summary>
        /// <returns>Les stades sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllStade()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_STADES, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des Coupes
        /// </summary>
        /// <returns>Les coupes sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllCoupe()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_COUPES, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations
        /// </summary>
        /// <returns>Les réservations sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllReservation()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_RESERVATIONS, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des arbitres
        /// </summary>
        /// <returns>Les arbitres sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllArbitre()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_ARBITRES, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des matches 
        /// </summary>
        /// <returns>Les matches sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllMatch()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_MATCHES, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des spectateurs
        /// </summary>
        /// <returns>Les specateurs sous forme d'enregistrement de base de données</returns>
        public DataTable FindAllSpectateur()
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_SPECTATEUR, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;  
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Les lignes de Reservation</returns>
        public DataTable FindAllReservationForOneMatch(int idMatch)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_RESERVATIONS_FROM_ONE_MATCH + idMatch, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des réservations pour un spectateur
        /// </summary>
        /// <param name="idMatch">Identifiant du specateur</param>
        /// <returns>Les lignes de Reservation</returns>
        public DataTable FindAllReservationForOneSpectateur(int idSpectateur)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_RESERVATIONS_FROM_ONE_SPECTATEUR 
                    + idSpectateur, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results; 
        }

        /// <summary>
        /// Permet de récupérer l'ensemble des matches pour une coupe
        /// </summary>
        /// <param name="idMatch">Identifiant de la Coupe</param>
        /// <returns>Les lignes de Match</returns>
        public DataTable FindAllMatchForOneCoupe(int idCoupe)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ALL_MATCHES_FROM_ONE_COUPE + idCoupe, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;  
        }

        /// <summary>
        /// Permet de récupérer une equipe jouant à domicile pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>L'equipe sous forme d'enregistrement de base de données</returns>
        public DataTable FindOneEquipeDomicileFromMatch(int idMatch)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ONE_EQUIPE_DOMICILE_FROM_MATCH + idMatch, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;
        }

        /// <summary>
        /// Permet de récupérer une equipe jouant en tant que visiteur pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>L'equipe sous forme d'enregistrement de base de données</returns>
        public DataTable FindOneEquipeVisiteurFromMatch(int idMatch)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ONE_EQUIPE_VISITEUR_FROM_MATCH + idMatch, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;
        }

        /// <summary>
        /// Permet de récupérer un stade d'un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le stade sous forme d'enregistrement de base de données</returns>
        public DataTable FindOneStadeFromMatch(int idMatch)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ONE_STADE_FROM_MATCH + idMatch, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;
        }

        /// <summary>
        /// Permet de récupérer un arbitre d'un match
        /// </summary>
        /// <param name="idMatch">Identifiant du Match</param>
        /// <returns>L'arbitre sous forme d'enregistrement de base de données</returns>
        public DataTable FindOneArbitreFromMatch(int idMatch)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_ONE_ARBITRE_FROM_MATCH + idMatch, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;
        }

        /// <summary>
        /// Permet d'insérer un match
        /// </summary>
        /// <param name="match">Match à insérer</param>
        /// <returns>Résultat de la requête</returns>
        public int InsertMatch(IMatch match)
        {
            int result = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.INSERT_MATCH); 
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.AddWithValue("@dateMatch", match.DateDuMatch);
                sqlCommand.Parameters.AddWithValue("@scoreEquipeDomicile", match.ScoreEquipeDomicile);
                sqlCommand.Parameters.AddWithValue("@scoreEquipeVisiteur", match.ScoreEquipeVisiteur);
                sqlCommand.Parameters.AddWithValue("@arbitre_id_ref", match.ArbitreDuMatch.Identifiant);
                sqlCommand.Parameters.AddWithValue("@stade_id_ref", match.StadeDuMatch.Identifiant);
                sqlCommand.Parameters.AddWithValue("@coupe_id_ref", 0);
                sqlCommand.Parameters.AddWithValue("@equipeDomicile_id_ref", match.EquipeDomicile.Identifiant);
                sqlCommand.Parameters.AddWithValue("@equipeVisiteur_id_ref", match.EquipeVisiteur.Identifiant);
                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }

        /// <summary>
        /// Permet de supprimer un match
        /// </summary>
        /// <returns>Résultat de la requête</returns>
        public int DeleteMatch(IMatch match)
        {
            int result = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.DELETE_MATCH);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.AddWithValue("@id", match.Identifiant);
                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }

        /// <summary>
        /// Permet d'insérer une réservation en base de données
        /// </summary>
        /// <param name="reservation">La réservation à insérer</param>
        /// <returns>Retourne un entier qui est le résultat de la requête</returns>
        public int InsertReservation(IReservation reservation, int idMatch)
        {
            int result = 0;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.INSERT_RESERVATION);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.AddWithValue("@place", reservation.Place);
                sqlCommand.Parameters.AddWithValue("@prix", reservation.Prix);
                sqlCommand.Parameters.AddWithValue("@match_id_ref", idMatch);
                sqlCommand.Parameters.AddWithValue("@spectateur_id_ref", 0);
                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }

        /// <summary>
        /// Permet de connaitre le nombre de places restantes pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>Le résultat de la requête</returns>
        public DataTable FindNumberPlaceCanBeReservedForOnMatch(int idMatch)
        {
            DataTable results = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(SqlQuery.SELECT_NUMBER_PLACE_FOR_ONE_MATCH + idMatch + 
                    " GROUP BY M.id, S.nombrePlace",
                    sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }
            return results;
        }

        #endregion
    }
}
