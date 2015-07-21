using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Fabrique des instances de Coupe 
    /// </summary>
    internal static class FabriqueCoupe
    {
        #region Operations

        /// <summary>
        /// Fabrique le ICoupe de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="coupe">Coupe de la QuidditchDataAccessLayer</param>
        /// <returns>La coupe pour la QuidditchBusinessLayer</returns>
        public static ICoupe FabriquerCoupe(QuidditchDataAccessLayer.ICoupe coupe)
        {
            IList<IMatch> matches = new List<IMatch>();
            coupe.Matches.ToList().ForEach(match => {
                matches.Add(FabriqueMatch.FabriquerMatch(match));
            });
            return new Coupe(coupe.Identifiant, coupe.DateDeLaCoupe, matches);
        }

        /// <summary>
        /// Fabrique le ICoupe de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="coupe">Coupe de la QuidditchDataAccessLayerBaseDeDonnees</param>
        /// <returns>La coupe pour la QuidditchBusinessLayer</returns>
        public static ICoupe FabriquerCoupe(QuidditchDataAccessLayerBaseDeDonnees.ICoupe coupe)
        {
            IList<IMatch> matches = new List<IMatch>();
            coupe.Matches.ToList().ForEach(match =>
            {
                matches.Add(FabriqueMatch.FabriquerMatch(match));
            });
            return new Coupe(coupe.Identifiant, coupe.DateDeLaCoupe, matches);
        }

        #endregion
    }
}
