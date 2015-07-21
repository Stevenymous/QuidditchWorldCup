using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Fabrique des instances de IArbitre
    /// </summary>
    internal static class FabriqueArbitre
    {
        #region Operations

        /// <summary>
        /// Fabrique le IArbitre de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="arbitre">Arbitre de la DataAccessLayer</param>
        /// <returns>L'arbitre pour la QuidditchBusinessLayer</returns>
        public static IArbitre FabriquerArbitre(QuidditchDataAccessLayer.IArbitre arbitre)
        {
            return new Arbitre(arbitre.Identifiant, arbitre.Prenom, arbitre.Nom, arbitre.DateDeNaissance, 
                arbitre.NumeroAssuranceVie);
        }

        /// <summary>
        /// Fabrique le IArbitre de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="arbitre">Arbitre de la QuidditchDataAccessLayerBaseDeDonnees</param>
        /// <returns>L'arbitre pour la QuidditchBusinessLayer</returns>
        public static IArbitre FabriquerArbitre(QuidditchDataAccessLayerBaseDeDonnees.IArbitre arbitre)
        {
            return new Arbitre(arbitre.Identifiant, arbitre.Prenom, arbitre.Nom, arbitre.DateDeNaissance,
                arbitre.NumeroAssuranceVie);
        }

        /// <summary>
        /// Fabrique le IArbitre de la QuidditchDataAccessLayerBaseDeDonnees
        /// </summary>
        /// <param name="arbitre">Arbitre de la QuidditchBusinessLayer</param>
        /// <returns>L'arbitre pour la QuidditchDataAccessLayerBaseDeDonnees</returns>
        public static QuidditchDataAccessLayerBaseDeDonnees.IArbitre FabriquerArbitre(IArbitre arbitre)
        {
            return new ArbitreDal(arbitre.Identifiant, arbitre.Prenom, arbitre.Nom, arbitre.DateDeNaissance,
                arbitre.NumeroAssuranceVie);
        }

        #endregion
    }
}
