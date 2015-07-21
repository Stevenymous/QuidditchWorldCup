using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Permet de faire le lien avec la partie Data Acces Layer de l'application
    /// </summary>
    public class DalProxy
    {
        #region Fields

        /// <summary>
        /// Liste des coupes avec tous les objets encapsulés (Matches, équipes, etc)
        /// </summary>
        private IList<ICoupe> _coupes;

        /// <summary>
        /// Liste des équipes avec tous les objets encapsulés
        /// </summary>
        private IList<IEquipe> _equipes;

        /// <summary>
        /// Liste des joueurs 
        /// </summary>
        private IList<IJoueur> _joueurs;

        /// <summary>
        /// Liste des stades 
        /// </summary>
        private IList<IStade> _stades;

        /// <summary>
        /// Liste des matches avec tous les objets encapsulés
        /// </summary>
        private IList<IMatch> _matches;

        /// <summary>
        /// Liste des arbitre 
        /// </summary>
        private IList<IArbitre> _arbitres;

        /// <summary>
        /// Liste des réservations 
        /// </summary>
        private IList<IReservation> _reservations;

        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur du DalProxy 
        /// </summary>
        public DalProxy()
        {
            _coupes = new List<ICoupe>();
            _equipes = new List<IEquipe>();
            _stades = new List<IStade>();
            _joueurs = new List<IJoueur>();
            _matches = new List<IMatch>();
            _arbitres = new List<IArbitre>();
            _reservations = new List<IReservation>();
            SetInteractionsBetweenObjectsInDal();
        }

        #endregion

        #region Operations

        /// <summary>
        /// Transforme les objets de la dal simulées pour les rendres utilisables par d'autres couches
        /// </summary>
        private void SetInteractionsBetweenObjectsInDal()
        {
            IDalManagerCoupe dalManagerCoupe = new StubDalManagerCoupe();
            IDalManagerMatch dalManagerMatch = new StubDalManagerMatch();
            IDalManagerEquipe dalManagerEquipe = new StubDalManagerEquipe();
            IDalManagerJoueur dalManagerJoueur = new StubDalManagerJoueur();
            IDalManagerStade dalManagerStade = new StubDalManagerStade();
            IDalManagerArbitre dalManagerArbitre = new StubDalManagerArbitre();
            IDalManagerReservation dalManagerReservation = new StubDalManagerReservation();

            IList<ICoupe> coupes = dalManagerCoupe.ObtenirCoupes(); 
            IList<IEquipe> equipes = dalManagerEquipe.ObtenirEquipes(); 
            IList<IMatch> matches = dalManagerMatch.ObtenirMatches(); 
            IList<IStade> stades = dalManagerStade.ObtenirStades(); 
            IList<IJoueur> joueurs = dalManagerJoueur.ObtenirJoueurs(); 
            IList<IArbitre> arbitres = dalManagerArbitre.ObtenirArbitres();
            IList<IReservation> reservations = dalManagerReservation.ObtenirReservations();

            var joueursEquipeJeanBonBeur = joueurs.Where(joueur => joueur.Identifiant < 7);
            var joueursEquipeCroustiBats = joueurs.Where(joueur => joueur.Identifiant >= 7);

            equipes[0].Joueurs = joueursEquipeJeanBonBeur.ToList();
            equipes[1].Joueurs = joueursEquipeCroustiBats.ToList();

            var reservationsMatch1 = reservations.Where(reservation => reservation.Identifiant < 2);
            var reservationsMatch2 = reservations.Where(reservation => reservation.Identifiant >= 2);

            matches[0].EquipeDomicile = equipes[0];
            matches[0].EquipeVisiteur = equipes[1];
            matches[0].StadeDuMatch = stades[0];
            matches[0].ArbitreDuMatch = arbitres[1];
            matches[0].ReservationsPourLeMatch = reservationsMatch1.ToList();

            matches[1].EquipeDomicile = equipes[1];
            matches[1].EquipeVisiteur = equipes[0];
            matches[1].StadeDuMatch = stades[3];
            matches[1].ArbitreDuMatch = arbitres[0];
            matches[1].ReservationsPourLeMatch = reservationsMatch2.ToList();

            coupes[0].Matches = matches.ToList();

            _coupes = coupes;
            _equipes = equipes;
            _matches = matches;
            _stades = stades;
            _arbitres = arbitres;
            _reservations = reservations;
            _joueurs = joueurs;
        }

        /// <summary>
        /// Permet d'obtenir tous les matches
        /// </summary>
        /// <returns>Une instance de IList<IMatch></returns>
        public IList<IMatch> GetAllMatches()
        {
            return _matches;
        }

        /// <summary>
        /// Permet d'obtenir tous les joueurs
        /// </summary>
        /// <returns>Une instance de IList<IJoueur></returns>
        public IList<IJoueur> GetAllJoueurs()
        {
            return _joueurs;
        }

        /// <summary>
        /// Permet d'obtenir toutes les équipes
        /// </summary>
        /// <returns>Une instance de IList<IEquipe></returns>
        public IList<IEquipe> GetAllEquipes()
        {
            return _equipes;
        }

        /// <summary>
        /// Permet d'obtenir toutes les coupes
        /// </summary>
        /// <returns>Une instance de IList<ICoupe></returns>
        public IList<ICoupe> GetAllCoupes()
        {
            return _coupes;
        }

        /// <summary>
        /// Permet d'obtenir tous les arbitres
        /// </summary>
        /// <returns>Une instance de IList<IArbitre></returns>
        public IList<IArbitre> GetAllArbitres()
        {
            return _arbitres;
        }

        /// <summary>
        /// Permet d'obtenir tous les stades
        /// </summary>
        /// <returns>Une instance de IList<IStade></returns>
        public IList<IStade> GetAllStades()
        {
            return _stades;
        }

        /// <summary>
        /// Permet d'obtenir toutes les réservations 
        /// </summary>
        /// <returns>Une instance de IList<IReservation></returns>
        public IList<IReservation> GetAllReservations()
        {
            return _reservations;
        }

        #endregion
    }
}
