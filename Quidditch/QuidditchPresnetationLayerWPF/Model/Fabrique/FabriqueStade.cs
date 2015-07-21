using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchBusinessLayer;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Fabrique des instances de IStade
    /// </summary>
    internal static class FabriqueStade
    {
        #region Operations
       
        /// <summary>
        /// Fabrique le IStade de la QuidditchPresentationLayerWPF
        /// </summary>
        /// <param name="stade">Stade de la businessLayer</param>
        /// <returns>Le stade pour la présentation layer</returns>
        public static IStade FabriquerStade(QuidditchBusinessLayer.IStade stade)
        {
            return new Stade(stade.Identifiant, stade.Nom, stade.Adresse, stade.NombreDePlace, stade.Commission);
        }

        /// <summary>
        /// Fabrique le IStade de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="stade">Stade de la QuidditchPresentationLayerWPF</param>
        /// <returns>Le stade pour la QuidditchBusinessLayer</returns>
        public static QuidditchBusinessLayer.IStade FabriquerStade(IStade stade)
        {
            return new StadeBusiness(stade.Identifiant, stade.Nom, stade.Adresse, stade.NombreDePlace, stade.Commission);
        }
        #endregion
    }
}
