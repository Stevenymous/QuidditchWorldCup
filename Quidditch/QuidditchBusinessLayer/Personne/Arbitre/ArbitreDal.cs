using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Implémentation de IArbitre
    /// </summary>
    internal class ArbitreDal : PersonneDal, QuidditchDataAccessLayerBaseDeDonnees.IArbitre
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
        public ArbitreDal()
        { }

        /// <summary>
        /// Constructeur d'une instance d'arbitre acceptant 5 arguments
        /// </summary>
        /// <param name="identifiant">Identifiant de l'arbitre</param>
        /// <param name="prenom">Prénom de l'arbitre</param>
        /// <param name="nom">Nom de l'arbitre</param>
        /// <param name="dateDeNaissance">Date de naissance de l'arbitre</param>
        /// <param name="numeroAssuranceVie">Numéro d'assurance vie de l'arbitre</param>
        public ArbitreDal(int identifiant, string prenom, string nom, DateTime dateDeNaissance, int numeroAssuranceVie)
            : base(identifiant, nom, prenom, dateDeNaissance)
        {
            NumeroAssuranceVie = numeroAssuranceVie;
        }

        /// <summary>
        /// Constructeur par copie d'une instance d'arbitre
        /// </summary>
        /// <param name="arbitreToCopy">L'instance d'arbitre permettant de copier</param>
        public ArbitreDal(IArbitre arbitreToCopy)
            : this(arbitreToCopy.Identifiant, arbitreToCopy.Nom, arbitreToCopy.Prenom,
                arbitreToCopy.DateDeNaissance, arbitreToCopy.NumeroAssuranceVie)
        {

        }

        #endregion

        #region Operations

        /// <summary>
        /// Rédéfinition de ToString
        /// </summary>
        /// <returns>La chaîne représentant l'objet Arbitre</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.Append("Numéro d'assurence vie : ");
            builder.Append(NumeroAssuranceVie);
            return builder.ToString();
        }

        #endregion
    }
}
