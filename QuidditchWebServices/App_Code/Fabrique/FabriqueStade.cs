using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Permet de fabriquer des QuidditchWebServices.IStade à partir de QuidditchBusinessLayer.IStade
    /// </summary>
    public static class FabriqueStade
    {
        /// <summary>
        /// Fabrique un QuidditchWebServices.IStade à partir d'un QuidditchBusinessLayer.IStade
        /// </summary>
        /// <param name="stade">QuidditchBusinessLayer.IStade  pour construire l'objet demandé</param>
        /// <returns>QuidditchWebServices.IStade créé</returns>
        public static QuidditchWebServices.IStade FabriquerStade(QuidditchBusinessLayer.IStade stade)
        {
            return new Stade(stade.Identifiant, stade.Nom, stade.Adresse, stade.NombreDePlace, stade.Commission);
        }
    }
}