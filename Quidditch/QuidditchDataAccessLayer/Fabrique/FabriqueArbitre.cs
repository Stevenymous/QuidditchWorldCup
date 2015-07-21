using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Classe permettant de créer une instance des classes implémentant IArbitre
    /// </summary>
    internal static class FabriqueArbitre
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IArbitre
        /// </summary>
        /// <returns>L'instance d'un arbitre</returns>
        public static IArbitre CreerArbitre(int identifiant, string prenom, string nom, string dateDeNaissance, int numeroAssuranceVie) 
        {
            return new Arbitre(identifiant, prenom, nom, Convert.ToDateTime(dateDeNaissance), numeroAssuranceVie);
        }

        #endregion
    }
}
