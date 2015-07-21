using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Permet de fabriquer des QuidditchWebServices.IJoueur à partir de QuidditchBusinessLayer.IJoueur
    /// </summary>
    public static class FabriqueJoueur
    {
        /// <summary>
        /// Fabrique un QuidditchWebServices.IJoueur à partir d'un QuidditchBusinessLayer.IJoueur
        /// </summary>
        /// <param name="joueur">QuidditchBusinessLayer.IJoueur pour construire l'objet demandé</param>
        /// <returns>QuidditchWebServices.IJoueur créé</returns>
        public static QuidditchWebServices.IJoueur FabriquerJoueur(QuidditchBusinessLayer.IJoueur joueur)
        {
            return new Joueur(joueur.Identifiant, joueur.Prenom, joueur.Nom, joueur.DateDeNaissance, joueur.Capitaine,
                ConverterPoste.Convert(joueur.Poste), joueur.NombreDeSelection);
        }
    }
}