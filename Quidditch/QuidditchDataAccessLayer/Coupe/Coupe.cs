using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation de ICoupe
    /// </summary>
    internal class Coupe : Entite, ICoupe
    {
        #region Fields

        /// <summary>
        /// Date de la coupe du monde
        /// </summary>
        private DateTime _dateDeLaCoupe;

        /// <summary>
        /// Liste des matches pendant la coupe du monde
        /// </summary>
        private IList<IMatch> _matches;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture à la date de la coupe
        /// </summary>
        public DateTime DateDeLaCoupe
        {
            get { return _dateDeLaCoupe; }
            set { _dateDeLaCoupe = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture aux matches
        /// </summary>
        public IList<IMatch> Matches
        {
            get { return _matches; }
            set { _matches = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Coupe()
        { 
            
        }

        /// <summary>
        /// Constructeur d'une coupe avec comme arguments, l'identifiant de la coupe, sa date, et les matches joués
        /// </summary>
        /// <param name="identifiant">Identifiant de la coupe</param>
        /// <param name="dateDeLaCoupe">Date à laquelle la coupe est jouée</param>
        /// <param name="matches">Les matches de la coupe</param>
        public Coupe(int identifiant, DateTime dateDeLaCoupe, IList<IMatch> matches)
            : base(identifiant)
        {
            DateDeLaCoupe = dateDeLaCoupe;
            Matches = matches;
        }

        /// <summary>
        /// Constructeur par copie de la coupe
        /// </summary>
        /// <param name="coupeToCopy">Instance de la classe Coupe à copier</param>
        public Coupe(ICoupe coupeToCopy)
            : this(coupeToCopy.Identifiant, coupeToCopy.DateDeLaCoupe, coupeToCopy.Matches)
        {

        }

        #endregion
    }
}
