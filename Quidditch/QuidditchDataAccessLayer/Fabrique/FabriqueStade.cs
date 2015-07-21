using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Classe permettant de créer une instance des classes implémentant IStade
    /// </summary>
    internal static class FabriqueStade
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IStade
        /// </summary>
        /// <returns>L'instance d'un stade</returns>
        public static IStade CreerStade(int identifiant, string nom, string adresse, int nombrePlace, float commission)
        {
            return new Stade(identifiant, nom, adresse, nombrePlace, commission);
        }

        #endregion
    }
}
