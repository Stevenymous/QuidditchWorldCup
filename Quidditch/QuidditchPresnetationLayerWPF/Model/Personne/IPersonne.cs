using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Interface représentant une personne
    /// </summary>
    public interface IPersonne : IEntite
    {
        #region Properties

        /// <summary>
        /// Nom de la personne
        /// </summary>
        string Nom
        {
            get;
            set;
        }

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        string Prenom
        {
            get;
            set;
        }

        /// <summary>
        /// Date de naissance de la personne
        /// </summary>
        DateTime DateDeNaissance
        {
            get;
            set;
        }

        #endregion
    }
}
