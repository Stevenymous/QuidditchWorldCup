using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Définition d'une entité représentant un objet métier
    /// </summary>
    public interface IEntite
    {
        /// <summary>
        /// Identifiant de l'entité
        /// </summary>
        int Identifiant
        {
            get;
            set;
        }
    }
}
