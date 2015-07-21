using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Implémentation abstraite de IEntité
    /// </summary>
    [DataContract]
    public abstract class Entite : IEntite
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
        [DataMember]
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
        public Entite()
        { }

        /// <summary>
        /// Constructeur d'une Entite acceptant un paramètre l'identifiant de celle-ci
        /// </summary>
        /// <param name="identifiant">Identifiant de l'entité</param>
        public Entite(int identifiant)
        {
            Identifiant = identifiant;
        }

        /// <summary>
        /// Constructeur par copie d'une Entite
        /// </summary>
        /// <param name="entiteToCopy">L'entité à copier</param>
        public Entite(IEntite entiteToCopy)
            :this(entiteToCopy.Identifiant)
        {

        }

        #endregion
    }
}