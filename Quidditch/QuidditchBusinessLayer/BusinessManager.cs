using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;
using QuidditchDataAccessLayerBaseDeDonnees;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour intention de gérer la couche business et de faire le lien avec la couche Data acces layer
    /// </summary>
    internal class BusinessManager : IBusinessManager
    {
        #region Fields

        /// <summary>
        /// Référence à une instance de CoupeManager qui gère les objets métier coupe
        /// </summary>
        private CoupeManager _coupeManager;

        /// <summary>
        /// Référence à une instance de EquipeManager qui gère les objets métier equipe
        /// </summary>
        private EquipeManager _equipeManager;

        /// <summary>
        /// Référence à une instance de StadeManager qui gère les objets métier stade
        /// </summary>
        private StadeManager _stadeManager;

        /// <summary>
        /// Référence à une instance de ArbitreManager qui gère les objets métier arbitre
        /// </summary>
        private ArbitreManager _arbitreManager;

        /// <summary>
        /// Référence à une instance de ReservationManager qui gère les objets métier réservations
        /// </summary>
        private ReservationManager _reservationManager;

        /// <summary>
        /// Référence à une instance de JoueurManager qui gère les objets métier joueurs 
        /// </summary>
        private JoueurManager _joueurManager;

        /// <summary>
        /// Référence à une instance de MatchManager qui gère les objets métier match
        /// </summary>
        private MatchManager _matchManager;
        
        /// <summary>
        /// Référence à l'instance de DalProxy qui permet de se connecter à la Data Acces Layer
        /// </summary>
        private QuidditchDataAccessLayerBaseDeDonnees.DalProxy _dalProxy;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur du BusinessManager
        /// </summary>
        public BusinessManager(string typeDal)
        {
            if (typeDal == "stub")
            {
                //_dalProxy = new QuidditchDataAccessLayer.DalProxy();
            }
            else
            {
                _dalProxy = new QuidditchDataAccessLayerBaseDeDonnees.DalProxy();
            }
            ExtractDataFromDal();
        }

        #endregion

        #region Operations

        /// <summary>
        /// Permet de récupérer les objets métier de la Dal 
        /// </summary>
        private void ExtractDataFromDal()
        {
            IList<ICoupe> coupes = new List<ICoupe>();
            IList<IMatch> matches = new List<IMatch>();
            IList<IEquipe> equipes = new List<IEquipe>();
            IList<IStade> stades = new List<IStade>();
            IList<IArbitre> arbitres = new List<IArbitre>();
            IList<IReservation> reservations = new List<IReservation>();
            IList<IJoueur> joueurs = new List<IJoueur>();

            _dalProxy.GetAllCoupes().ToList().ForEach(coupe =>
            {
                coupes.Add(FabriqueCoupe.FabriquerCoupe(coupe));
            });

            _dalProxy.GetAllMatches().ToList().ForEach(match =>
            {
                matches.Add(FabriqueMatch.FabriquerMatch(match));
            });

            _dalProxy.GetAllEquipes().ToList().ForEach(equipe =>
            {
                equipes.Add(FabriqueEquipe.FabriquerEquipe(equipe));
            });

            _dalProxy.GetAllStades().ToList().ForEach(stade =>
            {
                stades.Add(FabriqueStade.FabriquerStade(stade));
            });

            _dalProxy.GetAllJoueurs().ToList().ForEach(joueur =>
            {
                joueurs.Add(FabriqueJoueur.FabriquerJoueur(joueur));
            });

            _dalProxy.GetAllArbitres().ToList().ForEach(arbitre =>
            {
                arbitres.Add(FabriqueArbitre.FabriquerArbitre(arbitre));
            });

            _dalProxy.GetAllReservations().ToList().ForEach(reservation =>
            {
                reservations.Add(FabriqueReservation.FabriquerReservation(reservation));
            });

            _coupeManager = new CoupeManager(coupes);
            _equipeManager = new EquipeManager(equipes);
            _stadeManager = new StadeManager(stades);
            _joueurManager = new JoueurManager(joueurs);
            _arbitreManager = new ArbitreManager(arbitres);
            _reservationManager = new ReservationManager(reservations);
            _matchManager = new MatchManager(matches);
        }

        /// <summary>
        /// Permet d'obtenir toutes les coupes
        /// </summary>
        /// <returns>La liste des coupes sous forme de chaînes de caractères</returns>
        public IList<string> GetAllCoupesString()
        {
            IList<string> coupesToSend = new List<string>();
            _coupeManager.Coupes.ToList().ForEach(coupe =>
            {
                coupesToSend.Add(coupe.ToString());
            });
            return coupesToSend;
        }

        /// <summary>
        /// Permet de retourner la liste des Matches sous forme de chaines de caractères des matches prévu triés de manière croissante
        /// </summary>
        /// <returns>Une liste de chaine de caractères représentant les matches</returns>
        public IList<string> GetMatchsExpectedOrderByDate()
        {
            IList<string> matchesToDiplay = new List<string>();
            IEnumerable<IMatch> matchesSearched = null;
            _coupeManager.Coupes.ToList().ForEach(coupe =>
            {
                matchesSearched = coupe.Matches.Where(match => DateTime.Compare(match.DateDuMatch, DateTime.Now) > 0).
                    OrderBy(match => match.DateDuMatch);
            });

            if (matchesSearched != null)
            { 
                matchesSearched.ToList().ForEach(match => matchesToDiplay.Add(match.ToString()));
            }
            return matchesToDiplay;
        }

        /// <summary>
        /// Permet d'obtenir tous les stades dont au moins un match est programmé pour une coupe
        /// </summary>
        /// <returns>La liste des chaines de caractères représentant les stades</returns>
        public IList<string> GetStadeWhereAtLeastOneMatchIsExpected()
        {
            IList<string> stadeToDisplay = new List<string>();
            _coupeManager.Coupes.ToList().ForEach(coupe =>
            {
                coupe.Matches.ToList().ForEach(match => stadeToDisplay.Add(match.StadeDuMatch.ToString()));
            });
            return stadeToDisplay.Distinct().ToList();
        }

        /// <summary>
        /// Permet de récupérer les chaines de caractères représentant tous les joueurs au poste d'attrapeur ayant joués à domicile
        /// </summary>
        /// <returns>Les joueurs sous forme de chaînes de caractères</returns>
        public IList<string> GetJoueursWhoBeCatcherAndPlayedAtHome()
        {
            IList<string> joueursToDisplay = new List<string>();
            IEnumerable<IJoueur> joueursSearched = null;

            _coupeManager.Coupes.ToList().ForEach(coupe =>
            {
                var matchesInPast = coupe.Matches.Where(match => DateTime.Compare(match.DateDuMatch, DateTime.Now) < 0);
                matchesInPast.ToList().ForEach(match =>
                {
                    joueursSearched = match.EquipeDomicile.Joueurs.ToList().Where(joueur => joueur.Poste == Poste.Attrapeur);
                    joueursSearched.ToList().ForEach(joueur =>
                    {
                        joueursToDisplay.Add(joueur.ToString());
                    });
                });
            });
            return joueursToDisplay;
        }

        /// <summary>
        /// Permet de récupérer tous les joueurs sous forme de chaînes de caractères qui sont gardien est dont l'age est inférieur à 17 ans
        /// </summary>
        /// <returns>Les joueurs sous forme de chaînes de caractères</returns>
        public IList<string> GetJoueursWhoBeGardienAndBeYoungerThanSeventeen()
        {
            IList<string> joueursToDisplay = new List<string>();
            IEnumerable<IJoueur> joueursFiltered = null;

            joueursFiltered = _joueurManager.Joueurs.Where(joueur => joueur.Poste == Poste.Gardien).
                    Where(gardien => DateTime.Now.Year - gardien.DateDeNaissance.Year <= 17);

            if (joueursFiltered != null)
            {
                joueursFiltered.ToList().ForEach(joueur => joueursToDisplay.Add(joueur.ToString()));
            }    
            return joueursToDisplay;
        }

        /// <summary>
        /// Implémentation de GetAllMatches permettant de récupérer tous les matches 
        /// </summary>
        /// <returns>La liste de matches</returns>
        public IList<IMatch> GetAllMatches()
        {
            return _matchManager.Matchs;
        }

        /// <summary>
        /// Implémentation de GetAllEquipes permettant de récupérer toutes les équipes
        /// </summary>
        /// <returns>La liste des équipes</returns>
        public IList<IEquipe> GetAllEquipes()
        {
            return _equipeManager.Equipes;
        }

        /// <summary>
        /// Implémentation de GetAllStades permettant de récupérer tous les stades
        /// </summary>
        /// <returns>La liste des stades</returns>
        public IList<IStade> GetAllStades()
        {
            return _stadeManager.Stades;
        }

        /// <summary>
        /// Implémentation de GetAllCoupes permettant de récupérer toutes les coupes
        /// </summary>
        /// <returns>La liste des coupes</returns>
        public IList<ICoupe> GetAllCoupes()
        {
            return _coupeManager.Coupes;
        }

        /// <summary>
        /// Implémentation de GetAllArbitres permettant de récupérer tous les arbitres
        /// </summary>
        /// <returns>La liste des arbitres</returns>
        public IList<IArbitre> GetAllArbitres()
        {
            return _arbitreManager.Arbitres;
        }

        /// <summary>
        /// Implémentation de GetAllReservations permettant de récupérer toutes les reservations
        /// </summary>
        /// <returns>La liste des reservations</returns>
        public IList<IReservation> GetAllReservations()
        {
            return _reservationManager.Reservations;
        }
        
        /// <summary>
        /// Permet d'ajouter un match
        /// </summary>
        /// <param name="match">Instance du match à ajouter</param>
        public void AddMatch(IMatch match)
        {
            _dalProxy.AddMatch(FabriqueMatch.FabriquerMatch(match));
        }

        /// <summary>
        /// Permet de supprimer un match
        /// </summary>
        /// <param name="match">Instance du match à supprimer</param>
        public void DeleteMatch(IMatch match)
        {
            _dalProxy.DeleteMatch(FabriqueMatch.FabriquerMatch(match));
        }

        /// <summary>
        /// Permet d'obtenir toutes les reservations associées à un match
        /// </summary>
        /// <param name="idMatch">Identifiant d'un match</param>
        /// <returns>Liste des réservations</returns>
        public IList<IReservation> GetReservationForOneMatch(int idMatch)
        {
            IList<IReservation> reservations = new List<IReservation>();
            _dalProxy.GetReservationForOneMatch(idMatch).ToList().ForEach(reservation =>
            {
                reservations.Add(FabriqueReservation.FabriquerReservation(reservation));
            });
            return reservations;
        }

        /// <summary>
        /// Permet d'ajouter une réservation
        /// </summary>
        /// <param name="reservation">Instance de la réservation à ajouter</param>
        public void AddReservation(IReservation reservation, int idMatch)
        {
            if (_dalProxy.AddReservation(FabriqueReservation.FabriquerReservation(reservation), idMatch) == -1)
            {
                throw new MatchOverbookException();
            }
        }

        #endregion

    }
}
