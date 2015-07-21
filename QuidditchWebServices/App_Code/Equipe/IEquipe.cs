using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Représentation les caractéristiques de l'Equipe
    /// </summary>
    public interface IEquipe : IEntite
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
        /// Liste des joueurs de l'équipe 
        /// </summary>
        IList<IJoueur> Joueurs
        {
            get;
            set;
        }

        /// <summary>
        /// Pays d'où provient l'équipe
        /// </summary>
        string Pays
        {
            get;
            set;
        }

        #endregion
    }
}
