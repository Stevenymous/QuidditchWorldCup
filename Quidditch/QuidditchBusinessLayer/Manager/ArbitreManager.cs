using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour responsabilité de gérer et contenir les objets métier Arbitre et de gérer la communications entre ces objets
    /// </summary>
    internal class ArbitreManager
    {
        #region Fields

        /// <summary>
        /// Les arbitres à gérer
        /// </summary>
        private IList<IArbitre> _arbitres;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture à la liste des arbitres
        /// </summary>
        public IList<IArbitre> Arbitres
        {
            get { return _arbitres; }
            set { _arbitres = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant un argument
        /// <param name="arbitres">Liste des arbitres à encapsuler</param>
        /// </summary>
        public ArbitreManager(IList<IArbitre> arbitres)
        {
            Arbitres = arbitres;
        }

        #endregion
    }
}
