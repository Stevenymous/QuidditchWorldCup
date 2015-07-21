using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition de la Dal Manager des Stades
    /// </summary>
    public interface IDalManagerStade
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir tous les Stades
        /// </summary>
        /// <returns>Liste des stades</returns>
        IList<IStade> ObtenirStades();

        #endregion
    }
}
