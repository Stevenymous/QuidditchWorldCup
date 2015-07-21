﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Implémentation abstraite de IPersonne
    /// </summary>
    internal abstract class Personne : Entite, IPersonne
    {
        #region Fields

        /// <summary>
        /// Nom de la personne
        /// </summary>
        protected string _nom;

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        protected string _prenom;

        /// <summary>
        /// Date de naissance de la personne
        /// </summary>
        protected DateTime dateDeNaissance;

        #endregion

        #region Properties

        /// <summary>
        /// Nom de la personne
        /// </summary>
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
            }
        }

        /// <summary>
        /// Date de naissance de la personne
        /// </summary>
        public DateTime DateDeNaissance
        {
            get
            {
                return dateDeNaissance;
            }
            set
            {
                dateDeNaissance = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Personne()
        { }

        /// <summary>
        /// Constructeur d'une personne avec son idientifiant, son nom, son prénom et sa date de naissance
        /// </summary>
        /// <param name="identifiant">Identifiant de la personne</param>
        /// <param name="prénom">Prénom de la personne</param>
        /// <param name="nom">Nom de la personne</param>
        /// <param name="dateDeNaissance">Date de naissance de la personne</param>
        public Personne(int identifiant, string prénom, string nom, DateTime dateDeNaissance)
            : base(identifiant)
        {
            Prenom = prénom;
            Nom = nom;
            DateDeNaissance = dateDeNaissance;
        }

        /// <summary>
        /// Constructeur par copie d'une instance de Personne
        /// </summary>
        /// <param name="personneToCopy">Instance de la classe personne à copier</param>
        public Personne(IPersonne personneToCopy)
            :this(personneToCopy.Identifiant, personneToCopy.Prenom, personneToCopy.Nom, 
                personneToCopy.DateDeNaissance)
        {

        }

        #endregion
    }
}
