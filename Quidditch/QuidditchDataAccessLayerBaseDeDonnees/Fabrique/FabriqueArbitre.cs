using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Fabrique d'instances de IArbitres
    /// </summary>
    internal static class FabriqueArbitre
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IArbitre
        /// </summary>
        /// <param name="identifiant">Identifiant de l'arbitre sous forme de chaîne de caractères</param>
        /// <param name="prenom">Prénom de l'arbitre</param>
        /// <param name="nom">Nom de l'arbitre</param>
        /// <param name="dateDeNaissance">Date de naissance de l'arbitre sous forme de chaine de caractères</param>
        /// <param name="numeroAssuranceVie">Numéro d'assurance vie de l'arbitre</param>
        /// <returns>L'instance d'un arbitre</returns>
        public static IArbitre CreerArbitre(string identifiant, string prenom, string nom, string dateDeNaissance,
            string numeroAssuranceVie)
        {
            return new Arbitre(Convert.ToInt32(identifiant), prenom, nom, Convert.ToDateTime(dateDeNaissance),
                Convert.ToInt32(numeroAssuranceVie));
        }

        #endregion
    }
}
