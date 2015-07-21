using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Implémentation de l'équipe dans la BusinessLayer
    /// </summary>
    internal class Equipe : Entite, IEquipe
    {
        #region Fields

        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        private string _nom;

        /// <summary>
        /// Liste des joueurs de l'équipe
        /// </summary>
        private IList<IJoueur> _joueurs;

        /// <summary>
        /// Pays de l'équipe
        /// </summary>
        private string pays;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture au nom de l'équipe
        /// </summary>
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à la liste des joueurs de l'équipe 
        /// </summary>
        public IList<IJoueur> Joueurs
        {
            get 
            {
                return _joueurs; 
            }
            set { _joueurs = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture / écriture au pays
        /// </summary>
        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Equipe()
        { 
        
        }

        /// <summary>
        /// Constructeur d'une équipe acceptant comme arguments l'identifiant de l'équipe, son nom, le nom du pays et ses joueurs
        /// </summary>
        /// <param name="identifiant">Identifiant de l'équipe</param>
        /// <param name="nom">Nom de l'équipe</param>
        /// <param name="pays">Pays de l'équipe</param>
        /// <param name="joueurs">Joueurs de l'équipe</param>
        public Equipe(int identifiant, string nom, string pays, IList<IJoueur> joueurs)
            : base(identifiant)
        {
            Nom = nom;
            Pays = pays;
            Joueurs = joueurs;
        }

        /// <summary>
        /// Constructeur par copie d'une Equipe
        /// </summary>
        /// <param name="equipeToCopy">Instance de l'équipe à copier</param>
        public Equipe(IEquipe equipeToCopy)
            :this(equipeToCopy.Identifiant, equipeToCopy.Nom, equipeToCopy.Pays ,equipeToCopy.Joueurs)
        {
        
        }

        #endregion

        #region Operations

        /// <summary>
        /// Rédéfinition de ToString
        /// </summary>
        /// <returns>La chaîne représentant l'objet Equipe</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Equipe  : ");
            builder.Append("Nom ");
            builder.Append(Nom);
            builder.Append(" pays ");
            builder.Append(Pays);
            return builder.ToString();
        }

        #endregion
    }
}
