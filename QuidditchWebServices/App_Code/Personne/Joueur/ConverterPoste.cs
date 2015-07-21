using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Classe permettant de convertir QuidditchBusinessLayer.Poste en QuidditchWebServices.Poste
    /// </summary>
    internal static class ConverterPoste
    {
        #region Operations

        /// <summary>
        /// Converti la référence sur l'enum Poste 
        /// </summary>
        /// <param name="businessPoste">Poste de la BusinessLayer</param>
        /// <returns>Poste de la QuidditchWebServices</returns>
        public static QuidditchWebServices.Poste Convert(QuidditchBusinessLayer.Poste businessPoste)
        {
            if (businessPoste.ToString() == Poste.Attrapeur.ToString())
            {
                return Poste.Attrapeur;
            }
            else if (businessPoste.ToString() == Poste.Batteur.ToString())
            {
                return Poste.Batteur;
            }
            else if (businessPoste.ToString() == Poste.Gardien.ToString())
            {
                return Poste.Gardien;
            }
            else if (businessPoste.ToString() == Poste.Poursuiveur.ToString())
            {
                return Poste.Poursuiveur;
            }
            else 
            {
                return Poste.None;
            }
        }

        #endregion
    }
}
