using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF 
{
    /// <summary>
    /// Définition des caractéristiques d'un IArbitre
    /// </summary>
    public interface IArbitre : IPersonne
    {
        #region Properties

        /// <summary>
        /// Définissant le numéro de l'assurance vie de l'arbitre
        /// </summary>
        int NumeroAssuranceVie 
        {
            get;
            set;
        }

        /// <summary>
        /// Concaténation du nom et du prénom de l'Arbitre
        /// </summary>
        string PrenomNom
        {
            get;
        }

        #endregion
    }
}
