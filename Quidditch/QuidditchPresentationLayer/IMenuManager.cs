using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayer
{
    /// <summary>
    /// Définition du manager de l'interface du menu
    /// </summary>
    public interface IMenuManager
    {
        #region Operations

        /// <summary>
        /// Permet de récupérer le choix de l'utilisateur
        /// </summary>
        void GetChoiceFromUser();

        #endregion
    }
}
