using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayer
{
    /// <summary>
    /// Fabrique d'instances d'implémentation de IMenuManager
    /// </summary>
    public static class FabriqueMenuManager
    {
        #region Operations

        /// <summary>
        /// Permet de fabriquer une instance IMenuManager
        /// </summary>
        /// <param name="presentationManager">Instance implémentée de IPresentationManager</param>
        /// <returns>L'implémentation de IMenuManager</returns>
        public static IMenuManager ConstruireMenuManager(IPresentationManager presentationManager)
        {
            return new ConsoleMenuManager(presentationManager);
        }

        #endregion
    }
}
