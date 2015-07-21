using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Classe permettant de créer une instance des classes implémentant ICoupe
    /// </summary>
    internal static class FabriqueCoupe
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de ICoupe
        /// </summary>
        /// <returns>L'instance d'une coupe</returns>
        public static ICoupe CreerCoupe(int identifiant, string dateDeLaCoupe, IList<IMatch> matches)
        {
            return new Coupe(identifiant, Convert.ToDateTime(dateDeLaCoupe), matches);
        }

        #endregion
    }
}
