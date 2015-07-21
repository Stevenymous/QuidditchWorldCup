using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
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
        /// <param name="identifiant">Identifiant d'équipe sous forme de chaîne de caractères</param>
        /// <param name="nom">Nom de l'équipe</param>
        /// <param name="pays">Pays d'où provennat l'équipe</param>
        /// <param name="joueurs">Joueurs inscrits dans l'équipe</param>
        /// <returns>L'instance d'une équipe</returns>
        public static IEquipe CreerEquipe(string identifiant, string nom, string pays, IList<IJoueur> joueurs)
        {
            return new Equipe(Convert.ToInt32(identifiant), nom, pays, joueurs);
        }

        #endregion
    }
}
