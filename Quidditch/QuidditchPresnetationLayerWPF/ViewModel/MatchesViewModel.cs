using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using QuidditchBusinessLayer;

namespace QuidditchPresentationLayerWPF.ViewModel
{
    /// <summary>
    /// Mise en forme des matches pour la vue 
    /// </summary>
    internal class MatchesViewModel : ViewModelBase
    {
        #region Fields

        /// <summary>
        /// Collection pouvant être affichée de matches
        /// </summary>
        private ObservableCollection<MatchViewModel> _matches;

        /// <summary>
        /// Collection d'équipes pouvant jouer un match
        /// </summary>
        private ObservableCollection<IEquipe> _equipes;

        /// <summary>
        /// Collection des stades
        /// </summary>
        private ObservableCollection<IStade> _stades;

        /// <summary>
        /// Collection des arbitres
        /// </summary>
        private ObservableCollection<IArbitre> _arbitres;

        /// <summary>
        /// Match allant être créé
        /// </summary>
        private MatchViewModel _matchCreate;

        /// <summary>
        /// Référence sur le MatchViewModel sélectionné
        /// </summary>
        private MatchViewModel _selectedItem;

        /// <summary>
        /// Commande permettant d'ajouter un match
        /// </summary>
        private ICommand _ajouterMatch;

        /// <summary>
        /// Commande permettant de supprimer un match
        /// </summary>
        private ICommand _supprimerMatch;

        /// <summary>
        /// Si on peut supprimer un match ou non
        /// </summary>
        private bool _canExecuteSupprimerMatch;

        #endregion

        #region Properties

        /// <summary>
        /// Accès en lecture à la collection observable des matches 
        /// </summary>
        public ObservableCollection<MatchViewModel> Matches
        {
            get
            {
                return _matches;
            }
            private set
            {
                _matches = value;
                OnPropertyChanged("Matches");
            }
        }

        /// <summary>
        /// Accès en lecture à la collection observable des equipes
        /// </summary>
        public ObservableCollection<IEquipe> Equipes
        {
            get
            {
                return _equipes;
            }
        }

        /// <summary>
        /// Accès en lecture à la collection observable des stades
        /// </summary>
        public ObservableCollection<IStade> Stades
        {
            get
            {
                return _stades;
            }
        }

        /// <summary>
        /// Accès en lecture à la collection observable des arbitres
        /// </summary>
        public ObservableCollection<IArbitre> Arbitres
        {
            get
            {
                return _arbitres;
            }
        }

        /// <summary>
        /// Propriété bindée à la vue pour créer un objet MatchViewModel
        /// </summary>
        public MatchViewModel MatchCreate
        {
            get
            {
                if (_matchCreate == null)
                {
                    _matchCreate = new MatchViewModel();
                    _matchCreate.DateMatch = DateTime.Now;
                }
                return _matchCreate; 
            }
            set
            {
                _matchCreate = value;
                OnPropertyChanged("MatchCreate");
            }
        }

        /// <summary>
        /// Accès en lecture et écriture au match sélectionné
        /// </summary>
        public MatchViewModel SelectedItemMatch
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if (value != null)
                { 
                    _canExecuteSupprimerMatch = true;
                    _selectedItem = value;
                    OnPropertyChanged("SelectedItemMatch");
                }
            }
        }

        /// <summary>
        /// Prorpriété d'accès à la commande permettant d'ajouter un match
        /// </summary>
        public ICommand AjouterMatch
        {
            get
            {
                if (_ajouterMatch == null)
                {
                    _ajouterMatch = new RelayCommand(() => AjouterMatchCommand(), () => CanAjouterMatch());
                }
                return _ajouterMatch; 
            }
        }

        /// <summary>
        /// Propriété d'accès lecture/écriture sur la possiblité de supprimer un match
        /// </summary>
        public bool CanExecuteRemoveMatch
        {
            get
            {
                return _canExecuteSupprimerMatch;
            }
            set
            {
                _canExecuteSupprimerMatch = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture à la commande de suppression d'un match
        /// </summary>
        public ICommand SupprimerMatch
        {
            get
            {
                if (_supprimerMatch == null)
                {
                    _supprimerMatch = new RelayCommand(() => SupprimerMatchCommand(), () => CanExecuteRemoveMatch);
                }
                return _supprimerMatch;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur de MatchesViewModel prennant en paramètre les matches du model à afficher
        /// </summary>
        /// <param name="matches">Matches à afficher</param>
        /// <param name="equipes">Equipes à choisir</param>
        /// <param name="stades">Stade à choisir</param>
        public MatchesViewModel(IList<IMatch> matches, IList<IEquipe> equipes, IList<IStade> stades, IList<IArbitre> arbitres)
        {
            _matches = new ObservableCollection<MatchViewModel>();
            _equipes = new ObservableCollection<IEquipe>();
            _stades = new ObservableCollection<IStade>();
            _arbitres = new ObservableCollection<IArbitre>();
            matches.ToList().ForEach(match =>
            {
                _matches.Add(new MatchViewModel(match));
            });
            equipes.ToList().ForEach(equipe =>
            {
                _equipes.Add(equipe);
            });
            stades.ToList().ForEach(stade =>
            {
                _stades.Add(stade);
            });
            arbitres.ToList().ForEach(arbitre =>
            {
                _arbitres.Add(arbitre);
            });
            _canExecuteSupprimerMatch = false;
        }

        #endregion

        #region Operations

        /// <summary>
        /// Commande d'ajout d'un match
        /// </summary>
        private void AjouterMatchCommand()
        {
            Matches.Add(MatchCreate);
            IBusinessManager businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
            businessManager.AddMatch(FabriqueMatch.FabriquerMatch(MatchCreate.Match));
        }

        /// <summary>
        /// Commande de supression d'un match
        /// </summary>
        private void SupprimerMatchCommand()
        {
            Matches.Remove(SelectedItemMatch);
            IBusinessManager businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
            businessManager.DeleteMatch(FabriqueMatch.FabriquerMatch(SelectedItemMatch.Match));
        }
        
        /// <summary>
        /// Indique si la commande est éxecutable
        /// </summary>
        /// <returns>Vrai si elle est exécutable</returns>
        private bool CanAjouterMatch()
        {
            return true;
        }

        #endregion
    }
}
