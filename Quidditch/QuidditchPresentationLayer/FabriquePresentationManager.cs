using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayer
{
    /// <summary>
    /// Fabrique d'instance de IPresentationManager
    /// </summary>
    public static class FabriquePresentationManager
    {
        /// <summary>
        /// Construit une IPresentationManager
        /// </summary>
        /// <returns>Une instance de IPresentationManager</returns>
        public static IPresentationManager ConstruirePresentationManager()
        {
            return new ConsolePresentationManager();
        }
    }
}
