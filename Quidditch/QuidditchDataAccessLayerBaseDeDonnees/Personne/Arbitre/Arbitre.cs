using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Implémentation de l'interface Arbitre
    /// </summary>
    internal class Arbitre : Personne, IArbitre
    {
        #region Fields

        /// <summary>
        /// Numéro d'assurance vie de l'arbitre
        /// </summary>
        private int _numeroAssuranceVie;

        #endregion

        #region Properties

        /// <summary>
        /// Numéro d'assurance vie de l'arbitre
        /// </summary>
        public int NumeroAssuranceVie
        {
            get
            {
                return _numeroAssuranceVie;
            }
            set
            {
                _numeroAssuranceVie = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Arbitre()
        { }

        /// <summary>
        /// Constructeur d'une instance d'arbitre acceptant 5 arguments
        /// </summary>
        /// <param name="identifiant">Identifiant de l'arbitre</param>
        /// <param name="prenom">Prénom de l'arbitre</param>
        /// <param name="nom">Nom de l'arbitre</param>
        /// <param name="dateDeNaissance">Date de naissance de l'arbitre</param>
        /// <param name="numeroAssuranceVie">Numéro d'assurance vie de l'arbitre</param>
        public Arbitre(int identifiant, string prenom, string nom, DateTime dateDeNaissance, int numeroAssuranceVie)
            : base(identifiant, nom, prenom, dateDeNaissance)
        {
            NumeroAssuranceVie = numeroAssuranceVie;
        }

        /// <summary>
        /// Constructeur par copie d'une instance d'arbitre
        /// </summary>
        /// <param name="arbitreToCopy">L'instance d'arbitre permettant de copier</param>
        public Arbitre(IArbitre arbitreToCopy)
            : this(arbitreToCopy.Identifiant, arbitreToCopy.Nom, arbitreToCopy.Prenom, arbitreToCopy.DateDeNaissance, arbitreToCopy.NumeroAssuranceVie)
        {

        }

        #endregion
    }
}
