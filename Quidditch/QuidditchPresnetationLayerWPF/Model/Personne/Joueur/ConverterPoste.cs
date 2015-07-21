using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchBusinessLayer;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Classe permettant de convertir QuidditchBusinessLayer.Poste en QuidditchPresentationLayerWPF.Poste et inversement
    /// </summary>
    internal static class ConverterPoste
    {
        #region Operations

        /// <summary>
        /// Convertie un poste de la business en un poste de la présentationLayerWPF
        /// </summary>
        /// <param name="businessPoste">Poste de la business layer</param>
        /// <returns>Poste de la présentation wpf layer</returns>
        public static QuidditchPresentationLayerWPF.Poste ConvertToPresentationPoste(QuidditchBusinessLayer.Poste businessPoste)
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

        /// <summary>
        /// Convertie un poste de la présentationLayerWPF en un poste de la businessLayer
        /// </summary>
        /// <param name="businessPoste">Poste de la business layer</param>
        /// <returns>Poste de la présentation wpf layer</returns>
        public static QuidditchBusinessLayer.Poste ConvertToBusinessPoste(QuidditchPresentationLayerWPF.Poste poste)
        {
            if (poste.ToString() == Poste.Attrapeur.ToString())
            {
                return QuidditchBusinessLayer.Poste.Attrapeur;
            }
            else if (poste.ToString() == Poste.Batteur.ToString())
            {
                return QuidditchBusinessLayer.Poste.Batteur;
            }
            else if (poste.ToString() == Poste.Gardien.ToString())
            {
                return QuidditchBusinessLayer.Poste.Gardien;
            }
            else if (poste.ToString() == Poste.Poursuiveur.ToString())
            {
                return QuidditchBusinessLayer.Poste.Poursuiveur;
            }
            else 
            {
                return QuidditchBusinessLayer.Poste.None;
            }
        }

        #endregion
    }
}
