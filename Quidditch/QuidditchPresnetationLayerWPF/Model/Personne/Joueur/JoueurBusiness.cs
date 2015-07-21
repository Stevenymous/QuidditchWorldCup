using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Implémentation de IJoueur représentation d'un joueur dans la BusinessLayer
    /// </summary>
    internal class JoueurBusiness : PersonneBusiness, QuidditchBusinessLayer.IJoueur
    {
        #region Fields

        /// <summary>
        /// Si le joueur est capitaine ou non
        /// </summary>
        private bool _capitaine;

        /// <summary>
        /// Poste du joueur
        /// </summary>
        private QuidditchBusinessLayer.Poste _poste;

        /// <summary>
        /// Nombre de sélection du joueur
        /// </summary>
        private int _nombreDeSelection;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'attribut capitaine
        /// </summary>
        public bool Capitaine
        {
            get
            {
                return _capitaine;
            }
            set
            {
                _capitaine = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'attribut Poste
        /// </summary>
        public QuidditchBusinessLayer.Poste Poste
        {
            get
            {
                return _poste;
            }
            set
            {
                _poste = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'attribut nombreDeSelection
        /// </summary>
        public int NombreDeSelection
        {
            get
            {
                return _nombreDeSelection;
            }
            set
            {
                _nombreDeSelection = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public JoueurBusiness()
        { }

        /// <summary>
        /// Constructeur d'un joueur acceptant 6 arguments
        /// </summary>
        /// <param name="identifiant">Identifiant du joueur</param>
        /// <param name="prenom">Prénom du joueur</param>
        /// <param name="nom">Nom du joueur</param>
        /// <param name="dateDeNaissance">Date de naissance du joueur</param>
        /// <param name="isCapitaine">Si le joueur est capitaine</param>
        /// <param name="poste">Poste du joueur</param>
        /// <param name="scoreCoupe">Score du joueur durant la coupe</param>
        /// <param name="nombreDeSelection">Nombre de sélection du joueur</param>
        public JoueurBusiness(int identifiant, string prenom, string nom, DateTime dateDeNaissance, bool isCapitaine, 
            QuidditchBusinessLayer.Poste poste, int nombreDeSelection)
            : base(identifiant, prenom, nom, dateDeNaissance)
        {
            Capitaine = isCapitaine;
            Poste = poste;
            NombreDeSelection = nombreDeSelection;
        }

        /// <summary>
        /// Constructeur par copie d'un joueur
        /// </summary>
        /// <param name="joueurToCopy">L'instance de joueur à copier</param>
        public JoueurBusiness(QuidditchBusinessLayer.IJoueur joueurToCopy)
            : this(joueurToCopy.Identifiant, joueurToCopy.Prenom, joueurToCopy.Nom, 
                joueurToCopy.DateDeNaissance, joueurToCopy.Capitaine, joueurToCopy.Poste, 
                joueurToCopy.NombreDeSelection)
        {

        }

        #endregion

        #region Operations

        /// <summary>
        /// Rédéfinition de ToString
        /// </summary>
        /// <returns>La chaîne représentant l'objet Personne</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.Append("Poste : ");
            builder.Append(Poste.ToString());
            builder.Append(" nombre de sélection : ");
            builder.Append(NombreDeSelection);
            return builder.ToString();
        }

        #endregion
    }
}
