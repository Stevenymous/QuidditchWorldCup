using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Fabrique d'instances de IJoueurs
    /// </summary>
    internal static class FabriqueJoueur
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IJoueur
        /// </summary>
        /// <param name="identifiant">Identifiant du joueur sous forme de chaîne de caractères</param>
        /// <param name="prenom">Prénom du joueur</param>
        /// <param name="nom">Nom du joueur</param>
        /// <param name="dateDeNaissance">Date de naissance du joueur sous forme de chaine de caractères</param>
        /// <param name="capitaine">Indique si le joueur est capitaine sous forme de chaîne de caractères</param>
        /// <param name="poste">Poste occupé par le joueur</param>
        /// <param name="nombreDeSelection">Nombre de sélection du joueur en chaîne de caractères</param>
        /// <returns>L'instance d'un joueur</returns>
        public static IJoueur CreerJoueur(string identifiant, string prenom, string nom, string dateDeNaissance, 
            string capitaine, string poste, string nombreDeSelection)
        {
            return new Joueur(Convert.ToInt32(identifiant), prenom, nom, Convert.ToDateTime(dateDeNaissance), 
                Convert.ToBoolean(capitaine), ConvertStringToPoste(poste), 
                Convert.ToInt32(nombreDeSelection));
        }

        /// <summary>
        /// Converti une chaine de caractères en un élement de l'énumération Poste
        /// </summary>
        /// <param name="poste">Chaine de caractères à convertir</param>
        /// <returns>Retourne le poste</returns>
        private static Poste ConvertStringToPoste(string poste)
        {
            Poste postePourLeJoueur;

            if (poste == Poste.Attrapeur.ToString())
            {
                postePourLeJoueur = Poste.Attrapeur;
            }
            else if (poste == Poste.Batteur.ToString())
            {
                postePourLeJoueur = Poste.Batteur;
            }
            else if (poste == Poste.Gardien.ToString())
            {
                postePourLeJoueur = Poste.Gardien;
            }
            else if (poste == Poste.Poursuiveur.ToString())
            {
                postePourLeJoueur = Poste.Poursuiveur;
            }
            else
            {
                postePourLeJoueur = Poste.None;
            }
            return postePourLeJoueur;
        }

        #endregion
    }
}
