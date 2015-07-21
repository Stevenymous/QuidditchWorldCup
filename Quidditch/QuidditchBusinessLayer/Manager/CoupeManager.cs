using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour responsabilité de gérer et contenir les objets métier coupes et de gérer la communications entre ces objets
    /// </summary>
    internal class CoupeManager
    {
        #region Fields

        /// <summary>
        /// Les coupes à gérer
        /// </summary>
        private IList<ICoupe> _coupes;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture à la liste des coupes
        /// </summary>
        public IList<ICoupe> Coupes
        {
            get { return _coupes; }
            set { _coupes = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant un argument
        /// </summary>
        /// <param name="coupes">Les coupes à encapsuler</param>
        public CoupeManager(IList<ICoupe> coupes)
        {
            Coupes = coupes;
        }

        #endregion
    }
}
