using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition de la DalManager de Arbitre 
    /// </summary>
    public interface IDalManagerArbitre
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir tous les arbitres
        /// </summary>
        /// <returns>Liste des arbitres</returns>
        IList<IArbitre> ObtenirArbitres();

        #endregion
    }
}
