using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Définition des caractérisitques d'un Stade
    /// </summary>
    public interface IStade : IEntite
    {
        #region Properties

        /// <summary>
        /// Nom du stade
        /// </summary>
        string Nom
        {
            get;
            set;
        }

        /// <summary>
        /// Adresse du stade
        /// </summary>
        string Adresse
        {
            get;
            set;
        }

        /// <summary>
        /// Nombre de place du stade
        /// </summary>
        int NombreDePlace
        {
            get;
            set;
        }

        /// <summary>
        /// Montant de la commission perçu par place pour le stade
        /// </summary>
        float Commission
        {
            get;
            set;
        }

        #endregion
    }
}
