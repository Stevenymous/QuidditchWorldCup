using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Fabrique des instances de Stade 
    /// </summary>
    internal static class FabriqueStade
    {
        #region Operations
       
        /// <summary>
        /// Fabrique le IStade de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="stade">Stade de la QuidditchDataAccessLayer</param>
        /// <returns>Le stade pour la QuidditchBusinessLayerr</returns>
        public static IStade FabriquerStade(QuidditchDataAccessLayer.IStade stade)
        {
            return new Stade(stade.Identifiant, stade.Nom, stade.Adresse, stade.NombreDePlace, stade.Commission);
        }

        /// <summary>
        /// Fabrique le IStade de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="stade">Stade de la QuidditchDataAccessLayerBaseDeDonnees</param>
        /// <returns>Le stade pour la QuidditchBusinessLayerr</returns>
        public static IStade FabriquerStade(QuidditchDataAccessLayerBaseDeDonnees.IStade stade)
        {
            return new Stade(stade.Identifiant, stade.Nom, stade.Adresse, stade.NombreDePlace, stade.Commission);
        }

        /// <summary>
        /// Fabrique le IStade de la QuidditchDataAccessLayerBaseDeDonnees
        /// </summary>
        /// <param name="stade">Stade de la QuidditchBusinessLayer</param>
        /// <returns>Le stade pour la QuidditchDataAccessLayerBaseDeDonnees</returns>
        public static QuidditchDataAccessLayerBaseDeDonnees.IStade FabriquerStade(IStade stade)
        {
            return new StadeDal(stade.Identifiant, stade.Nom, stade.Adresse, stade.NombreDePlace, stade.Commission);
        }

        #endregion
    }
}
