using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition de la DalManager d'Equipes
    /// </summary>
    public interface IDalManagerEquipe
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir toutes les équipes
        /// </summary>
        /// <returns>Liste des équipes</returns>
        IList<IEquipe> ObtenirEquipes();

        #endregion
    }
}
