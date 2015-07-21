using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchBusinessLayer;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Fabrique des instances de IJoueur
    /// </summary>
    internal static class FabriqueJoueur
    {
        #region Operations
       
        /// <summary>
        /// Fabrique le IJoueur de la QuidditchPresentationLayerWPF
        /// </summary>
        /// <param name="joueur">Joueur de la businessLayer</param>
        /// <returns>Le joueur pour la présentation layer</returns>
        public static IJoueur FabriquerJoueur(QuidditchBusinessLayer.IJoueur joueur)
        {
            return new Joueur(joueur.Identifiant, joueur.Prenom, joueur.Nom, joueur.DateDeNaissance, joueur.Capitaine,
                ConverterPoste.ConvertToPresentationPoste(joueur.Poste), joueur.NombreDeSelection);
        }

        /// <summary>
        /// Fabrique le IJoueur de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="joueur">Joueur de la QuidditchPresentationLayerWPF</param>
        /// <returns>Le joueur pour la QuidditchBusinessLayer</returns>
        public static QuidditchBusinessLayer.IJoueur FabriquerJoueur(IJoueur joueur)
        {
            return new JoueurBusiness(joueur.Identifiant, joueur.Prenom, joueur.Nom, joueur.DateDeNaissance, joueur.Capitaine,
                ConverterPoste.ConvertToBusinessPoste(joueur.Poste), joueur.NombreDeSelection);
        }

        #endregion
    }
}
