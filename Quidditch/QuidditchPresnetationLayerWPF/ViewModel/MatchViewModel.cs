using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF.ViewModel
{
    /// <summary>
    /// Encapsulation de l'objet Match pour la vue
    /// </summary>
    public class MatchViewModel : ViewModelBase
    {
        #region Fields

        /// <summary>
        /// Match encapsulé
        /// </summary>
        private IMatch _match;

        #endregion

        #region Properties
        
        /// <summary>
        /// Propriété d'accès au match encapsulé
        /// </summary>
        public IMatch Match
        {
            get
            {
                return _match;
            }
            set
            {
                _match = value;
                     
            }
        }

        /// <summary>
        /// Propriété bindée sur la date du match
        /// </summary>
        public DateTime DateMatch
        {
            get
            {
                return Match.DateDuMatch;
            }
            set
            {
                Match.DateDuMatch = value;
                OnPropertyChanged("DateMatch");
            }
        }

        /// <summary>
        /// Propriété bindée sur l'équipe jouant à domcile
        /// </summary>
        public IEquipe EquipeDomicile
        {
            get
            {
                return Match.EquipeDomicile;
            }
            set
            {
                Match.EquipeDomicile = value;
                OnPropertyChanged("EquipeDomicile");
            }
        }

        /// <summary>
        /// Propriété bindée sur l'équipe jouant en tant que visiteur
        /// </summary>
        public IEquipe EquipeVisiteur
        {
            get
            {
                return Match.EquipeVisiteur;
            }
            set
            {
                Match.EquipeVisiteur = value;
                OnPropertyChanged("EquipeVisiteur");
            }
        }

        /// <summary>
        /// Propriété bindée sur le stade du match
        /// </summary>
        public IStade StadeMatch
        {
            get
            {
                return Match.StadeDuMatch;
            }
            set
            {
                Match.StadeDuMatch = value;
                OnPropertyChanged("StadeMatch");
            }
        }

        /// <summary>
        /// Propriété bindée sur le score à domicile
        /// </summary>
        public string ScoreDomicile
        {
            get
            {
                return Convert.ToString(Match.ScoreEquipeDomicile);
            }
            set
            {
                Match.ScoreEquipeDomicile = Convert.ToInt32(value);
                OnPropertyChanged("ScoreDomicile");
            }
        }

        /// <summary>
        /// Propriété bindée sur le score à visiteur
        /// </summary>
        public string ScoreVisiteur
        {
            get
            {
                return Convert.ToString(Match.ScoreEquipeVisiteur);
            }
            set
            {
                Match.ScoreEquipeVisiteur = Convert.ToInt32(value);
                OnPropertyChanged("ScoreVisiteur");
            }
        }

        /// <summary>
        /// Propriété bindée sur l'arbitre du match
        /// </summary>
        public IArbitre Arbitre
        {
            get
            {
                return Match.ArbitreDuMatch;
            }
            set
            {
                Match.ArbitreDuMatch = value;
                OnPropertyChanged("Arbitre");
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public MatchViewModel()
        {
            _match = new Match();
        }

        /// <summary>
        /// Constructeur acceptant un match en argument
        /// </summary>
        /// <param name="match">Match à encapsuler</param>
        public MatchViewModel(IMatch match)
        {
            _match = match;
        }

        #endregion
    }
}
