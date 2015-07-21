using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Implémentation de ICoupe pour la couche QuidditchPresentationLayerWPF
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

        /// <summary>
        /// Liste des équipes participantes à la coupe du monde
        /// </summary>
        private IList<IEquipe> _equipes;

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

        /// <summary>
        /// Propriété d'accès en lecture/écriture aux équipes
        /// </summary>
        public IList<IEquipe> Equipes
        {
            get { return _equipes; }
            set { _equipes = value; }
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
        /// <param name="equipes">Equipes participantes à la coupe</param>
        public Coupe(int identifiant, DateTime dateDeLaCoupe, IList<IMatch> matches, IList<IEquipe> equipes)
            : base(identifiant)
        {
            DateDeLaCoupe = dateDeLaCoupe;
            Matches = matches;
            Equipes = equipes;
        }

        /// <summary>
        /// Constructeur par copie de la coupe
        /// </summary>
        /// <param name="coupeToCopy">Instance de la classe Coupe à copier</param>
        public Coupe(ICoupe coupeToCopy)
            : this(coupeToCopy.Identifiant, coupeToCopy.DateDeLaCoupe, coupeToCopy.Matches, coupeToCopy.Equipes)
        {

        }

        #endregion

        #region Operations

        /// <summary>
        /// Rédéfinition de ToString
        /// </summary>
        /// <returns>La chaîne représentant l'objet  Coupe</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Coupe : ");
            builder.Append("Date de la coupe ");
            builder.Append(DateDeLaCoupe.ToShortDateString());
            return builder.ToString();
        }

        #endregion
    }
}
