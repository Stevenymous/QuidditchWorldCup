using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition de la DalManager de Joueurs
    /// </summary>
    public interface IDalManagerJoueur
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir tous les joueurs
        /// </summary>
        /// <returns>Liste des joueurs</returns>
        IList<IJoueur> ObtenirJoueurs();

        #endregion
    }
}
