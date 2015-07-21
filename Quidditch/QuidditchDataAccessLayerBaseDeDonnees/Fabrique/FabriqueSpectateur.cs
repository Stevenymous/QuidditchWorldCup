using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Fabrique d'instances de ISpectateur
    /// </summary>
    internal static class FabriqueSpectateur
    {
        #region Operations

        /// <summary>
        /// Fabrique l'instance de l'implémentation de ISpectateur
        /// </summary>
        /// <param name="identifiant">Identifiant du spectateur sous forme de chaîne de caractères</param>
        /// <param name="prenom">Prénom du spectateur</param>
        /// <param name="nom">Nom du spectateur</param>
        /// <param name="dateDeNaissance">Date de naissance du spectateur sous forme de chaine de caractères</param>
        /// <param name="adresse">Adresse du spectateur</param>
        /// <param name="mail">Email du spectateur</param>
        /// <param name="reservations">Les réservations du Spectateur</param>
        /// <returns>L'instance d'un spectateur</returns>
        public static ISpectateur CreerSpectateur(string identifiant, string prenom, string nom, string dateDeNaissance, 
            string adresse, string mail, IList<IReservation> reservations)
        {
            return new Spectateur(Convert.ToInt32(identifiant), prenom, nom, Convert.ToDateTime(dateDeNaissance), 
                adresse, mail, reservations);
        }

        #endregion
    }
}
