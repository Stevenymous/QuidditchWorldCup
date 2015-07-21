using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
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
        /// <param name="identifiant">Identifiant de la coupe sous forme de chaîne de caractères</param>
        /// <param name="dateDeLaCoupe">Date de la coupe sous forme de chaîne de caractères</param>
        /// <param name="matches">Matches joués pendant la coupe</param>
        /// <returns>L'instance d'une coupe</returns>
        public static ICoupe CreerCoupe(string identifiant, string dateDeLaCoupe, IList<IMatch> matches)
        {
            return new Coupe(Convert.ToInt32(identifiant), Convert.ToDateTime(dateDeLaCoupe), matches);
        }

        #endregion
    }
}
