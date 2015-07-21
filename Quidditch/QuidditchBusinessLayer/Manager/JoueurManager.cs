using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour responsabilité de gérer et contenir les objets métier Joueur et de gérer la communications entre ces objets
    /// </summary>
    internal class JoueurManager 
    {
        #region Fields

        /// <summary>
        /// Les joueurs à gérer
        /// </summary>
        private IList<IJoueur> _joueurs;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture à la liste des joueurs
        /// </summary>
        public IList<IJoueur> Joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant un argument 
        /// </summary>
        /// <param name="joueurs">Joueurs à gérer</param>
        public JoueurManager(IList<IJoueur> joueurs)
        {
            Joueurs = joueurs;
        }

        #endregion
    }
}
