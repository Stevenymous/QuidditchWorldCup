using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Implémentation de ISpectateur permettant de représenter un spectateur
    /// </summary>
    internal class Spectateur : Personne, ISpectateur
    {
        #region Fields

        /// <summary>
        /// Adresse du spectateur
        /// </summary>
        private string _adresse;

        /// <summary>
        /// Email du spectateur
        /// </summary>
        private string _email;

        /// <summary>
        /// Liste des réservations du spectateur
        /// </summary>
        private IList<IReservation> _reservations;

        #endregion

        #region Properties

        /// <summary>
        /// Adresse du spectateur
        /// </summary>
        public string Adresse
        {
            get
            {
                return _adresse;
            }
            set
            {
                _adresse = value;
            }
        }

        /// <summary>
        /// Email du spectateur
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à la liste des joueurs de l'équipe
        /// </summary>
        public IList<IReservation> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Spectateur()
        { }

        /// <summary>
        /// Constructeur d'un spéctateur acceptant 6 paramètres
        /// </summary>
        /// <param name="identifiant">Identifiant du spectateur</param>
        /// <param name="prenom">Prénom du spectateur</param>
        /// <param name="nom">Nom du spectateur</param>
        /// <param name="dateDeNaissance">Date de naissance du spectateur</param>
        /// <param name="adresse">Adresse du spectateur</param>
        /// <param name="email">Email du spectateur</param>
        /// <param name="reservations">Réservations du spectateur</param>
        public Spectateur(int identifiant, string prenom, string nom, DateTime dateDeNaissance, string adresse, string email, 
            IList<IReservation> reservations)
            : base(identifiant, nom, prenom, dateDeNaissance)
        {
            Adresse = adresse;
            Email = email;
            Reservations = reservations;
        }

        /// <summary>
        /// Constructeur par copie de Spectateur
        /// </summary>
        /// <param name="spectateurToCopy">Instance de Spectateur à copier</param>
        public Spectateur(ISpectateur spectateurToCopy)
            : this(spectateurToCopy.Identifiant, spectateurToCopy.Nom, spectateurToCopy.Prenom, spectateurToCopy.DateDeNaissance, 
                spectateurToCopy.Adresse, spectateurToCopy.Email, spectateurToCopy.Reservations)
        {

        }

        #endregion
    }
}
