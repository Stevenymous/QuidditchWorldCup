using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchBusinessLayer;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Fabrique des instances d'IEquipe
    /// </summary>
    internal static class FabriqueEquipe
    {
        #region Operations
       
        /// <summary>
        /// Fabrique l'IEquipe de la QuidditchPresentationLayerWPF
        /// </summary>
        /// <param name="equipe">Equipe de la businessLayer</param>
        /// <returns>Le equipe pour la présentation layer</returns>
        public static IEquipe FabriquerEquipe(QuidditchBusinessLayer.IEquipe equipe)
        {
            IList<IJoueur> joueurs = new List<IJoueur>();
            equipe.Joueurs.ToList().ForEach(joueur => {
                joueurs.Add(FabriqueJoueur.FabriquerJoueur(joueur));
            });
            return new Equipe(equipe.Identifiant, equipe.Nom, equipe.Pays, joueurs);
        }

        /// <summary>
        /// Fabrique l'IEquipe de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="equipe">Equipe de la QuidditchPresentationLayerWPF</param>
        /// <returns>Le equipe pour la businessLayer</returns>
        public static QuidditchBusinessLayer.IEquipe FabriquerEquipe(IEquipe equipe)
        {
            IList<QuidditchBusinessLayer.IJoueur> joueurs = new List<QuidditchBusinessLayer.IJoueur>();
            equipe.Joueurs.ToList().ForEach(joueur => {
                joueurs.Add(FabriqueJoueur.FabriquerJoueur(joueur));
            });
            return new EquipeBusiness(equipe.Identifiant, equipe.Nom, equipe.Pays, joueurs);
        }
        #endregion
    }
}
