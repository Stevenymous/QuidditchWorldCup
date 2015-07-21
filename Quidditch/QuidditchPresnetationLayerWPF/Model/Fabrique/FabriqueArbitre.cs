using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Fabrique des instances de IArbitre 
    /// </summary>
    internal static class FabriqueArbitre
    {
        #region Operations

        /// <summary>
        /// Fabrique le IArbitre de la QuidditchPresentationLayerWPF
        /// </summary>
        /// <param name="arbitre">Arbitre de la QuidditchBusinessLayer</param>
        /// <returns>L'arbitre pour la QuidditchPresentationLayerWPF</returns>
        public static IArbitre FabriquerArbitre(QuidditchBusinessLayer.IArbitre arbitre)
        {
            return new Arbitre(arbitre.Identifiant, arbitre.Prenom, arbitre.Nom, arbitre.DateDeNaissance,
                 arbitre.NumeroAssuranceVie);
        }

        /// <summary>
        /// Fabrique le IArbitre de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="arbitre">Arbitre de la QuidditchPresentationLayerWPF</param>
        /// <returns>L'arbitre pour la QuidditchBusinessLayer</returns>
        public static QuidditchBusinessLayer.IArbitre FabriquerArbitre(IArbitre arbitre)
        {
            return new ArbitreBusiness(arbitre.Identifiant, arbitre.Prenom, arbitre.Nom, arbitre.DateDeNaissance,
                 arbitre.NumeroAssuranceVie);
        }

        #endregion
    }
}
