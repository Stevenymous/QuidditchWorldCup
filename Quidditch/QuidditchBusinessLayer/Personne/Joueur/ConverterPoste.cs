using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Classe permettant de convertir l'objet Poste d'une couche en un objet Poste d'une autre couche 
    /// </summary>
    internal static class ConverterPoste
    {
        #region Operations

        /// <summary>
        /// Converti un QuidditchDataAccessLayer.Poste en QuidditchBusinessLayer.Poste
        /// </summary>
        /// <param name="dalPoste">Poste de la Dal stubbée</param>
        /// <returns>Poste de la couche QuidditchBusinessLayer</returns>
        public static QuidditchBusinessLayer.Poste ConvertFromStub(QuidditchDataAccessLayer.Poste dalPoste)
        {
            if (dalPoste.ToString() == Poste.Attrapeur.ToString())
            {
                return Poste.Attrapeur;
            }
            else if (dalPoste.ToString() == Poste.Batteur.ToString())
            {
                return Poste.Batteur;
            }
            else if (dalPoste.ToString() == Poste.Gardien.ToString())
            {
                return Poste.Gardien;
            }
            else if (dalPoste.ToString() == Poste.Poursuiveur.ToString())
            {
                return Poste.Poursuiveur;
            }
            else 
            {
                return Poste.None;
            }
        }

        /// <summary>
        /// Converti un QuidditchDataAccessLayerBaseDeDonnees.Poste en QuidditchBusinessLayer.Poste
        /// </summary>
        /// <param name="dalPoste">Poste de la Dal correspondante</param>
        /// <returns>Poste de la couche QuidditchBusinessLayer</returns>
        public static QuidditchBusinessLayer.Poste ConvertFromDalDatabase(QuidditchDataAccessLayerBaseDeDonnees.Poste dalPoste)
        {
            if (dalPoste.ToString() == Poste.Attrapeur.ToString())
            {
                return Poste.Attrapeur;
            }
            else if (dalPoste.ToString() == Poste.Batteur.ToString())
            {
                return Poste.Batteur;
            }
            else if (dalPoste.ToString() == Poste.Gardien.ToString())
            {
                return Poste.Gardien;
            }
            else if (dalPoste.ToString() == Poste.Poursuiveur.ToString())
            {
                return Poste.Poursuiveur;
            }
            else
            {
                return Poste.None;
            }
        }

        /// <summary>
        /// Convertie un poste de la business en un poste de la DataAccessLayerBaseDeDonnees
        /// </summary>
        /// <param name="businessPoste">Poste de la business layer</param>
        /// <returns>Poste de la DalBaseDeDonness</returns>
        public static QuidditchDataAccessLayerBaseDeDonnees.Poste ConvertToDalDatabasePoste(QuidditchBusinessLayer.Poste businessPoste)
        {
            if (businessPoste.ToString() == Poste.Attrapeur.ToString())
            {
                return QuidditchDataAccessLayerBaseDeDonnees.Poste.Attrapeur;
            }
            else if (businessPoste.ToString() == Poste.Batteur.ToString())
            {
                return QuidditchDataAccessLayerBaseDeDonnees.Poste.Batteur;
            }
            else if (businessPoste.ToString() == Poste.Gardien.ToString())
            {
                return QuidditchDataAccessLayerBaseDeDonnees.Poste.Gardien;
            }
            else if (businessPoste.ToString() == Poste.Poursuiveur.ToString())
            {
                return QuidditchDataAccessLayerBaseDeDonnees.Poste.Poursuiveur;
            }
            else
            {
                return QuidditchDataAccessLayerBaseDeDonnees.Poste.None;
            }
        }

        #endregion
    }
}
