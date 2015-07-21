using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Fabrique des instances de Equipe
    /// </summary>
    internal static class FabriqueEquipe
    {
        #region Operations
       
        /// <summary>
        /// Fabrique le IEquipe de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="equipe">Equipe de la QuidditchDataAccessLayer</param>
        /// <returns>L'equipe pour la QuidditchBusinessLayer</returns>
        public static IEquipe FabriquerEquipe(QuidditchDataAccessLayer.IEquipe equipe)
        {
            IList<IJoueur> joueurs = new List<IJoueur>();
            equipe.Joueurs.ToList().ForEach(joueur => {
                joueurs.Add(FabriqueJoueur.FabriquerJoueur(joueur));
            });
            return new Equipe(equipe.Identifiant, equipe.Nom, equipe.Pays, joueurs);
        }

        /// <summary>
        /// Fabrique le IEquipe de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="equipe">Equipe de la QuidditchDataAccessLayerBaseDeDonnees</param>
        /// <returns>L'equipe pour la QuidditchBusinessLayer</returns>
        public static IEquipe FabriquerEquipe(QuidditchDataAccessLayerBaseDeDonnees.IEquipe equipe)
        {
            IList<IJoueur> joueurs = new List<IJoueur>();
            equipe.Joueurs.ToList().ForEach(joueur =>
            {
                joueurs.Add(FabriqueJoueur.FabriquerJoueur(joueur));
            });
            return new Equipe(equipe.Identifiant, equipe.Nom, equipe.Pays, joueurs);
        }

        /// <summary>
        /// Fabrique le IEquipe de la QuidditchDataAccessLayerBaseDeDonnees
        /// </summary>
        /// <param name="equipe">Equipe de la QuidditchBusinessLayer</param>
        /// <returns>L'equipe pour la QuidditchDataAccessLayerBaseDeDonnees</returns>
        public static QuidditchDataAccessLayerBaseDeDonnees.IEquipe FabriquerEquipe(IEquipe equipe)
        {
            IList<QuidditchDataAccessLayerBaseDeDonnees.IJoueur> joueurs = new List<QuidditchDataAccessLayerBaseDeDonnees.IJoueur>();
            equipe.Joueurs.ToList().ForEach(joueur =>
            {
                joueurs.Add(FabriqueJoueur.FabriquerJoueur(joueur));
            });
            return new EquipeDal(equipe.Identifiant, equipe.Nom, equipe.Pays, joueurs);
        }

        #endregion
    }
}
