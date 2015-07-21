using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation abstraite de IEntite
    /// </summary>
    internal abstract class Entite : IEntite
    {
        #region Fields

        /// <summary>
        /// Identifiant de l'entité
        /// </summary>
        protected int _identifiant;

        #endregion

        #region Properties

        /// <summary>
        /// Propréité d'accès en lecture et écriture à l'identifiant
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
        public Entite()
        { }

        /// <summary>
        /// Constructeur d'une Entite acceptant un paramètre, son identifiant
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

        #region Operations

        /// <summary>
        /// Surcharge de la méthode GetHashCode
        /// </summary>
        /// <returns>le hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() % Identifiant;
        }

        /// <summary>
        /// Redéfinition de la méthode Equals
        /// </summary>
        /// <param name="objetToCompare">Objet à comparer</param>
        /// <returns>Si les objet sont égales</returns>
        public override bool Equals(Object objetToCompare)
        {
            if (objetToCompare == null || this.GetType() != objetToCompare.GetType())
            {
                return false;
            }

            IEntite entite = (IEntite) objetToCompare;
            return (entite.Identifiant == this.Identifiant);
        }

        #endregion
    }
}
