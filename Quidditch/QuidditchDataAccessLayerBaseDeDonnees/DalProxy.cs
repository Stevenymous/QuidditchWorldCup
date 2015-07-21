using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Permet de faire le lien avec la partie Data Acces Layer de l'application et la partie Business
    /// </summary>
    public class DalProxy
    {
        #region Fields

        /// <summary>
        /// Référence sur la DalManager pourvant être utilisé
        /// </summary>
        private IDalManager _dalManager;

        /// <summary>
        /// Référence sur l'adaptateur de données 
        /// </summary>
        private IDataAdapter _dataAdapter;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture et en écriture à la DalManager
        /// </summary>
        internal IDalManager DalManager
        {
            get
            {
                return _dalManager;
            }
            set
            {
                _dalManager = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture et en écriture au Data Adapter
        /// </summary>
        internal IDataAdapter DataAdapter
        {
            get
            {
                return _dataAdapter;
            }
            set
            {
                _dataAdapter = value;
            }
        }

        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur par défaut de la DalProxy
        /// </summary>
        public DalProxy()
	    {
            DalManager = new DalManager();
            DataAdapter = new DataAdapterSql();
	    }

        #endregion

        #region Operations

        /// <summary>
        /// Permet d'obtenir tous les matches
        /// </summary>
        /// <returns>Une instance de IList<IMatch></returns>
        public IList<IMatch> GetAllMatches()
        {
            IList<IMatch> matches = new List<IMatch>();

            foreach (DataRow ligne in DalManager.GetAllMatches().Rows)
            {
                IMatch matchToAdd = DataAdapter.TransformRowInMatch(ligne);
                IList<IReservation> reservations = new List<IReservation>();

                foreach (DataRow ligneReservation in DalManager.GetAllReservationForOneMatch(matchToAdd.Identifiant).Rows)
                {
                    reservations.Add(DataAdapter.TransformRowInReservation(ligneReservation));
                }
                matchToAdd.ReservationsPourLeMatch = reservations;
                matchToAdd.ArbitreDuMatch = DataAdapter.TransformRowInArbitre(
                    DalManager.GetOneArbitreFromMatch(matchToAdd.Identifiant).Rows[0]);
                matchToAdd.StadeDuMatch = DataAdapter.TransformRowInStade(
                    DalManager.GetOneStadeFromMatch(matchToAdd.Identifiant).Rows[0]);

                matchToAdd.EquipeDomicile = DataAdapter.TransformRowInEquipe(
                        DalManager.GetOneEquipeDomicileFromMatch(matchToAdd.Identifiant).Rows[0]);
                IList<IJoueur> joueursDomicile = new List<IJoueur>();
                foreach (DataRow ligneJoueur in DalManager.GetAllJoueursFromOneEquipe(matchToAdd.EquipeDomicile.Identifiant).Rows)
                {
                    joueursDomicile.Add(DataAdapter.TransformRowInJoueur(ligneJoueur));
                }
                matchToAdd.EquipeDomicile.Joueurs = joueursDomicile;

                matchToAdd.EquipeVisiteur = DataAdapter.TransformRowInEquipe(
                    DalManager.GetOneEquipeVisiteurFromMatch(matchToAdd.Identifiant).Rows[0]);
                IList<IJoueur> joueursVisiteur = new List<IJoueur>();
                foreach (DataRow ligneJoueur in DalManager.GetAllJoueursFromOneEquipe(matchToAdd.EquipeVisiteur.Identifiant).Rows)
                {
                    joueursVisiteur.Add(DataAdapter.TransformRowInJoueur(ligneJoueur));
                }
                matchToAdd.EquipeVisiteur.Joueurs = joueursVisiteur;
                matches.Add(matchToAdd);
            }
            return matches;
        }

        /// <summary>
        /// Permet d'obtenir tous les joueurs
        /// </summary>
        /// <returns>Une instance de IList<IJoueur></returns>
        public IList<IJoueur> GetAllJoueurs()
        {
            IList<IJoueur> joueurs = new List<IJoueur>();
            foreach (DataRow ligne in DalManager.GetAllJoueurs().Rows)
            {
                joueurs.Add(DataAdapter.TransformRowInJoueur(ligne));
            }
            return joueurs;
        }

        /// <summary>
        /// Permet d'obtenir toutes les équipes
        /// </summary>
        /// <returns>Une instance de IList<IEquipe></returns>
        public IList<IEquipe> GetAllEquipes()
        {
            IList<IEquipe> equipes = new List<IEquipe>();
            foreach (DataRow ligne in DalManager.GetAllEquipes().Rows)
            { 
                IEquipe equipeToAdd = DataAdapter.TransformRowInEquipe(ligne);
                IList<IJoueur> joueurs = new List<IJoueur>();

                foreach (DataRow ligneJoueur in DalManager.GetAllJoueursFromOneEquipe(equipeToAdd.Identifiant).Rows)
                {
                    joueurs.Add(DataAdapter.TransformRowInJoueur(ligneJoueur));
                }
                equipeToAdd.Joueurs = joueurs;
                equipes.Add(equipeToAdd);
                 
            }
            return equipes;
        }

        /// <summary>
        /// Permet d'obtenir toutes les coupes
        /// </summary>
        /// <returns>Une instance de IList<ICoupe></returns>
        public IList<ICoupe> GetAllCoupes()
        {
            IList<ICoupe> coupes = new List<ICoupe>();

            foreach (DataRow ligne in DalManager.GetAllCoupes().Rows)
            {
                ICoupe coupeToAdd = DataAdapter.TransformRowInCoupe(ligne);
                IList<IMatch> matches = new List<IMatch>();

                foreach (DataRow ligneMatch in DalManager.GetAllMatchForOneCoupe(coupeToAdd.Identifiant).Rows)
                {
                    IMatch matchToAdd = DataAdapter.TransformRowInMatch(ligneMatch);
                    IList<IReservation> reservations = new List<IReservation>();

                    foreach (DataRow ligneReservation in DalManager.GetAllReservationForOneMatch(matchToAdd.Identifiant).Rows)
                    {
                        reservations.Add(DataAdapter.TransformRowInReservation(ligneReservation));
                    }
                    matchToAdd.ReservationsPourLeMatch = reservations;
                    matchToAdd.ArbitreDuMatch = DataAdapter.TransformRowInArbitre(
                        DalManager.GetOneArbitreFromMatch(matchToAdd.Identifiant).Rows[0]);
                    matchToAdd.StadeDuMatch = DataAdapter.TransformRowInStade(
                        DalManager.GetOneStadeFromMatch(matchToAdd.Identifiant).Rows[0]);

                    matchToAdd.EquipeDomicile = DataAdapter.TransformRowInEquipe(
                        DalManager.GetOneEquipeDomicileFromMatch(matchToAdd.Identifiant).Rows[0]);
                    IList<IJoueur> joueursDomicile = new List<IJoueur>();
                    foreach (DataRow ligneJoueur in DalManager.GetAllJoueursFromOneEquipe(matchToAdd.EquipeDomicile.Identifiant).Rows)
                    {
                        joueursDomicile.Add(DataAdapter.TransformRowInJoueur(ligneJoueur));
                    }
                    matchToAdd.EquipeDomicile.Joueurs = joueursDomicile;

                    matchToAdd.EquipeVisiteur = DataAdapter.TransformRowInEquipe(
                        DalManager.GetOneEquipeVisiteurFromMatch(matchToAdd.Identifiant).Rows[0]);
                    IList<IJoueur> joueursVisiteur = new List<IJoueur>();
                    foreach (DataRow ligneJoueur in DalManager.GetAllJoueursFromOneEquipe(matchToAdd.EquipeVisiteur.Identifiant).Rows)
                    {
                        joueursVisiteur.Add(DataAdapter.TransformRowInJoueur(ligneJoueur));
                    }
                    matchToAdd.EquipeVisiteur.Joueurs = joueursVisiteur;

                    matches.Add(matchToAdd);
                }
                coupeToAdd.Matches = matches;
                coupes.Add(coupeToAdd);
            }
            return coupes;
        }

        /// <summary>
        /// Permet d'obtenir tous les arbitres
        /// </summary>
        /// <returns>Une instance de IList<IArbitre></returns>
        public IList<IArbitre> GetAllArbitres()
        {
            IList<IArbitre> arbitres = new List<IArbitre>();
            foreach(DataRow ligne in DalManager.GetAllArbitres().Rows)
            {
                arbitres.Add(DataAdapter.TransformRowInArbitre(ligne));
            }
            return arbitres;
        }

        /// <summary>
        /// Permet d'obtenir tous les stades
        /// </summary>
        /// <returns>Une instance de IList<IStade></returns>
        public IList<IStade> GetAllStades()
        {
            IList<IStade> stades = new List<IStade>();
            foreach(DataRow ligne in DalManager.GetAllStades().Rows)
            {
                stades.Add(DataAdapter.TransformRowInStade(ligne));
            }
            return stades;
        }

        /// <summary>
        /// Permet d'obtenir toutes les réservations 
        /// </summary>
        /// <returns>Une instance de IList<IReservation></returns>
        public IList<IReservation> GetAllReservations()
        {
            IList<IReservation> reservations = new List<IReservation>();
            foreach(DataRow ligne in DalManager.GetAllReservations().Rows)
            {
                reservations.Add(DataAdapter.TransformRowInReservation(ligne));
            }
            return reservations;
        }

        /// <summary>
        /// Permet de récupérer l'ensemble les réservations pour un match
        /// </summary>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>une liste de Reservation</returns>
        public IList<IReservation> GetReservationForOneMatch(int idMatch)
        {
            IList<IReservation> reservations = new List<IReservation>();
            foreach(DataRow ligne in DalManager.GetAllReservationForOneMatch(idMatch).Rows)
            {
                reservations.Add(DataAdapter.TransformRowInReservation(ligne));
            }
            return reservations;
        }

        /// <summary>
        /// Permet d'obtenir tous les spectateurs
        /// </summary>
        /// <returns>Une instance de IList<ISpectateur></returns>
        public IList<ISpectateur> GetAllSpectateurs()
        {
            IList<ISpectateur> spectateurs = new List<ISpectateur>();
            foreach (DataRow ligne in DalManager.GetAllSpectateur().Rows)
            {
                ISpectateur spectateurToAdd = DataAdapter.TransformRowInSpectateur(ligne);
                IList<IReservation> reservations = new List<IReservation>();

                foreach (DataRow ligneReservation in DalManager.GetAllReservationForOneSpectateur(spectateurToAdd.Identifiant).Rows)
                {
                    reservations.Add(DataAdapter.TransformRowInReservation(ligneReservation));
                }
                spectateurToAdd.Reservations = reservations;
                spectateurs.Add(spectateurToAdd);
            }
            return spectateurs;
        }

        /// <summary>
        /// Permet d'ajouter un match
        /// </summary>
        /// <param name="match">Match à ajouter</param>
        /// <returns>Retourne le nombre de ligne ajouté</returns>
        public int AddMatch(IMatch match)
        {
            return DalManager.AddMatch(match);
        }

        /// <summary>
        /// Permet de supprimer un match
        /// </summary>
        /// <param name="match">Match à supprimer</param>
        /// <returns>Retourne le nombre de ligne supprimé</returns>
        public int DeleteMatch(IMatch match)
        {
            return DalManager.DeleteMatch(match);
        }

        /// <summary>
        /// Permet d'ajouter une réservation
        /// </summary>
        /// <param name="reservation">Réservation à ajouter</param>
        /// <param name="idMatch">Identifiant du match</param>
        /// <returns>0 si l'ajout s'est fait correctement, -1 si non</returns>
        public int AddReservation(IReservation reservation, int idMatch)
        {
            return DalManager.AddReservation(reservation, idMatch);
        }

        #endregion
    }
}
