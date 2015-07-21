using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Implémentation de QuidditchBusinessLayer.IEntite
    /// </summary>
    public abstract class EntiteBusiness : QuidditchBusinessLayer.IEntite
    {
        #region Fields

        /// <summary>
        /// Identifiant de l'entité
        /// </summary>
        protected int _identifiant;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture et écriture à l'identifiant
        /// </summary>
        public int Identifiant
        {
            get
            {
                return _identifiant;
            }
            set
            {
                _identifiant = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public EntiteBusiness()
        { }

        /// <summary>
        /// Constructeur d'une Entite acceptant un paramètre son identifiant
        /// </summary>
        /// <param name="identifiant">Identifiant de l'entité</param>
        public EntiteBusiness(int identifiant)
        {
            Identifiant = identifiant;
        }

        /// <summary>
        /// Constructeur par copie d'une Entite
        /// </summary>
        /// <param name="entiteToCopy">L'entité à copier</param>
        public EntiteBusiness(QuidditchBusinessLayer.IEntite entiteToCopy)
            :this(entiteToCopy.Identifiant)
        {

        }

        #endregion
    }
}