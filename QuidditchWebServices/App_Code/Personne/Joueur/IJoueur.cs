using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Interface définissant les caractéristiques d'un Joueur
    /// </summary>
    public interface IJoueur : IPersonne
    {
        #region Properties

        /// <summary>
        /// Définissant si le joueur est un capitaine ou non
        /// </summary>
        bool Capitaine
        {
            get;
            set;
        }

        /// <summary>
        /// Poste occupé par le Joueur
        /// </summary>
        Poste Poste
        {
            get;
            set;
        }

        /// <summary>
        /// Nombre de sélection du joueur
        /// </summary>
        int NombreDeSelection
        {
            get;
            set;
        }
        
        #endregion
    }
}