using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchBusinessLayer;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Permet de gérer le modèle de la partie MVVM
    /// </summary>
    internal class ModelManager
    {
        #region Fields

        /// <summary>
        /// Les matches contenus dans le model allant être affichés
        /// </summary>
        private IList<IMatch> _matches;

        #endregion

        #region Properties
        
        /// <summary>
        /// Propriété d'accès en lecture aux matches 
        /// </summary>
        public IList<IMatch> Matches
        {
            get
            {
                return _matches;
            }
            private set
            {
                _matches = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant une liste de matches
        /// </summary>
        /// <param name="matches">Liste des matches à transformer</param>
        public ModelManager(IList<QuidditchBusinessLayer.IMatch> matches)
        {
            _matches = new List<IMatch>();
            matches.ToList().ForEach(match =>
            {
                _matches.Add(FabriqueMatch.FabriquerMatch(match));
            });
        }

        #endregion
    }
}
