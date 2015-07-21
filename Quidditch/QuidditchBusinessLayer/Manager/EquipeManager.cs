using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuidditchDataAccessLayer;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// A pour responsabilité de gérer et contenir les objets métier Equipe et de gérer la communications entre ces objets
    /// </summary>
    internal class EquipeManager 
    {
        #region Fields

        /// <summary>
        /// Les équipes à gérer
        /// </summary>
        private IList<IEquipe> _equipes;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture à la liste des équipes
        /// </summary>
        public IList<IEquipe> Equipes
        {
            get { return _equipes; }
            set { _equipes = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur acceptant un argument
        /// </summary>
        /// <param name="equipes">Les équipes à gérer</param>
        public EquipeManager(IList<IEquipe> equipes)
        {
            Equipes = equipes;
        }

        #endregion
    }
}
