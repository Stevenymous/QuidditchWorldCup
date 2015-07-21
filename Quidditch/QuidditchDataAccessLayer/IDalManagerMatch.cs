using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition de la Dal Manager des Matchs
    /// </summary>
    public interface IDalManagerMatch
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir tous les Matchs
        /// </summary>
        /// <returns>Liste des matchs</returns>
        IList<IMatch> ObtenirMatches();

        #endregion
    }
}
