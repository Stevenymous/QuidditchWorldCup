using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour responsabilité de gérer et contenir les objets métier Stade et de gérer la communications entre ces objets
    /// </summary>
    internal class StadeManager 
    {
        #region Fields

        /// <summary>
        /// Les stades à gérer
        /// </summary>
        private IList<IStade> _stades;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture à la liste des stades
        /// </summary>
        public IList<IStade> Stades
        {
            get { return _stades; }
            set { _stades = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant un argument
        /// </summary>
        /// <param name="stades">Stades à gérer</param>
        public StadeManager(IList<IStade> stades)
        {
            Stades = stades;
        }

        #endregion
    }
}
