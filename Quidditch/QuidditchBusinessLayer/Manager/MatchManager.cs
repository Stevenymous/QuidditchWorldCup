using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour responsabilité de gérer et contenir les objets métier Match et de gérer la communications entre ces objets
    /// </summary>
    internal class MatchManager 
    {
        #region Fields

        /// <summary>
        /// Les matches à gérer
        /// </summary>
        private IList<IMatch> _matchs;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture à la liste des matches
        /// </summary>
        public IList<IMatch> Matchs
        {
            get { return _matchs; }
            set { _matchs = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant un argument 
        /// </summary>
        /// <param name="matchs">Matches à gérer</param>
        public MatchManager(IList<IMatch> matchs)
        {
            Matchs = matchs;
        }

        #endregion
    }
}
