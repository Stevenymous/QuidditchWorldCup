using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
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
        /// <param name="identifiant">Identifiant du stade sous forme de chaîne de caractères</param>
        /// <param name="nom">Nom du stade</param>
        /// <param name="adresse">Adresse du stade</param>
        /// <param name="nombrePlace">Nombre de place dans le stade</param>
        /// <param name="commission">Commission gagné par le stade pour chaque place</param>
        /// <returns>L'instance d'un stade</returns>
        public static IStade CreerStade(string identifiant, string nom, string adresse, string nombrePlace, string commission)
        {
            return new Stade(Convert.ToInt32(identifiant), nom, adresse, Convert.ToInt32(nombrePlace), 
                (float) Convert.ToDouble(commission));
        }

        #endregion
    }
}
