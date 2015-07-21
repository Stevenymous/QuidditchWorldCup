using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuidditchWebServices;

namespace QuidditchWebServices
{
    /// <summary>
    /// Permet de fabriquer des QuidditchWebServices.IEquipe à partir de QuidditchBusinessLayer.IEquipe
    /// </summary>
    public static class FabriqueEquipe
    {
        /// <summary>
        /// Fabrique un QuidditchWebServices.IEquipe à partir d'un QuidditchBusinessLayer.IEquipe
        /// </summary>
        /// <param name="equipe">QuidditchBusinessLayer.IEquipe pour construire l'objet demandé</param>
        /// <returns>QuidditchWebServices.IEquipe créé</returns>
        public static QuidditchWebServices.IEquipe FabriquerEquipe(QuidditchBusinessLayer.IEquipe equipe)
        {
            IList<QuidditchWebServices.IJoueur> joueurs = new List<QuidditchWebServices.IJoueur>();
            equipe.Joueurs.ToList().ForEach(joueur =>
            {
                joueurs.Add(FabriqueJoueur.FabriquerJoueur(joueur));
            });
            return new Equipe(equipe.Identifiant, equipe.Nom, equipe.Pays, joueurs);
        }
    }
}