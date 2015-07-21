using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Fabrique des instances de IJoueur
    /// </summary>
    internal static class FabriqueJoueur
    {
        #region Operations
       
        /// <summary>
        /// Fabrique le IJoueur de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="joueur">Joueur de la DataAccessLayer</param>
        /// <returns>Le joueur pour la QuidditchBusinessLayer</returns>
        public static IJoueur FabriquerJoueur(QuidditchDataAccessLayer.IJoueur joueur)
        {
            return new Joueur(joueur.Identifiant, joueur.Prenom, joueur.Nom, joueur.DateDeNaissance, joueur.Capitaine,
                ConverterPoste.ConvertFromStub(joueur.Poste), joueur.NombreDeSelection);
        }

        /// <summary>
        /// Fabrique le IJoueur de la QuidditchBusinessLayer
        /// </summary>
        /// <param name="joueur">Joueur de la QuidditchDataAccessLayerBaseDeDonnees</param>
        /// <returns>Le joueur pour la QuidditchBusinessLayer</returns>
        public static IJoueur FabriquerJoueur(QuidditchDataAccessLayerBaseDeDonnees.IJoueur joueur)
        {
            return new Joueur(joueur.Identifiant, joueur.Prenom, joueur.Nom, joueur.DateDeNaissance, joueur.Capitaine,
                ConverterPoste.ConvertFromDalDatabase(joueur.Poste), joueur.NombreDeSelection);
        }

        /// <summary>
        /// Fabrique le IJoueur de la QuidditchDataAccessLayerBaseDeDonness 
        /// </summary>
        /// <param name="joueur">Joueur de la QuidditchBusinessLayer</param>
        /// <returns>Le joueur pour la QuidditchDataAccessLayerBaseDeDonness</returns>
        public static QuidditchDataAccessLayerBaseDeDonnees.IJoueur FabriquerJoueur(IJoueur joueur)
        {
            return new JoueurDal(joueur.Identifiant, joueur.Prenom, joueur.Nom, joueur.DateDeNaissance, joueur.Capitaine,
                ConverterPoste.ConvertToDalDatabasePoste(joueur.Poste), joueur.NombreDeSelection);
        }

        #endregion
    }
}
