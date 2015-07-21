using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition de la Dal Manager des Coupes
    /// </summary>
    public interface IDalManagerCoupe
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir toutes les Coupes
        /// </summary>
        /// <returns>Liste des coupes</returns>
        IList<ICoupe> ObtenirCoupes();

        #endregion
    }
}
