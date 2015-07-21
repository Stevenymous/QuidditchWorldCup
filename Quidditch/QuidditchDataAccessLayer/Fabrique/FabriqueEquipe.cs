using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Classe permettant de créer une instance des classes implémentant IEquipe
    /// </summary>
    internal static class FabriqueEquipe
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IEquipe
        /// </summary>
        /// <returns>L'instance d'une équipe</returns>
        public static IEquipe CreerEquipe(int identifiant, string nom, string pays, IList<IJoueur> joueurs)
        {
            return new Equipe(identifiant, nom, pays, joueurs);
        }

        #endregion
    }
}
