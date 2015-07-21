using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Fabrique d'instances de IJoueur
    /// </summary>
    internal static class FabriqueJoueur
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de IJoueur
        /// </summary>
        /// <returns>L'instance d'un joueur</returns>
        public static IJoueur CreerJoueur(int identifiant, string prenom, string nom, string dateDeNaissance, 
            bool capitaine, string poste, int nombreDeSelection)
        {
            Poste postePourLeJoueur = ConvertStringToPoste(poste);

            return new Joueur(identifiant, prenom, nom, Convert.ToDateTime(dateDeNaissance), capitaine, postePourLeJoueur, 
                nombreDeSelection);
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
