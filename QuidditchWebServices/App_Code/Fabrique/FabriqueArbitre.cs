using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Fabrique des instances de QuidditchWebServices.IArbitre à partir de QuidditchBusinessLayer.IArbitre 
    /// </summary>
    internal static class FabriqueArbitre
    {
        #region Operations

        /// <summary>
        /// Fabrique le IArbitre de la QuidditchWebServices
        /// </summary>
        /// <param name="arbitre">Arbitre de la QuidditchBusinessLayer</param>
        /// <returns>Le arbitre pour la QuidditchWebServices</returns>
        public static IArbitre FabriquerArbitre(QuidditchBusinessLayer.IArbitre arbitre)
        {
            return new Arbitre(arbitre.Identifiant, arbitre.Prenom, arbitre.Nom, arbitre.DateDeNaissance,
                arbitre.NumeroAssuranceVie);
        }

        #endregion
    }
}